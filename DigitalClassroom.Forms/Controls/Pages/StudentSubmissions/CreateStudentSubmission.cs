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
using DigitalClassroom.BusinessLayer.Validations.StudentSubmissions;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.DataAccessLayer.Contexts;

namespace DigitalClassroom.Forms.Controls.Pages.StudentSubmissions
{
    public partial class CreateStudentSubmission : DevExpress.XtraEditors.XtraUserControl
    {
        private int studentId;
        private Assignment assignment;
        public CreateStudentSubmission(int studentId, Assignment assignment)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.assignment = assignment;
        }

        private void CreateStudentSubmission_Load(object sender, EventArgs e)
        {
            lblAssignmentTitle.Text = $"Seçilen ödev: {assignment.Title}";
        }

        private void btnCreateStudentSubmission_Click(object sender, EventArgs e)
        {
            try
            {
                IStudentSubmissionService studentSubmissionService = new StudentSubmissionManager(new StudentSubmissionRepository(new AppDbContext()));
                StudentSubmission studentSubmission = new StudentSubmission
                {
                    StudentId = studentId,
                    AssignmentId = assignment.Id,
                    Content = richtxtContent.Text,
                    SubmittedAt = DateTime.Now,
                    Status = StudentSubmission.SubmissionStatus.Tamamlandı.ToString(),
                };
                if (ValidateStudentSubmission(studentSubmission))
                {
                    studentSubmissionService.Add(studentSubmission);
                    XtraMessageBox.Show("Ödev başarıyla teslim edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Ödev teslim edilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private bool ValidateStudentSubmission(StudentSubmission studentSubmission)
        {
            var validator = new CreateSubmissionValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate(studentSubmission);
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
