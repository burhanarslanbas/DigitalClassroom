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
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.BusinessLayer.Validations.Courses;
using DigitalClassroom.Forms.Controls.Pages.Courses;
using DigitalClassroom.BusinessLayer.Validations.Institutions;

namespace DigitalClassroom.Forms.Controls.Pages.Institutions
{
    public partial class AddInstitution : DevExpress.XtraEditors.XtraUserControl
    {
        User user;
        IEnumerable<User> managers;
        public AddInstitution(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void AddInstitution_Load(object sender, EventArgs e)
        {
            // Veritabanında rolü Manager olan ve InstitutionId'si boş olan kullanıcıları getir.
            IUserService userService = new UserManager(new UserRepository(new AppDbContext()));
            managers = userService.Find(x => x.RoleId == (int)Role.RoleNames.Manager && x.InstitutionId == null);
            if (managers.Count() > 0)
            {
                managers.ToList().ForEach(m => comboBox_InstitutionManager.Items.Add(m.Name + " " + m.Surname));
                managers.ToList().ForEach(m => comboBox_InstitutionManager.ValueMember = m.Id.ToString());
            }
            else
            {
                comboBox_InstitutionManager.Text = "Kurumu olmayan bir Müdür bulunamadı! Lütfen önce kullanıcıyı ekleyiniz!";
                comboBox_InstitutionManager.Enabled = false;
            }
        }
        private bool ValidateInstitution(Institution institution)
        {
            var validator = new CreateInstitutionValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate(institution);
            if (!result.IsValid)
            {
                // Tüm hataları tek bir mesajda ilet
                string errorMessage = result.Errors.Select(x => x.ErrorMessage).Aggregate((i, j) => i + "\n" + j);
                XtraMessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ViewInstitutions()
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new ViewInstitutions();
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void btnCreateInstitution_Click_1(object sender, EventArgs e)
        {
            btnCreateInstitution.Enabled = false;
            try
            {
                Institution institution = new Institution()
                {
                    ManagerId = managers.ElementAt(comboBox_InstitutionManager.SelectedIndex).Id,
                    CreatorId = user.Id,
                    Name = txtInstitutionName.Text,
                    Address = txtAddress.Text,
                    ContactNumber = txtContactNumber.Text,
                    Email = txtEmail.Text,
                    IsActive = true,
                    CreatedAt = DateTime.Now
                };

                if (ValidateInstitution(institution))
                {
                    IInstitutionService institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
                    institutionService.Add(institution);
                    IUserService userService = new UserManager(new UserRepository(new AppDbContext()));

                    // Institutions Tablosundan son eklenen kurumun Id'sini al
                    int institutionId = institutionService.GetAll().Last().Id;
                    int managerId = managers.ElementAt(comboBox_InstitutionManager.SelectedIndex).Id;

                    // User tablosundaki Id'si managerId'ye eşit olan kullanıcıyı getir
                    User manager = userService.GetById(managerId);
                    // Manager'ın InstitutionId'sine yeni eklenen kurumun Id'sini ata
                    manager.InstitutionId = institutionId;
                    // Manager'ı güncelle
                    userService.Update(manager);
                    XtraMessageBox.Show("Kurum başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewInstitutions();
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kurum ekleme işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCreateInstitution.Enabled = true;
        }
    }
}
