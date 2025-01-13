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
using System.Data.Entity;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.Forms.Controls.Pages.Announcements;
using DigitalClassroom.Forms.Controls.Pages.Assignments;
using DigitalClassroom.Forms.Controls.Pages.StudentSubmissions;
using System.Security.Cryptography;

namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    public partial class CourseDetail : DevExpress.XtraEditors.XtraUserControl
    {
        private User user;
        private int courseId;
        private Course selectedCourse;
        private string institutionName;
        private IEnumerable<Assignment> assignments;

        public CourseDetail(User user, int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
            this.user = user;
        }

        private void CourseDetail_Load(object sender, EventArgs e)
        {
            //IAnnouncementService announcementService = new AnnouncementManager(new AnnouncementRepository(new AppDbContext()));
            //gridControlAnnouncements.DataSource = announcementService.Find(x => x.CourseId == courseId).ToList();

            ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
            selectedCourse = courseService.GetById(courseId);
            if (selectedCourse.Announcements.Count() > 0)
            {
                gridControlAnnouncements.DataSource = selectedCourse.Announcements.ToList();
            }
            else
            {
                lblAnnouncementMessage.Text = "Kursa tanımlı duyuru bulunmamaktadır!";
                lblAnnouncementMessage.Visible = true;
                btnViewAnnouncementDetail.Visible = false;
            }

            lblCourseTitle.Text = selectedCourse.Title;
            if (selectedCourse.InstitutionId != null)
            {
                institutionName = selectedCourse.Institution.Name;
            }
            else
            {
                institutionName = "Bireysel";
            }
            lblInstitutionAndTeacher.Text = $"Kurum: {institutionName} - Eğitmen: {selectedCourse.Teacher.Name} {selectedCourse.Teacher.Surname}";

            // Kullanıcının rolüne göre butonları görüntüle
            ViewAssignmentButtonsByUserRole();

            IAssignmentService assignmentService = new AssignmentManager(new AssignmentRepository(new AppDbContext()));
            assignments = assignmentService.Find(x => x.CourseId == courseId).ToList();
            // Eğer kursa tanımlı herahn bir ödev yoksa
            if (assignments.Count() == 0)
            {
                lblAssignmentMessage.Visible = true;
                lblAssignmentMessage.Text = "Kursa tanımlı ödev bulunmamaktadır!";
                btnViewAssignmentDetail.Visible = false;
                gridControlAssignments.Visible = false;
                btnViewStudentSubmissions.Visible = false;
            }
            else
            {
                gridControlAssignments.DataSource = assignments;
            }
        }

        private void ViewAssignmentButtonsByUserRole()
        {
            if (user.Role.RoleName == Role.RoleNames.Student.ToString())
            {
                btnCreateAssignment.Visible = false;
                btnViewStudentSubmissions.Visible = false;
                btnEditCourse.Visible = false;
            }
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
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

        private void btnCreateAssignment_Click(object sender, EventArgs e)
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new CreateAssignment(user,courseId);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay

        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new ViewStudents(selectedCourse, user);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void btnViewStudentSubmissions_Click(object sender, EventArgs e)
        {
            // Seçili olan ödevin Id'sini al
            int assignmentId = Convert.ToInt32(gridViewAssignments.GetRowCellValue(gridViewAssignments.FocusedRowHandle, "Id"));
            Assignment assignment = assignments.Where(x => x.Id == assignmentId).FirstOrDefault();

            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new ViewStudentSubmissions(assignment, user);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void btnViewAssignmentDetail_Click(object sender, EventArgs e)
        {
            // Seçili olan ödevin Id'sini al
            int assignmentId = Convert.ToInt32(gridViewAssignments.GetRowCellValue(gridViewAssignments.FocusedRowHandle, "Id"));
            Assignment assignment = assignments.Where(x => x.Id == assignmentId).FirstOrDefault();

            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new EditAssignment(user, assignment);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new EditCourse(selectedCourse,user);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }
    }
}
