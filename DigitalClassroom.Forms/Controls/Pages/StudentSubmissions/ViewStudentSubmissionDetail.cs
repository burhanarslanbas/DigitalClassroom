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
using DevExpress.XtraReports.Serialization;

namespace DigitalClassroom.Forms.Controls.Pages.StudentSubmissions
{
    public partial class ViewStudentSubmissionDetail : DevExpress.XtraEditors.XtraUserControl
    {
        private StudentSubmission submission;
        private User viewer;
        private IUserService userService;
        private IStudentSubmissionService submissionService;
        private string assignmentState;

        public ViewStudentSubmissionDetail(StudentSubmission studentSubmission, User viewer)
        {
            InitializeComponent();
            submission = studentSubmission;
            this.viewer = viewer;
            userService = new UserManager(new UserRepository(new AppDbContext()));
            submissionService = new StudentSubmissionManager(new StudentSubmissionRepository(new AppDbContext()));
        }

        private void ViewStudentSubmissionDetail_Load(object sender, EventArgs e)
        {
            SetVisibilityOptionsByRole(viewer.Role);
        }

        private void SetVisibilityOptionsByRole(Role role)
        {
            switch (role.Id)
            {
                case (int)Role.RoleNames.Student:
                    btnGradeStudentSubmission.Visible = false;
                    // btnUpdateStudentSubmission.Visible = true;
                    txtScore.Enabled = false;
                    break;
                default:
                    txtScore.Enabled = true;
                    btnGradeStudentSubmission.Visible = true;
                    // btnUpdateStudentSubmission.Visible = false;

                    User student = userService.GetById(submission.StudentId);
                    txtStudentId.Text = student.Id.ToString();
                    txtStudentFullName.Text = student.Name + " " + student.Surname;
                    txtScore.Text = submission.Score.ToString();
                    richtxtContent.Text = submission.Content;
                    CheckAssignmentState();
                    break;
            }
        }
        private void CheckAssignmentState()
        {
            assignmentState = submission.Status;
            if (assignmentState == "Tamamlandı")
                lblAssignmentState.Text += "Notlandırma Bekleniyor!";
            else
                lblAssignmentState.Text += "Ödev Notlandırıldı!";
        }

        private void btnGradeStudentSubmission_Click(object sender, EventArgs e)
        {
            try
            {
                int score = int.TryParse(txtScore.Text, out score) ? score : 0;
                int maxScore = ReturnMaxScore();
                if (score > maxScore)
                {
                    XtraMessageBox.Show($"Öğrenci notu, ödevin maksimum puanından büyük olamaz! Maksimum puan: {maxScore}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    submission.Score = score;
                    submission.Status = StudentSubmission.SubmissionStatus.Notlandırıldı.ToString();
                    submission.UpdatedAt = DateTime.Now;

                    submissionService.Update(submission);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Öğrenci ödevi notlandırılırken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            XtraMessageBox.Show("Öğrenci ödevi başarıyla notlandırıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ReturnMaxScore()
        {
            IAssignmentService assignmentService = new AssignmentManager(new AssignmentRepository(new AppDbContext()));
            Assignment assignment = assignmentService.GetById(submission.AssignmentId);
            return (int)assignment.MaxScore;
        }
        private void btnUpdateStudentSubmission_Click_1(object sender, EventArgs e)
        {

        }
    }
}
