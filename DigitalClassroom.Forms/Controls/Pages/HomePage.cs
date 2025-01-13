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
using DigitalClassroom.EntityLayer.Concrete;
using System.Data.Entity;
using DevExpress.Utils.Extensions;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.Forms.Controls.Pages.Announcements;
using DigitalClassroom.Forms.MainForms;
using DigitalClassroom.Forms.Controls.Pages.Courses;
using DigitalClassroom.Forms.Controls.Pages.Institutions;

namespace DigitalClassroom.Forms.Controls.Pages.HomePage
{
    public partial class HomePage : DevExpress.XtraEditors.XtraUserControl
    {
        private User user;
        public HomePage(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            int userId = user.Id;
            var userInstitutionId = user.InstitutionId;
            string userRole = user.Role.RoleName;

            string greetingMessage = $"Merhaba {user.Name}, Dijital Sınıfa Hoşgeldin!";
            lblGreetingMessage.Text = greetingMessage;

            // Kullanıcı bilgilerine göre ilgili duyuruları grid üzerinde gösteren metot
            ViewAnnouncements(userId, userInstitutionId, userRole);
            ViewCourses(userId, userInstitutionId, userRole);
        }

        private void ViewCourses(int userId, int? userInstitutionId, string userRole)
        {
            AppDbContext dbContext = new AppDbContext();
            // Kursları filtrelemek için sorgu
            var coursesQuery = dbContext.Courses.AsQueryable();
            // Admin: Tüm kursları görebilir
            if (userRole == "Admin")
            {
                coursesQuery = coursesQuery.Where(c => c.IsActive == true);
            }

            // Manager: Kendi kurumundaki kursları gösterilir
            else if (userRole == "Manager")
            {
                coursesQuery = coursesQuery
                    .Where(c => c.InstitutionId == userInstitutionId && c.IsActive == true);
            }

            // Öğretmen: Kendisine ait kursları görebilir
            else if (userRole == "Teacher")
            {
                coursesQuery = coursesQuery
                    .Where(c => c.TeacherId == userId && c.IsActive == true);
            }
            // Öğrenci: Kayıtlı olduğu kursları görüntüleyebilir
            else
            {
                coursesQuery = coursesQuery
                    .Where(c => c.Enrollments.Any(e => e.StudentId == userId && e.IsActive == true));
            }
            // Sonuçları listeye dönüştür
            var courses = coursesQuery.ToList();

            // Eğer kurs sayısı 0 ise, kullanıcıya bilgi ver
            if (courses.Count == 0)
            {
                lblCourseMessage.Visible = true;
                lblCourseMessage.Text = "İlişkili olduğunuz bir kurs bulunmamaktadır!";
                btnViewCourse.Visible = false;
                gridControlCourses.Visible = false;
            }
            else
            {
                gridControlCourses.DataSource = courses;
            }
        }

        private void ViewAnnouncements(int userId, int? userInstitutionId, string userRole)
        {
            AppDbContext dbContext = new AppDbContext();
            // Duyuruları filtrelemek için sorgu
            var announcementsQuery = dbContext.Announcements.AsQueryable();

            // Admin: Tüm duyuruları görebilir
            if (userRole == "Admin")
            {
                announcementsQuery = announcementsQuery.Where(a => a.IsDeleted == false);
            }

            // Manager: Kendi kurumundaki veya InstitutionId'si boş olan duyurular gösterilir
            else if (userRole == "Manager")
            {
                announcementsQuery = announcementsQuery
                    .Where(a => a.IsDeleted == false && (a.InstitutionId == userInstitutionId || a.InstitutionId == null && a.IsDeleted == false));
            }

            // Öğretmen: 
            // 1. Kendi kurumundaki duyuruları
            // 2. Admin (InstitutionId'si boş) duyuruları
            // 3. Kendi sınıflarına ait duyuruları görebilir
            else if (userRole == "Teacher")
            {
                var teacherCourseIds = dbContext.Courses
                    .Where(c => c.TeacherId == userId && c.IsActive == true)
                    .Select(c => c.Id)
                    .ToList();

                announcementsQuery = announcementsQuery.Where(a => a.IsDeleted == false &&
                (((a.InstitutionId == user.InstitutionId || a.InstitutionId == null) && teacherCourseIds.Contains(a.CourseId.Value)) ||
                (a.CourseId == null && (a.InstitutionId == user.InstitutionId || a.InstitutionId == null))));
            }
            else
            {
                var studentCourseIds = dbContext.Enrollments
                    .Where(e => e.StudentId == userId && e.IsActive == true)
                    .Select(e => e.CourseId)
                    .ToList();

                announcementsQuery = announcementsQuery.Where(a => a.IsDeleted == false &&
                (((a.InstitutionId == user.InstitutionId || a.InstitutionId == null) && studentCourseIds.Contains(a.CourseId.Value)) ||
                (a.CourseId == null && (a.InstitutionId == user.InstitutionId || a.InstitutionId == null))));
            }

                // Sonuçları listeye dönüştür
                var announcements = announcementsQuery.ToList();
            gridControlAnnouncements.DataSource = announcements;

            gridAnnouncements.CustomColumnDisplayText += gridAnnouncements_CustomColumnDisplayText;
        }

        private void gridAnnouncements_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            // Hedef kolonun FieldName'i
            if (e.Column.FieldName == "Course.Title" && string.IsNullOrEmpty(e.DisplayText))
            {
                e.DisplayText = "Tüm Kurslar";
            }

            if (e.Column.FieldName == "Institution.Name" && string.IsNullOrEmpty(e.DisplayText))
            {
                e.DisplayText = "Tüm Kurumlar";
            }
        }

        private void btnViewAnnouncement_Click(object sender, EventArgs e)
        {
            // Grid üzerinde seçili olan duyurunun Id'sini al
            int announcementId = Convert.ToInt32(gridAnnouncements.GetRowCellValue(gridAnnouncements.FocusedRowHandle, "Id"));

            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new AnnouncementDetail(user, announcementId);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            // Card üzerinde seçili olan kursun Id'sini al
            int courseId = Convert.ToInt32(cardCourses.GetRowCellValue(cardCourses.FocusedRowHandle, "Id"));

            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new CourseDetail(user, courseId);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void cardCourses_CustomDrawCardCaption(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventArgs e)
        {
            // Kurs kartının başlığına ilgili kursun adını yaz
            var view = sender as DevExpress.XtraGrid.Views.Card.CardView;
            e.CardCaption = view.GetRowCellValue(e.RowHandle, "Title").ToString();
        }

        private void gridControlAnnouncements_Click(object sender, EventArgs e)
        {

        }
    }
}
