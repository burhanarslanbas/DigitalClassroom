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
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.Forms.Controls.Pages.Institutions;
using DigitalClassroom.BusinessLayer.Validations.Users;

namespace DigitalClassroom.Forms.Controls.Pages.Users
{
    public partial class EditUser : DevExpress.XtraEditors.XtraUserControl
    {
        // Fields (Alanlar)
        private User user;
        private User authUser;
        private IUserService userService;
        private IInstitutionService institutionService;
        private IEnumerable<Institution> institutions;

        public EditUser(User authUser)
        {
            InitializeComponent();
            userService = new UserManager(new UserRepository(new AppDbContext()));
            user = authUser;
        }

        public EditUser(int userId, User authUser)
        {
            InitializeComponent();
            userService = new UserManager(new UserRepository(new AppDbContext()));
            this.authUser = authUser;
            user = GetUserInfo(userId);
            if (user.Id == authUser.Id)
                this.authUser = null;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            IsUserActive();
            if (IsUserEqualsAuthUser())
                EditItemsVisibility(user.Role);
            else
                EditItemsVisibility(authUser.Role);
            ViewUserInfo();
        }

        private bool IsUserEqualsAuthUser()
        {
            // Eğer kullanıcı kendi bilgilerini düzenleyecek ise
            if (authUser == null)
                return true;
            else
                return false;
        }

