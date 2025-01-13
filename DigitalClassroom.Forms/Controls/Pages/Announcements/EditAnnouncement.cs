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
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.BusinessLayer.Validations.Announcements;

namespace DigitalClassroom.Forms.Controls.Pages.Announcements
{
    public partial class EditAnnouncement : DevExpress.XtraEditors.XtraUserControl
    {
        private IEnumerable<Institution> institutions;
        private IEnumerable<Course> courses;
        private User user;
        private Announcement announcement;
        public EditAnnouncement(User user, Announcement announcement)
        {
            InitializeComponent();
            this.user = user;
            this.announcement = announcement;
        }

        private void btnEditAnnouncement_Click(object sender, EventArgs e)
        {
            btnEditAnnouncement.Enabled = false;
            try
            {
                announcement.Title = txtTitle.Text;
                announcement.Message = txtMessage.Text;
                announcement.UpdatedAt = DateTime.Now;

                if (user.Role.RoleName == Role.RoleNames.Admin.ToString())
                {
                    if (comboBox_Institutions.Text != "Tüm Kurumlar")
                    {
                        int institutionId = institutions.FirstOrDefault(i => i.Name == comboBox_Institutions.Text)?.Id ?? -1;
                        announcement.InstitutionId = institutionId;
                    }
                    else
                    {
                        announcement.InstitutionId = null;
                    }
                }
                if (comboBox_Courses.Text != "Tüm Kurslar")
                {
                    int courseId = courses.FirstOrDefault(c => c.Title == comboBox_Courses.Text)?.Id ?? -1;
                    announcement.CourseId = courseId;
                }
                else
                {
                    announcement.CourseId = null;
                }
                if (ValidateAnnouncement(announcement))
                {
                    IAnnouncementService announcementService = new AnnouncementManager(new AnnouncementRepository(new AppDbContext()));
                    announcementService.Update(announcement);
                    XtraMessageBox.Show("Duyuru başarıyla düzenlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnHomePage(this.user);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Duyuru düzenlenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnEditAnnouncement.Enabled = true;

        }

        private void EditAnnouncement_Load(object sender, EventArgs e)
        {
            LoadAnnouncementDataByRole();
        }

        private void LoadAnnouncementDataByRole()
        {
            txtTitle.Text = announcement.Title;

            // Eğer kullanıcının rolü Admin ise tüm kurumları getir.
            // Adminin seçtiği kuruma göre sınıflar gösterilecektir.
            if (user.Role.RoleName == Role.RoleNames.Admin.ToString())
            {
                IInstitutionService institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
                institutions = institutionService.GetAll();
                foreach (var institution in institutions)
                {
                    comboBox_Institutions.Items.Add(institution.Name);
                    comboBox_Institutions.ValueMember = "Id";
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
                    comboBox_Courses.ValueMember = "Id";
                }
                lblSelectInstitution.Visible = false;
                comboBox_Institutions.Visible = false;

                if (announcement.CourseId != null)
                    comboBox_Courses.SelectedIndex = comboBox_Courses.FindString(courses.FirstOrDefault(x => x.Id == announcement.CourseId).Title);
                else
                    comboBox_Courses.Text = "Tüm Kurslar";

            }
            // Eğer kullanıcının rolü öğretmense sadece kendi kurslarını getir.
            else
            {
                ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
                courses = courseService.Find(x => x.TeacherId == user.Id && x.IsActive == true);
                if (courses.Count() > 0)
                {
                    foreach (var course in courses)
                    {
                        comboBox_Courses.Items.Add(course.Title);
                        comboBox_Courses.ValueMember = "Id";
                    }
                }
                else
                {
                    comboBox_Courses.Visible = false;
                    lblSelectCourse.Visible = false;
                }

                lblSelectInstitution.Visible = false;
                comboBox_Institutions.Visible = false;

                if (announcement.CourseId != null)
                    comboBox_Courses.SelectedIndex = comboBox_Courses.FindString(courses.FirstOrDefault(x => x.Id == announcement.CourseId).Title);
                else
                    comboBox_Courses.Text = "Tüm Kurslar";
            }
            GetComboBoxTextsByAnnouncement();
        }

        private void GetComboBoxTextsByAnnouncement()
        {
            if (user.RoleId == (int)Role.RoleNames.Admin)
            {
                if (announcement.InstitutionId == null)
                {
                    comboBox_Institutions.SelectedIndex = 0;
                }
                else
                {
                    comboBox_Institutions.Text = institutions.FirstOrDefault(x => x.Id == announcement.InstitutionId).Name;
                }
            }
            if (announcement.CourseId == null)
            {
                comboBox_Courses.SelectedIndex = 0;
            }
            else
            {
                comboBox_Courses.Text = courses.FirstOrDefault(x => x.Id == announcement.CourseId).Title;
            }
            txtMessage.Text = announcement.Message;
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
                    courses = courseService.GetAll();
                    foreach (var course in courses)
                    {
                        comboBox_Courses.Items.Add(course.Title);
                        comboBox_Courses.ValueMember = "Id";
                    }

                }
                else
                {
                    comboBox_Courses.Items.Clear();
                    comboBox_Courses.Items.Add("Tüm Kurslar");
                    int institutionId = institutions.FirstOrDefault(i => i.Name == selectedItem.ToString())?.Id ?? -1;
                    courses = courseService.GetClassesByInstitutionId(institutionId);
                    foreach (var course in courses)
                    {
                        comboBox_Courses.Items.Add(course.Title);
                        comboBox_Courses.ValueMember = "Id";
                    }
                }
            }
        }
        private void btnDeleteAnnouncement_Click(object sender, EventArgs e)
        {
            try
            {
                // Duyuru silme işlemi
                // Duyurunun silinme durumunu true yapıyoruz, bu sayede silinen duyuruları da elimizde tutabiliriz.
                announcement.IsDeleted = true;
                announcement.DeletedAt = DateTime.Now;
                IAnnouncementService announcementService = new AnnouncementManager(new AnnouncementRepository(new AppDbContext()));
                announcementService.Update(announcement);
                XtraMessageBox.Show("Duyuru başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnHomePage(this.user);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Duyuru silinirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
