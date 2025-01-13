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
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.Forms.Controls.Pages.Courses;
using DigitalClassroom.Forms.Controls.Pages.StudentSubmissions;
using DevExpress.XtraRichEdit.Layout;
using DigitalClassroom.BusinessLayer.Validations.Assignments;

namespace DigitalClassroom.Forms.Controls.Pages.Assignments
{
    public partial class EditAssignment : DevExpress.XtraEditors.XtraUserControl
    {
        private User user;
        private Assignment assignment;
        private IAssignmentService assignmentService;
        private IStudentSubmissionService submissionService;

        public EditAssignment(User user, Assignment assignment)
        {
            InitializeComponent();
            this.user = user;
            this.assignment = assignment;
            assignmentService = new AssignmentManager(new AssignmentRepository(new AppDbContext()));
            submissionService = new StudentSubmissionManager(new StudentSubmissionRepository(new AppDbContext()));
        }



        private void EditAssignment_Load(object sender, EventArgs e)
        {
            ViewAssignmentDetailByRole();
        }

        private void ViewAssignmentDetailByRole()
        {
            // Ödev bilgilerini form üzerinde göster
            txtAssignmentTitle.Text = assignment.Title;
            txtDescription.Text = assignment.Description;
            txtMaxScore.Text = assignment.MaxScore.ToString();
            dateEditAssignment.Text = assignment.DueDate.ToString();
            CalculateRemainingTime();

            // Eğer kullanıcı öğrenci ise düzenleme yapamaz sadece ödev detaylarını görebilir.
            if (user.Role.RoleName == Role.RoleNames.Student.ToString())
            {
                // Öğrencinin ödevi teslim edip etmediğini kontrol eden metot
                IsAssignmentSubmitted();
                CheckDueDate();

                txtAssignmentTitle.Enabled = false;
                txtDescription.Enabled = false;
                txtMaxScore.Enabled = false;
                dateEditAssignment.Enabled = false;
                btnChangeIsActiveAssignment.Visible = false;
                btnEditAssignment.Visible = false;
            }
            else
            {
                int submissionsCount = submissionService.Find(x => x.AssignmentId == assignment.Id).Count();
                lblMessage.Text = $"Teslim edilen ödev sayısı: {submissionsCount}";
                btnCreateStudentSubmission.Visible = false;
            }


        }


        private void IsAssignmentSubmitted()
        {
            // Eğer öğrenci ödevi teslim ettiyse "Ödev Teslim et" butonu görünmeyecek
            var studentsubmission = submissionService.Find(x => x.StudentId == user.Id && x.AssignmentId == assignment.Id);
            if (studentsubmission.Count() > 0)
            {
                btnCreateStudentSubmission.Visible = false;
                lblMessage.Text = "Tebrikler, ödevinizi teslim ettiniz.";
                if (studentsubmission.FirstOrDefault().Status == StudentSubmission.SubmissionStatus.Notlandırıldı.ToString())
                {
                    lblMaxScore.Text = "Ödev Puanınız";
                    txtMaxScore.Text = studentsubmission.FirstOrDefault().Score.ToString();
                }
            }
            else
            {
                btnCreateStudentSubmission.Visible = true;
                lblMessage.Text = "Ödevinizi Teslim Ediniz!";
            }
        }
        private bool CheckDueDate()
        {
            if (DateTime.Now > assignment.DueDate)
            {
                lblMessage.Text = "Ödevinizin teslim tarihi geçmiştir!";
                return false;
            }
            else
                return true;
        }

        private void CalculateRemainingTime()
        {
            TimeSpan RemainingTime = assignment.DueDate - DateTime.Now;
            if (RemainingTime.TotalSeconds > 0)
                lblRemainingTime.Text += $"{RemainingTime.Days} gün, {RemainingTime.Hours} saat, {RemainingTime.Minutes} dakika.";
            else
                lblRemainingTime.Text = "Ödevin teslim tarihi geçmiştir.";
        }
        private void btnChangeIsActiveAssignment_Click(object sender, EventArgs e)
        {

            // Ödevi silmek istediğinize emin misiniz?
            DialogResult dialogResult = MessageBox.Show("Ödevi silmek istediğinize emin misiniz? \n Öğrenci ödev teslimleri de silinecektir!", "Uyarı", MessageBoxButtons.YesNo);

            // Eğer kullanıcı evet derse
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Ödev servisini oluştur
                    assignmentService.DeleteAssignmentAndStudentSubmissions(assignment.Id);
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Ödev silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                XtraMessageBox.Show("Ödev başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ödev silindikten sonra kurs detay sayfasına yönlendir
                this.Controls.Clear();
                this.Controls.Add(new CourseDetail(user, assignment.CourseId));
            }
        }

        private void btnCreateStudentSubmission_Click(object sender, EventArgs e)
        {
            CreateStudentSubmission createStudentSubmission = new CreateStudentSubmission(user.Id, assignment);
            this.Parent.Controls.Add(createStudentSubmission);
            this.Parent.Controls.Remove(this);
        }

        private void btnEditAssignment_Click(object sender, EventArgs e)
        {
            try
            {
                // Ödev servisini oluştur, form üzerindeki bilgileri kullanarak ödevi güncelle
                assignment.Title = txtAssignmentTitle.Text;
                assignment.Description = txtDescription.Text;
                assignment.MaxScore = double.Parse(txtMaxScore.Text);
                assignment.DueDate = dateEditAssignment.DateTime;
                if (ValidateAssignment(assignment))
                {
                    assignmentService.Update(assignment);
                    XtraMessageBox.Show("Ödev başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ödev güncellendikten sonra kurs detay sayfasına yönlendir
                    this.Controls.Clear();
                    this.Controls.Add(new CourseDetail(user, assignment.CourseId));
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Ödev güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool ValidateAssignment(Assignment assignment)
        {
            var validator = new CreateAssignmentValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate(assignment);
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