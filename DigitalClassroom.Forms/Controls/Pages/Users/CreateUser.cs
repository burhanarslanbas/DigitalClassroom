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
using DigitalClassroom.BusinessLayer.Validations.Login;
using DigitalClassroom.BusinessLayer.Validations.Users;
using DigitalClassroom.Forms.Controls.Pages.Institutions;

namespace DigitalClassroom.Forms.Controls.Pages.Users
{
    public partial class CreateUser : DevExpress.XtraEditors.XtraUserControl
    {
        private User user;
        private IEnumerable<Institution> institutions;
        public CreateUser(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            EditItemsVisibilityByUserRole(user.Role);
        }
        private void GetInstitutionsForAdmin()
        {
            IInstitutionService institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
            institutions = institutionService.GetAll().Where(x => x.IsActive == true);
            foreach (var institution in institutions)
            {
                comboBox_Institutions.Items.Add(institution.Name);
            }
        }
        private int GetInstitutionIdFromComboBoxText()
        {
            return institutions.FirstOrDefault(i => i.Name == comboBox_Institutions.Text)?.Id ?? -1;
        }
        private void EditItemsVisibilityByUserRole(Role userRole)
        {
            switch (userRole.Id)
            {
                case (int)Role.RoleNames.Admin:
                    lblSelectInstitution.Visible = true;
                    comboBox_Institutions.Visible = true;
                    GetInstitutionsForAdmin();
                    break;
                case (int)Role.RoleNames.Manager:
                    comboBox_Roles.Items.Remove("Admin");
                    comboBox_Roles.Items.Remove("Kurum Müdürü");
                    break;
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            btnCreateUser.Enabled = false;
            try
            {
                int roleId = GetRoleIdFromComboBoxText();

                User user = new User
                {
                    RoleId = roleId,
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                    IsActive = true,
                    CreatedAt = DateTime.Now
                };
                if (ValidateUser(user))
                {

                    // eğer GetInstitutionIdByUserRole() metodu -1 dönerse kullanıcının kurum bilgisi yok demektir.
                    if (GetInstitutionIdByUserRole() != -1)
                    {
                        user.InstitutionId = GetInstitutionIdByUserRole();
                    }
                    IUserService userService = new UserManager(new UserRepository(new AppDbContext()));
                    userService.Add(user);
                    XtraMessageBox.Show("Kullanıcı oluşturma işlemi başarılı bir şekilde gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnHomePage(this.user);

                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kullanıcı oluşturma işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCreateUser.Enabled = true;
        }
        private int GetInstitutionIdByUserRole()
        {
            switch (this.user.RoleId)
            {
                case (int)Role.RoleNames.Admin:
                    return GetInstitutionIdFromComboBoxText();
                default:
                    return (int)this.user.InstitutionId;
            }
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
        public void ReturnHomePage(User user)
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
    }
}