        private void btnSaveChanges_Click_1(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = false;
            try
            {
                if (!IsUserEqualsAuthUser())
                {
                    // eğer GetInstitutionIdByUserRole() metodu -1 dönerse kullanıcının kurum bilgisi yok demektir.
                    if (GetInstitutionIdByUserRole() != -1)
                        user.InstitutionId = GetInstitutionIdByUserRole();
                    else
                        user.InstitutionId = null;
                    user.RoleId = GetRoleIdFromComboBoxText();
                }
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;
                user.PhoneNumber = txtPhoneNumber.Text;
                user.UpdatedAt = DateTime.Now;
                if (ValidateUser(user))
                {
                    userService.Update(user);
                    XtraMessageBox.Show("Kullanıcı başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!IsUserEqualsAuthUser())
                        RefreshContentAuthUser(user.Id, authUser);
                    else
                        RefreshContentAuthUser(null, user);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kullanıcı güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSaveChanges.Enabled = true;
        }

        private void btnChangeIsActive_Click_1(object sender, EventArgs e)
        {
            btnChangeIsActive.Enabled = true;
            try
            {
                if (user.IsActive == true)
                    DeactivateUser();
                else
                    ActivateUser();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kullanıcı aktiflik durumu değiştirilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            btnChangeIsActive.Enabled = true;

        }
        private void txtDeactivatedReason_Click(object sender, EventArgs e)
        {
            txtDeactivatedReason.Text = "";
        }

        private void DeactivateUser()
        {
            user.IsActive = false;
            user.DeactivetedDate = DateTime.Now;
            user.DeactivetedReason = txtDeactivatedReason.Text;
            userService.Update(user);
            XtraMessageBox.Show("Kullanıcı başarıyla pasif hale getirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshContentAuthUser(user.Id, authUser);
        }

        private void ActivateUser()
        {
            user.IsActive = true;
            user.UpdatedAt = DateTime.Now;
            userService.Update(user);
            XtraMessageBox.Show("Kullanıcı başarıyla aktif hale getirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshContentAuthUser(user.Id, authUser);
        }

        private void ViewUserInfo()
        {
            txtEmail.Text = user.Email;
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtPhoneNumber.Text = user.PhoneNumber;
            txtPassword.Text = user.Password;
            txtCreatedAt.Text = user.CreatedAt.ToString();
            if (!IsUserEqualsAuthUser())
            {
                if (user.DeactivetedReason == null)
                {
                    txtDeactivatedDate.Text = "Kullanıcı hiç pasif edilmemiş!";
                    txtDeactivatedReason.Text = "Bu alana tıklayıp pasif etme nedeninizi yazın ve ardından \"Pasif Hale Getir\" butonuna basarak kullanıcıyı pasif hale getirebilirsiniz.";
                }
                else
                {
                    txtDeactivatedDate.Text = user.DeactivetedDate.ToString();
                    txtDeactivatedReason.Text = user.DeactivetedReason;
                }
                comboBox_Roles.Text = GetRoleNameByUserRole();
                if (authUser.RoleId == (int)Role.RoleNames.Admin)
                {
                    if (user.Institution == null)
                        comboBox_Institutions.Text = "Bireysel";
                    else
                        comboBox_Institutions.Text = institutionService.GetById((int)user.InstitutionId).Name;
                }
                if (user.IsActive == false)
                {
                    txtDeactivatedDate.Text = user.DeactivetedDate.ToString();
                    txtDeactivatedReason.Text = user.DeactivetedReason;
                }
            }
        }
        private void EditItemsVisibility(Role userRole)
        {
            if (IsUserEqualsAuthUser())
            {
                btnChangeIsActive.Visible = false;
                comboBox_Institutions.Visible = false;
                lblSelectRole.Visible = false;
                comboBox_Roles.Visible = false;
                lblSelectInstitution.Visible = false;
                comboBox_Institutions.Visible = false;
                lblDeactivatedDate.Visible = false;
                txtDeactivatedDate.Visible = false;
                lblDeactivatedReason.Visible = false;
                txtDeactivatedReason.Visible = false;
            }
            else
            {
                switch (userRole.Id)
                {
                    case (int)Role.RoleNames.Admin:
                        GetInstitutionsForAdmin();
                        break;
                    case (int)Role.RoleNames.Manager:
                        comboBox_Roles.Items.Remove("Admin");
                        comboBox_Roles.Items.Remove("Kurum Müdürü");
                        lblSelectInstitution.Visible = false;
                        comboBox_Institutions.Visible = false;
                        break;
                    case (int)Role.RoleNames.Teacher:
                        lblSelectRole.Visible = false;
                        comboBox_Roles.Visible = false;
                        lblSelectInstitution.Visible = false;
                        comboBox_Institutions.Visible = false;
                        lblPassword.Visible = false;
                        txtPassword.Visible = false;
                        btnSaveChanges.Visible = false;
                        // Öğretmen yalnızca aşağıdaki bilgileri görüntüleyebilir, düzenleyemez.
                        txtEmail.Enabled = false;
                        txtName.Enabled = false;
                        txtSurname.Enabled = false;
                        txtPhoneNumber.Enabled = false;
                        break;
                }
            }
        }

        private int GetInstitutionIdByUserRole()
        {
            if (authUser.RoleId == (int)Role.RoleNames.Admin)
                return GetInstitutionIdFromComboBoxText();
            else
                return (int)authUser.InstitutionId;
        }

        private int GetRoleIdFromComboBoxText()
        {
            switch (comboBox_Roles.Text)
            {
                case "Admin":
                    return (int)Role.RoleNames.Admin;
                case "Kurum Müdürü":
                    return (int)Role.RoleNames.Manager;
                case "Öğretmen":
                    return (int)Role.RoleNames.Teacher;
                case "Öğrenci":
                    return (int)Role.RoleNames.Student;
                default:
                    return -1;
            }
        }

        private string GetRoleNameByUserRole()
        {
            switch (user.RoleId)
            {
                case (int)Role.RoleNames.Admin:
                    return "Admin";
                case (int)Role.RoleNames.Manager:
                    return "Kurum Müdürü";
                case (int)Role.RoleNames.Teacher:
                    return "Öğretmen";
                case (int)Role.RoleNames.Student:
                    return "Öğrenci";
                default:
                    return "";
            }
        }

        private void GetInstitutionsForAdmin()
        {
            institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
            institutions = institutionService.GetAll().Where(x => x.IsActive == true);
            foreach (var institution in institutions)
            {
                comboBox_Institutions.Items.Add(institution.Name);
                comboBox_Institutions.ValueMember = institution.Id.ToString();
            }
        }

        private int GetInstitutionIdFromComboBoxText()
        {
            return institutions.FirstOrDefault(i => i.Name == comboBox_Institutions.Text)?.Id ?? -1;
        }

        private User GetUserInfo(int userId)
        {
            return userService.GetById(userId);
        }

        private void IsUserActive()
        {
            if (user.IsActive)
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
        public void RefreshContentAuthUser(int? userId, User authUser)
        {
            // Mevcut kontrolleri temizle
            foreach (Control control in this.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            this.Controls.Clear();

            if (userId == null)
            {
                // Yeni kontrolü ekle
                var newControl = new EditUser(authUser);
                this.Controls.Add(newControl);
                newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
            }
            else
            {
                // Yeni kontrolü ekle
                var newControl = new EditUser((int)userId, authUser);
                this.Controls.Add(newControl);
                newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
            }

        }
        public bool ValidateUser(User user)
        {
            var validator = new CreateUserValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate(user);
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