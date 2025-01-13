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
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.Forms.MainForms;
using DigitalClassroom.Forms.Controls.Pages.Institutions;

namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    public partial class JoinCourse : DevExpress.XtraEditors.XtraUserControl
    {
        private User student;

        public bool IsEnrolled { get; internal set; }

        public JoinCourse(User student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void JoinCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnJoinCourse_Click(object sender, EventArgs e)
        {
            try
            {
                ICourseService courseService = new CourseManager(new CourseRepository(new AppDbContext()));
                var selectedCourse = courseService.Find(x => x.AttendanceCode == txtAttendanceCode.Text).ToList().FirstOrDefault();
                // Eğer seçilen kurs null ise hata mesajı ver
                if (selectedCourse == null)
                {
                    XtraMessageBox.Show(LookAndFeel, "Kurs bulunamadı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Eğer seçilen kurstaki öğrenci sayısı kurs kapasitesinden fazla ise hata mesajı ver
                    if (selectedCourse.CourseCapacity <= selectedCourse.Enrollments.Count)
                    {
                        XtraMessageBox.Show(LookAndFeel, "Kurs kapasitesi dolmuştur. Başka bir kurs seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Eğer zaten kullanıcı bu kursa kayıtlıysa hata mesajı ver
                    else if (selectedCourse.Enrollments.Any(x => x.StudentId == student.Id))
                    {
                        XtraMessageBox.Show(LookAndFeel, "Bu kursa zaten kayıtlısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ParentForm.Close();
                        RefreshContent(student);
                    }
                    // Eğer öğrenci kursa kayıtlı değilse ve kurs kapasitesi dolmamışsa öğrenciyi kursa kaydet
                    else
                    {
                        IEnrollmentService enrollmentService = new EnrollmentManager(new EnrollmentRepository(new AppDbContext()));
                        Enrollment enrollment = new Enrollment
                        {
                            StudentId = student.Id,
                            CourseId = selectedCourse.Id,
                            EnrollmentWay = "Attendance Code",
                            IsActive = true,
                            EnrollmentDate = DateTime.Now,
                        };
                        enrollmentService.Add(enrollment);
                        XtraMessageBox.Show(LookAndFeel, "Kursa başarıyla kayıt oldunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ParentForm.Close();
                        RefreshContent(student);
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show(LookAndFeel, "Kursa kayıt olunurken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void RefreshContent(User user)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
