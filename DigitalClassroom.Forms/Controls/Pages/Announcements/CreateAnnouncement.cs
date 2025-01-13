using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.BusinessLayer.Validations.Users;
using DigitalClassroom.BusinessLayer.Validations.Announcements;

namespace DigitalClassroom.Forms.Controls.Pages.Announcements
{
    public partial class CreateAnnouncement : DevExpress.XtraEditors.XtraUserControl
    {
        private IEnumerable<Institution> institutions;
        private IEnumerable<Course> courses;
        private User user;
        public CreateAnnouncement(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            btnCreateAnnouncement.Enabled = false;


            try
            {
                Announcement announcement = new Announcement()
                {
                    CreatorId = user.Id,
                    Title = txtTitle.Text,
                    Message = txtMessage.Text,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                };

                if (user.Role.RoleName == Role.RoleNames.Admin.ToString())
                {
                    if (comboBox_Institutions.SelectedIndex != -1)
                    {
                        if (comboBox_Institutions.Text != "Tüm Kurumlar")
                        {
                            int institutionId = institutions.FirstOrDefault(i => i.Name == comboBox_Institutions.Text)?.Id ?? -1;
                            announcement.InstitutionId = institutionId;
                        }
                    }
                }
                else
                {
                    // Eğer kullanıcının institutionId'si boş değilse yani bir kuruma aitse o kurumun id'sini al
                    if (user.InstitutionId != null)
                    {
                        announcement.InstitutionId = user.InstitutionId;
                    }
                }
                if (comboBox_Courses.SelectedIndex!=-1)
                {
                    if (comboBox_Courses.Text != "Tüm Kurslar")
                    {
                        int courseId = courses.FirstOrDefault(c => c.Title == comboBox_Courses.Text)?.Id ?? -1;
                        announcement.CourseId = courseId;
                    }
                }
                if (ValidateAnnouncement(announcement))
                {
                    IAnnouncementService announcementService = new AnnouncementManager(new AnnouncementRepository(new AppDbContext()));
                    announcementService.Add(announcement);
                    XtraMessageBox.Show("Duyuru oluşturma işlemi başarılı bir şekilde gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnHomePage(this.user);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Duyuru oluşturma işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            btnCreateAnnouncement.Enabled = true;
        }

        private bool ValidateAnnouncement(Announcement announcement)
        {
            var validator = new CreateAnnouncementValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate(announcement);
            if (!result.IsValid)
            {
                // Tüm hataları tek bir mesajda ilet
                string errorMessage = result.Errors.Select(x => x.ErrorMessage).Aggregate((i, j) => i + "\n" + j);
                XtraMessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CreateAnnouncement_Load(object sender, EventArgs e)
        {
            if (user.Role.RoleName == Role.RoleNames.Admin.ToString())
            {
                IInstitutionService institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
                institutions = institutionService.Find(x => x.IsActive == true);
                foreach (var institution in institutions)
                {
                    comboBox_Institutions.Items.Add(institution.Name);
                }
                comboBox_Institutions.Visible = true;
            }
            // Eğer kullanıcının rolü Kurum Müdürü ise ilgili kurumun tüm kurslarını getir
            else if (user.Role.RoleName == Role.RoleNames.Manager.ToString())
            {
                ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
                courses = courseService.Find(x => x.IsActive == true && x.InstitutionId == user.InstitutionId);
                foreach (var course in courses)
                {
                    comboBox_Courses.Items.Add(course.Title);
                }
                lblSelectInstitution.Visible = false;
                comboBox_Institutions.Visible = false;
            }
            // Eğer kullanıcının rolü öğretmense sadece kendi kurslarını getir.
            else
            {
                ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
                courses = courseService.Find(x => x.TeacherId == user.Id && x.IsActive == true);
                foreach (var course in courses)
                {
                    comboBox_Courses.Items.Add(course.Title);
                }
                lblSelectInstitution.Visible = false;
                comboBox_Institutions.Visible = false;
            }
        }

        private void comboBox_Institutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Courses.Text = "";
            var selectedItem = comboBox_Institutions.SelectedItem;
            if (selectedItem != null)
            {

                ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
                if (selectedItem.ToString() == "Tüm Kurumlar")
                {
                    comboBox_Courses.Items.Clear();
                    comboBox_Courses.Items.Add("Tüm Kurslar");
                    courses = courseService.Find(x => x.IsActive == true);
                    foreach (var course in courses)
                        comboBox_Courses.Items.Add(course.Title);
                }
                else
                {
                    comboBox_Courses.Items.Clear();
                    comboBox_Courses.Items.Add("Tüm Kurslar");
                    int institutionId = institutions.FirstOrDefault(i => i.Name == selectedItem.ToString())?.Id ?? -1;
                    courses = courseService.GetClassesByInstitutionId(institutionId);
                    foreach (var course in courses)
                        comboBox_Courses.Items.Add(course.Title);
                }
            }
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

    }
}
