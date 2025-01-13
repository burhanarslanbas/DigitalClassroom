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
using DigitalClassroom.DataAccessLayer.Contexts;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.DataAccessLayer.Repositories;
using DevExpress.Utils.Extensions;
using DigitalClassroom.BusinessLayer.Validations.Announcements;
using DigitalClassroom.BusinessLayer.Validations.Courses;

namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    public partial class CreateCourse : DevExpress.XtraEditors.XtraUserControl
    {
        private User user;
        private int teacherId;
        private int? institutionId;
        private IEnumerable<User> selectedTeachers;
        private IEnumerable<Institution> institutions;
        private IUserService userService;
        public CreateCourse(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {
            EditItemsVisibilityByUserRole(user.Role);
        }

        private void GetAllInstitutionsName()
        {
            IInstitutionService institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
            institutions = institutionService.GetAll();
            institutions.ForEach(i => comboBox_Institutions.Items.Add(i.Name));
            institutions.ForEach(i => comboBox_Institutions.ValueMember = i.Id.ToString());
        }
        private string GenerateUniqueAttendanceCode()
        {
            // Oluşturulan kodun benzersiz olup olmadığını kontrol etmek için veritabanında daha önce oluşturulmuş bir kod var mı diye kontrol edilir.
            // Eğer varsa yeni bir kod oluşturulur ve geri döndürülür.
            string attendanceCode = GetAttendanceCode();
            ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
            while (courseService.Find(x => x.AttendanceCode == attendanceCode).Count() > 0)
            {
                attendanceCode = GetAttendanceCode();
            }
            return attendanceCode;
        }

        private void EqualizeInstitutionId()
        {
            if (user.Role.RoleName == "Admin")
            {
                int selectedTeacherId = selectedTeachers.ElementAt(comboBox_Teachers.SelectedIndex).Id;
                institutionId =  selectedTeachers.Where(x => x.Id == selectedTeacherId).FirstOrDefault().InstitutionId;
            }
            else
            {
                institutionId = user.InstitutionId;
            }
        }

        private string GetAttendanceCode()
        {
            // 6 haneden oluşan büyük küçük harf ve rakamlardan oluşan rastgele bir kod oluşturulur.
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void EqualizeTeacherId()
        {
            // Eğer comboBox_Teachers görünür değilse, o zaman kullanıcı öğretmendir ve öğretmen Id'si user.Id olacaktır.
            if (comboBox_Teachers.Visible != true)
            {
                teacherId = user.Id;
            }
            else
            {
                // Eğer comboBox_Teachers'ta öğretmen seçilmişse, o zaman seçilen öğretmenin Id'si teacherId olacaktır.
                teacherId = selectedTeachers.ElementAt(comboBox_Teachers.SelectedIndex).Id;
            }
        }

        private void EditItemsVisibilityByUserRole(Role userRole)
        {
            switch (userRole.Id)
            {
                case (int)Role.RoleNames.Admin:
                    lblSelectInstitution.Visible = true;
                    comboBox_Institutions.Visible = true;
                    lblSelectTeacher.Visible = true;
                    comboBox_Teachers.Visible = true;
                    GetAllInstitutionsName();
                    userService = new UserManager(new UserRepository(new AppDbContext()));
                    break;
                case (int)Role.RoleNames.Manager:
                    lblSelectTeacher.Visible = true;
                    comboBox_Teachers.Visible = true;
                    userService = new UserManager(new UserRepository(new AppDbContext()));
                    // Eğer kullanıcı kurum müdürü ise, o zaman sadece kendi kurumundaki öğretmenleri görebilir.
                    GetTeachersByInstitutionId(user.InstitutionId.HasValue ? user.InstitutionId.Value : 0);
                    CheckTeachersCount();
                    break;

            }
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

        private void comboBox_Teachers_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        public void ReturnHomePage(User user)
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

        private void btnCreateCourse_Click_1(object sender, EventArgs e)
        {
            btnCreateCourse.Enabled = false;
            try
            {
                EqualizeTeacherId();
                EqualizeInstitutionId();
                string attendanceCode = GenerateUniqueAttendanceCode();
                Course course = new Course()
                {
                    Title = txtCourseTitle.Text,
                    Description = txtDescription.Text,
                    TeacherId = teacherId,
                    InstitutionId = institutionId,
                    AttendanceCode = attendanceCode,
                    CreatorId = user.Id,
                    CreatedAt = DateTime.Now,
                    IsActive = true
                };

                // Eğer kurs kapasitesi girilmişse, o zaman kurs kapasitesi course objesine atanır.
                if (!string.IsNullOrEmpty(txtCapacityOfCourse.Text))
                {
                    course.CourseCapacity = Convert.ToInt32(txtCapacityOfCourse.Text);
                }

                if (ValidateCourse(course))
                {
                    ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
                    courseService.Add(course);
                    XtraMessageBox.Show("Kurs oluşturma işlemi başarılı bir şekilde gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnHomePage(user);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kurs oluşturma işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCreateCourse.Enabled = true;

            /* Dosya ile ilgili işlemler (eklenmesi planlanıyor)
             * Eğer kurs resim yolu girilmişse, o zaman yeni bir File ve FileAssociation objesi oluşturulur ve veritabanına kaydedilir.
            //if (!string.IsNullOrEmpty(txtCourseImageUrl.Text))
            //{
            //    File file = new File()
            //    {
            //        UploaderId = user.Id,
            //        Name = "CourseImageUrl",
            //        Path = txtCourseImageUrl.Text,
            //        Type = "Image",
            //        Size = 0,
            //        UploadedAt = DateTime.Now,
            //        Metadata = "Course Image"
            //    };

            //    // Oluşturulan file dosyasını veritabanına kaydettikten sonra Id'sini al
            //    IFileService fileService = new FileManager(new FileRepository(new AppDbContext()));
            //    fileService.Add(file);
            //    FileAssociation fileAssociation = new FileAssociation()
            //    {
            //        File = file,
            //        Course = course
            //    };
            //    course.FileAssociations.Add(fileAssociation);
            //}
            */
        }
    }
}