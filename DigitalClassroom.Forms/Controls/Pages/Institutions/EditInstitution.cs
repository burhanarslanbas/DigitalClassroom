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
using System.Xml.Linq;
using DevExpress.XtraGrid;
using DigitalClassroom.BusinessLayer.Validations.Institutions;

namespace DigitalClassroom.Forms.Controls.Pages.Institutions
{
    public partial class EditInstitution : DevExpress.XtraEditors.XtraUserControl
    {
        private Institution institution;
        private List<User> managers;
        private IInstitutionService institutionService;
        private IUserService userService;

        public EditInstitution(Institution institution)
        {
            InitializeComponent();
            this.institution = institution;
            institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
        }

        private void EditInstitution_Load(object sender, EventArgs e)
        {
            // Veritabanında rolü Manager olan ve InstitutionId'si boş olan kullanıcıları getir.
            userService = new UserManager(new UserRepository(new AppDbContext()));
            managers = userService.Find(x => x.RoleId == (int)Role.RoleNames.Manager && x.InstitutionId == null).ToList();
            // UserService'i kullanarak veritabanından ManagerID'si institution.ManagerId olan kullanıcıyı getir ve managers'a ekle
            managers.Add(userService.GetById(institution.ManagerId));

            if (managers.Count() > 0)
            {
                foreach (var manager in managers)
                {
                    comboBox_InstitutionManager.Items.Add(manager.Name + " " + manager.Surname);
                    comboBox_InstitutionManager.ValueMember = manager.Id.ToString();
                }
            }
            else
            {
                comboBox_InstitutionManager.Text = "Kurumu olmayan bir Müdür bulunamadı! Lütfen önce kullanıcıyı ekleyiniz!";
                comboBox_InstitutionManager.Enabled = false;
            }

            // Kurumun aktif olup olmadığına göre işlem yapan bir metot 
            IsInstitutionActive();
            // Kurum bilgilerini dolduran metot
            FillInstitutionInfo();
        }

        private void FillInstitutionInfo()
        {
            txtInstitutionName.Text = institution.Name;
            txtContactNumber.Text = institution.ContactNumber;
            txtEmail.Text = institution.Email;
            txtAddress.Text = institution.Address;
            txtCreatedAt.Text = institution.CreatedAt.ToString();

            if (institution.DeactivetedReason == null)
            {
                txtDeactivatedDate.Text = "Kurum hiç pasif edilmemiş!";
                txtDeactivatedReason.Text = "Bu alana tıklayıp pasif etme nedeninizi yazın ve ardından \"Pasif Hale Getir\" butonuna basarak kurumu pasif hale getirebilirsiniz.";
            }
            else
            {
                txtDeactivatedDate.Text = institution.DeactivetedDate.ToString();
                txtDeactivatedReason.Text = institution.DeactivetedReason;
            }


            // Kurum müdürünü ManagerId'ye göre combobox'ta gösteren metot
            comboBox_InstitutionManager.SelectedIndex = comboBox_InstitutionManager.FindStringExact(managers.Find(x => x.Id == institution.ManagerId).Name + " " + managers.Find(x => x.Id == institution.ManagerId).Surname);
            if (institution.IsActive == false)
            {
                txtDeactivatedDate.Text = institution.DeactivetedDate.ToString();
                txtDeactivatedReason.Text = institution.DeactivetedReason;
            }
        }

        private void IsInstitutionActive()
        {
            if (institution.IsActive)
            {
                txtIsActive.Text = "AKTİF";
                txtIsActive.ForeColor = Color.Green;
            }
            else
            {
                txtIsActive.Text = "PASİF";
                txtIsActive.ForeColor = Color.Red;
                btnChangeIsActive.Text = "Aktif Et";
            }
        }

        private void btnChangeIsActive_Click_1(object sender, EventArgs e)
        {
            btnChangeIsActive.Enabled = true;
            try
            {
                if (institution.IsActive == true)
                    DeactivateInstitution();

                else
                    ActivateInstitution();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kurumun aktiflik durumu değiştirilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            btnChangeIsActive.Enabled = true;

            RefreshContent(institution);
        }
        public void RefreshContent(Institution institution)
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = new EditInstitution(institution);
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = false;
            try
            {
                IsChangedInstitutionManager();
                institution.Name = txtInstitutionName.Text;
                institution.ContactNumber = txtContactNumber.Text;
                institution.Email = txtEmail.Text;
                institution.Address = txtAddress.Text;
                institution.UpdatedAt = DateTime.Now;
                institution.ManagerId = Convert.ToInt32(comboBox_InstitutionManager.DisplayMember);
                if (ValidateInstitution(institution))
                {
                    institutionService.Update(institution);
                    institution = institutionService.GetById(institution.Id);
                    XtraMessageBox.Show("Kurum başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshContent(institution);
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kurum güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSaveChanges.Enabled = true;
        }

        private void IsChangedInstitutionManager()
        {
            // Seçilen müdürün userId değerini al
            int selectedManagerId = Convert.ToInt32(comboBox_InstitutionManager.DisplayMember);
            // Eğer kurum müdürü değiştiyse bu metot çalışır
            if (institution.ManagerId != selectedManagerId)
            {
                int managerId = selectedManagerId;
                institutionService.UpdateManagerId(institution.Id, managerId);
            }
        }

        private void txtDeactivatedReason_Click(object sender, EventArgs e)
        {
            txtDeactivatedReason.Text = "";
        }

        private void DeactivateInstitution()
        {
            // Kurumu pasif hale getirmek istediğinize emin misiniz?
            DialogResult dialogResult = MessageBox.Show("Kurumu pasif hale getirmek istediğinize emin misiniz?\nKuruma bağlı tüm kullanıcılar pasif hale gelecektir!", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string deactivatedReason = txtDeactivatedReason.Text;
                institutionService.DeactivateInstitutionAndUsers(institution.Id, deactivatedReason);
                institution =  institutionService.GetById(institution.Id);
                XtraMessageBox.Show("Kurum ve kullanıcıları başarıyla pasif hale getirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActivateInstitution()
        {
            institutionService.ActivateInstitutionAndUsers(institution.Id);
            institution = institutionService.GetById(institution.Id);
            XtraMessageBox.Show("Kurum ve kullanıcıları başarıyla aktif hale getirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
