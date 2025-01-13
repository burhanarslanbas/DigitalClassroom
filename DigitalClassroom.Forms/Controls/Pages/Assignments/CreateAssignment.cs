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
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DevExpress.XtraRichEdit.Layout;
using DigitalClassroom.BusinessLayer.Validations.Assignments;
using DigitalClassroom.BusinessLayer.Validations.Institutions;

namespace DigitalClassroom.Forms.Controls.Pages.Assignments
{
    public partial class CreateAssignment : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly User user;
        private readonly int courseId;

        public CreateAssignment(User user, int courseId)
        {
            InitializeComponent();
            this.user = user;
            this.courseId = courseId;
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            btnCreateAssignment.Enabled = false;
            try
            {
                Assignment assignment = new Assignment()
                {
                    CourseId = courseId,
                    CreatorId = user.Id,
                    Title = txtAssignmentTitle.Text,
                    Description = txtDescription.Text,
                    DueDate = dateEditAssignment.DateTime,
                    MaxScore = 100,
                    CreatedDate = DateTime.Now
                };

                // Eğer txtMaxScore boş değilse ve double'a çevrilebiliyorsa MaxScore'a ata
                if (!string.IsNullOrEmpty(txtMaxScore.Text) && double.TryParse(txtMaxScore.Text, out double maxScore))
                {
                    assignment.MaxScore = maxScore;
                }

                if (ValidateAssignment(assignment))
                {
                    IAssignmentService assignmentService = new AssignmentManager(new AssignmentRepository(new AppDbContext()));
                    assignmentService.Add(assignment);
                    XtraMessageBox.Show("Ödev başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Ödev oluşturulurken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            btnCreateAssignment.Enabled = true;
        }

        private void CreateAssignment_Load(object sender, EventArgs e)
        {

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
