using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DigitalClassroom.EntityLayer.Concrete;
using DevExpress.XtraRichEdit.Services;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.BusinessLayer.Managers;
using DevExpress.Xpo.DB.Helpers;
using DigitalClassroom.Forms.Controls.Pages.Institutions;
using DevExpress.Utils.Extensions;
using DigitalClassroom.BusinessLayer.Validations.Courses;

namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    public partial class EditCourse : DevExpress.XtraEditors.XtraUserControl
    {
        private Course course;
        private User user;
        private User teacher;
        private IEnumerable<User> selectedTeachers;
        private IEnumerable<Institution> institutions;
        private IUserService userService;
        private IInstitutionService institutionService;
        private ICourseService courseService;

        public EditCourse(Course course, User user)
        {
            InitializeComponent();
            this.course = course;
            this.user = user;
            userService = new UserManager(new UserRepository(new AppDbContext()));
            institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
            courseService = new CourseManager(new CourseRepository(new AppDbContext()));
        }

        private void EditCourse_Load(object sender, EventArgs e)
        {
            GetTeachersAndInstitutionsByUserRole();
            ViewCourseInfo();
        }

        private void GetTeachersAndInstitutionsByUserRole()
        {
            switch (user.RoleId)
            {
                case (int)Role.RoleNames.Teacher:

                    lblSelectInstitution.Visible = false;
                    lblSelectTeacher.Visible = false;
                    comboBox_Teachers.Visible = false;
                    comboBox_Institutions.Visible = false;
                    /*
                    //comboBox_Teachers.Text = user.Name + " " + user.Surname;
                    //comboBox_Teachers.ValueMember = user.Id.ToString();
                    //comboBox_Teachers.Enabled = false;
                    //comboBox_Institutions.Text = user.Institution.Name;
                    //comboBox_Institutions.ValueMember = user.InstitutionId.ToString();
                    //comboBox_Institutions.Enabled = false;
                    */
                    break;

                case (int)Role.RoleNames.Admin:

                    institutions = institutionService.GetAll().Where(x => x.IsActive == true);
                    foreach (var institution in institutions)
                    {
                        comboBox_Institutions.Items.Add(institution.Name);
                        comboBox_Institutions.ValueMember = institution.Id.ToString();
                    }

                    selectedTeachers = userService.GetTeachersByInstitutionId(null);
                    foreach (var teacher in selectedTeachers)
                    {
                        comboBox_Teachers.Items.Add(teacher.Name + " " + teacher.Surname);
                        comboBox_Teachers.ValueMember = teacher.Id.ToString();
                    }
                    break;

                case (int)Role.RoleNames.Manager:

                    comboBox_Institutions.Text = user.Institution.Name;
                    comboBox_Institutions.ValueMember = user.InstitutionId.ToString();
                    comboBox_Institutions.Visible = false;

                    selectedTeachers = userService.GetTeachersByInstitutionId(course.InstitutionId);
                    foreach (var teacher in selectedTeachers)
                    {
                        comboBox_Teachers.Items.Add(teacher.Name + " " + teacher.Surname);
                        comboBox_Teachers.ValueMember = teacher.Id.ToString();
                    }
                    break;
            }
        }

        private void ViewCourseInfo()
        {
            txtCourseTitle.Text = course.Title;
            txtCapacityOfCourse.Text = course.CourseCapacity.ToString();
            txtDescription.Text = course.Description;
            if (user.RoleId == (int)Role.RoleNames.Admin)
            {
                if (course.InstitutionId != null)
                    comboBox_Institutions.Text = institutions.FirstOrDefault(x => x.Id == course.InstitutionId).Name;
                else
                    comboBox_Institutions.Text = "Bireysel";
                var courseTeacher = selectedTeachers.FirstOrDefault(x => x.Id == course.TeacherId);
                // Seçilen kursun öğretmeninin ismini comboBox'ta seçili hale getir
                comboBox_Teachers.Text = courseTeacher.Name + " " + courseTeacher.Surname;
            }
            if (user.RoleId == (int)Role.RoleNames.Manager)
            {
                // Seçilen kursun öğretmeninin ismini comboBox'ta seçili hale getir, kurum müdürü sadece kendi kurumunun öğretmenlerini görebilir
                var courseTeacher = selectedTeachers.FirstOrDefault(x => x.Id == course.TeacherId);
                // Seçilen kursun öğretmeninin ismini comboBox'ta seçili hale getir
                comboBox_Teachers.Text = courseTeacher.Name + " " + courseTeacher.Surname;
            }
        }

        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Teachers.Visible == true)
                {
                    // Kursun öğretmeninin değişip değişmediğini kontrol et
                    if (comboBox_Teachers.Text != course.Teacher.Name + " " + course.Teacher.Surname)
                    {
                        course.TeacherId = selectedTeachers.FirstOrDefault(t => t.Name + " " + t.Surname == comboBox_Teachers.Text).Id;
                        course.InstitutionId = selectedTeachers.FirstOrDefault(t => t.Name + " " + t.Surname == comboBox_Teachers.Text).InstitutionId;
                    }
                }
                course.Title = txtCourseTitle.Text;
                if (!string.IsNullOrEmpty(txtCapacityOfCourse.Text))
                    course.CourseCapacity = int.Parse(txtCapacityOfCourse.Text);
                course.Description = txtDescription.Text;

                if (ValidateCourse(course))
                {
                    courseService.Update(course);
                    XtraMessageBox.Show("Kurs başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Kurs bilgilerini güncelledikten sonra sayfayı yenile
                    RefreshContent(course, user);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kurs güncellenirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCourse_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Kursu silmek istediğinize emin misiniz?", "Kurs Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    course.IsActive = false;
                    course.DeactivetedDate = DateTime.Now;
                    course.DeactivetedReason = $"Kurs {user.Name} {user.Surname} tarafından silindi.";
                    ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
                    courseService.Update(course);
                    XtraMessageBox.Show("Kurs başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Kurs silindikten sonra sayfayı yenile
                    ReturnHomePage(user);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Kurs silinirken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void ReturnHomePage(User user)
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();
            // Yeni kontrolü ekle
            var newControl = new HomePage.HomePage(user);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void comboBox_Institutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Teachers.Items.Clear();
            comboBox_Teachers.Enabled = true;

            if (comboBox_Institutions.Text == "<Tüm Öğretmenleri Listele>")
            {
                selectedTeachers = userService.GetTeachersByInstitutionId(null);
                if (selectedTeachers.Count() > 0)
                {
                    selectedTeachers.ToList().ForEach(t => comboBox_Teachers.Items.Add(t.Name + " " + t.Surname));
                    selectedTeachers.ToList().ForEach(t => comboBox_Teachers.ValueMember = t.Id.ToString());
                }

            }
            else if (comboBox_Institutions.Text == "Bireysel")
            {
                selectedTeachers = userService.GetTeachersByInstitutionId(null).Where(t => t.InstitutionId == null);
                if (selectedTeachers.Count() > 0)
                {
                    selectedTeachers.ToList().ForEach(t => comboBox_Teachers.Items.Add(t.Name + " " + t.Surname));
                    selectedTeachers.ToList().ForEach(t => comboBox_Teachers.ValueMember = "No Institution");
                }
            }
            else
            {
                int selectedInstitutionId = institutions.ToList().Find(i => i.Name == comboBox_Institutions.Text).Id;
                GetTeachersByInstitutionId(selectedInstitutionId);
            }

            CheckTeachersCount();
        }

        private void CheckTeachersCount()
        {
            if (comboBox_Teachers.Items.Count == 0)
            {
                comboBox_Teachers.Items.Add("Kurumda öğretmen bulunmamaktadır.");
                comboBox_Teachers.SelectedIndex = 0;
                comboBox_Teachers.Enabled = false;
            }
            else
            {
                comboBox_Teachers.SelectedIndex = 0;
            }
        }

        private void GetTeachersByInstitutionId(int institutionId)
        {
            selectedTeachers = userService.GetTeachersByInstitutionId(institutionId).ToList();
            if (selectedTeachers.Count() > 0)
            {
                selectedTeachers.ToList().ForEach(t => comboBox_Teachers.Items.Add(t.Name + " " + t.Surname));
                selectedTeachers.ToList().ForEach(t => comboBox_Teachers.ValueMember = ((int)t.InstitutionId).ToString());
            }
        }
        public void RefreshContent(Course course, User user)
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new EditCourse(course, user);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }
        private bool ValidateCourse(Course course)
        {
            var validator = new CreateCourseValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate(course);
            if (!result.IsValid)
            {
                // Tüm hataları tek bir mesajda ilet
                string errorMessage = result.Errors.Select(x => x.ErrorMessage).Aggregate((i, j) => i + "\n" + j);
                XtraMessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}