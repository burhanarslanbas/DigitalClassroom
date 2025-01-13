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
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.EntityLayer.Concrete;
using DevExpress.Utils.Extensions;
using System.Data.Entity;

namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    public partial class ViewStudents : DevExpress.XtraEditors.XtraUserControl
    {
        private Course course;
        private User Viewer;
        private IEnumerable<User> students;
        private List<Enrollment> enrollments;

        public ViewStudents(Course course, User viewer)
        {
            InitializeComponent();
            this.course = course;
            Viewer = viewer;
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            GetStudents();
        }
        private void GetStudents()
        {
            // Enrollments tablosunda ilgili kursun aktif öğrencilerini getirir.

            IEnrollmentService enrollmentService = new EnrollmentManager(new EnrollmentRepository(new AppDbContext()));
            IUserService userService = new UserManager(new UserRepository(new AppDbContext()));
            enrollments = enrollmentService.Find(x => x.CourseId == course.Id).ToList();
            students = enrollmentService.Find(x => x.CourseId == course.Id && x.IsActive == true).Join(userService.GetAll(), Enrollment => Enrollment.StudentId, User => User.Id, (Enrollment, User) => User).ToList();
            BindingList<dynamic> studentBindingList = new BindingList<dynamic>();
            if (students.Count() == 0)
            {
                lblStudentMessage.Text = "- Sınıfta kayıtlı öğrenci bulunmamaktadır!";
                lblStudentMessage.Visible = true;
                gridControlStudents.Visible = false;
                btnChangeIsActiveStatus.Visible = false;
            }
            else
            {
                foreach (var student in students.ToList())
                {
                    studentBindingList.Add(new
                    {
                        Enrollment_Id = enrollments.Where(x => x.StudentId == student.Id).FirstOrDefault().Id,
                        Student_Id = student.Id,
                        FullName = $"{student.Name} {student.Surname}",
                        Email = student.Email,
                        PhoneNumber = student.PhoneNumber,
                        IsActive = enrollments.Where(x => x.StudentId == student.Id).FirstOrDefault().IsActive,
                        EnrollmentDate = enrollments.Where(x => x.StudentId == student.Id).FirstOrDefault().EnrollmentDate,
                        DeactivatedDate = enrollments.Where(x => x.StudentId == student.Id).FirstOrDefault().DeactivetedDate,
                        DeactivatedReason = enrollments.Where(x => x.StudentId == student.Id).FirstOrDefault().DeactivetedReason
                    });
                }
                gridControlStudents.DataSource = studentBindingList;
                // Eğer kullanıcının rolü öğrenci ise IsActive sütununu gizler.
                if (Viewer.RoleId == (int)Role.RoleNames.Student)
                {
                    btnChangeIsActiveStatus.Visible = false;
                    gridViewStudents.Columns["Enrollment_Id"].Visible = false;
                    gridViewStudents.Columns["Student_Id"].Visible = false;
                    gridViewStudents.Columns["DeactivatedDate"].Visible = false;
                    gridViewStudents.Columns["DeactivatedReason"].Visible = false;
                }

            }
        }
        private void btnChangeIsActiveStatus_Click(object sender, EventArgs e)
        {
            // Seçilen öğrencinin Enrollments tablosundaki aktiflik durumunu ilgili kurs için değiştirir.
            if (gridViewStudents.GetSelectedRows().Length == 0)
            {
                XtraMessageBox.Show("Lütfen öğrenci seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Gerçekten silmek istediğinden emin misin?
                // Öğretmenden aktiflik durumu değiştirme nedeni DeactivetedReason string olarak alınır.
                DialogResult dialogResult = XtraMessageBox.Show("Öğrenciyi sınıftan çıkarmak istediğinizden emin misiniz?", "Öğrenci Sınıftan Çıkar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedStudentId = Convert.ToInt32(gridViewStudents.GetRowCellValue(gridViewStudents.GetSelectedRows()[0], "Student_Id"));
                    IEnrollmentService enrollmentService = new EnrollmentManager(new EnrollmentRepository(new AppDbContext()));
                    Enrollment enrollment = enrollmentService.Find(x => x.CourseId == course.Id && x.StudentId == selectedStudentId).FirstOrDefault();
                    if (enrollment.IsActive == true)
                    {
                        enrollment.IsActive = false;
                        enrollment.DeactivetedDate = DateTime.Now;
                        enrollment.DeactivetedReason = ReturnDeactivetedReason();
                    }

                    enrollmentService.Update(enrollment);
                    GetStudents();
                }
            }
        }

        private string ReturnDeactivetedReason()
        {
            switch (Viewer.Role.Id)
            {
                case (int)Role.RoleNames.Admin:
                    return "Admin tarafından sınıftan çıkarıldı.";
                case (int)Role.RoleNames.Manager:
                    return "Kurum yöneticisi sınıftan çıkarıldı.";
                case (int)Role.RoleNames.Teacher:
                    return "Öğretmen tarafından sınıftan çıkarıldı.";
                default:
                    return "Sınıftan çıkarıldı.";
            }
        }
    }
}
