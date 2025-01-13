using System;
using System.Collections;
using System.Collections.Generic;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.DataAccessLayer.Contexts;
using System.Linq;
using System.ComponentModel;

namespace DigitalClassroom.Forms.Controls.Pages.StudentSubmissions
{
    public partial class ViewStudentSubmissions : DevExpress.XtraEditors.XtraUserControl
    {
        private Assignment assignment;
        private User viewer;
        private IEnumerable<StudentSubmission> studentSubmissions;
        private IEnumerable<User> students;

        public ViewStudentSubmissions(Assignment assignment, User viewer)
        {
            InitializeComponent();
            this.assignment = assignment;
            this.viewer = viewer;
        }

        private void ViewStudentSubmissions_Load(object sender, EventArgs e)
        {
            GetStudentSubmissions();
        }

        private void GetStudentSubmissions()
        {
            IStudentSubmissionService studentSubmissionService = new StudentSubmissionManager(new StudentSubmissionRepository(new AppDbContext()));
            IUserService userService = new UserManager(new UserRepository(new AppDbContext()));

            studentSubmissions = studentSubmissionService.Find(x => x.AssignmentId == assignment.Id &&
            (x.Status == StudentSubmission.SubmissionStatus.Tamamlandı.ToString() || x.Status == StudentSubmission.SubmissionStatus.Notlandırıldı.ToString()));

            students = studentSubmissions.Join(userService.GetAll(), StudentSubmission => StudentSubmission.StudentId, User => User.Id, (StudentSubmission, User) => User).ToList();
            BindingList<dynamic> studentSubmissionsBindingList = new BindingList<dynamic>();
            if (studentSubmissions.Count() == 0)
            {
                lblSubmissionMessage.Text = "- Öğrenci tarafından tamamlanmış bir ödev bulunmamaktadır!";
                lblSubmissionMessage.Visible = true;
                gridControlStudentSubmissions.Visible = false;
            }
            else
            {
                foreach (var studentSubmission in studentSubmissions.ToList())
                {
                    studentSubmissionsBindingList.Add(new
                    {
                        Student_Submission_Id = studentSubmission.Id,
                        Student_Id = students.Where(x => x.Id == studentSubmission.StudentId).FirstOrDefault().Id,
                        Student_FullName = students.Where(x => x.Id == studentSubmission.StudentId).FirstOrDefault().Name + " " + students.Where(x => x.Id == studentSubmission.StudentId).FirstOrDefault().Surname,
                        Student_Email = students.Where(x => x.Id == studentSubmission.StudentId).FirstOrDefault().Email,
                        Student_Submission_Content = studentSubmission.Content,
                        Student_Submission_Score = studentSubmission.Score,
                        Student_Submission_SubmittedAt = studentSubmission.SubmittedAt,
                        Student_Submission_UpdatedAt = studentSubmission.UpdatedAt
                    });
                }
                gridControlStudentSubmissions.DataSource = studentSubmissionsBindingList;
                btnViewStudentSubmissionDetail.Visible = true;
            }
        }

        private void gridControlAssignments_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStudentSubmissionDetail_Click(object sender, EventArgs e)
        {
            // Seçilen öğrenci ödevinin Id'sini al
            int studentSubmissionId = Convert.ToInt32(gridViewStudentSubmissions.GetRowCellValue(gridViewStudentSubmissions.FocusedRowHandle, "Student_Submission_Id"));
            var studentSubmission = studentSubmissions.Where(x => x.Id == studentSubmissionId).FirstOrDefault();

            ViewStudentSubmissionDetail submissionDetail = new ViewStudentSubmissionDetail(studentSubmission, viewer);
            this.Parent.Controls.Add(submissionDetail);
            this.Parent.Controls.Remove(this);
        }
    }
}
