using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using DigitalClassroom.Forms.MainForms;
using System.Configuration;
using DigitalClassroom.BusinessLayer.Validations;
using System.ComponentModel.DataAnnotations;
using DigitalClassroom.BusinessLayer.Validations.Login;

namespace DigitalClassroom.Forms.AuthForms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Çıkmak istediğinizden emin misiniz?
            DialogResult dialogResult = XtraMessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Register formu oluştur ve göster
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormClosed += RegisterForm_FormClosed; // Kapatıldığında geri dönüş için bir event ekleyin
            this.Hide(); // Login formu gizle
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (ValidateLogin(email,password))
                {
                    IUserService userService = new UserManager(new UserRepository(new AppDbContext()));
                    User authenticatedUser = userService.AuthenticateUser(email, password);
                    if (authenticatedUser.IsActive == true)
                    {
                        // Kullanıcı mail adresini config dosyasında tutan metot
                        chkRememberMeControl();
                        // Kullanıcı doğru ise ve aktifse MainForm'a yönlendirme
                        MainForm mainForm = new MainForm(authenticatedUser);
                        mainForm.FormClosed += MainForm_FormClosed;
                        this.Hide(); // Login formunu gizle
                        mainForm.Show();
                    }
                    else
                        XtraMessageBox.Show($"Yetkiliye başvurun ve hesabınızı aktifleştirin!\n\nPasif Edilme Nedeni:\n{authenticatedUser.DeactivetedReason}", "Kullanıcı pasif halde!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kullanıcı bilgilerini kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkRememberMeControl()
        {
            if (chkRememberMe.Checked)
                SaveRememberMeSettings(true, txtEmail.Text);
            else
                SaveRememberMeSettings(false, "");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["RememberMe"] == "true")
            {
                chkRememberMe.Checked = true;
                txtEmail.Text = ConfigurationManager.AppSettings["SavedEmail"];
                txtPassword.Text = ConfigurationManager.AppSettings["SavedPassword"];
            }
        }
        private void SaveRememberMeSettings(bool rememberMe, string email)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["RememberMe"].Value = rememberMe.ToString().ToLower();
            config.AppSettings.Settings["SavedEmail"].Value = email;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        // RegisterForm kapatıldığında LoginForm'u geri göster
        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        // MainForm kapatıldığında LoginForm'u geri göster
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        public bool ValidateLogin(string email, string password)
        {
            var validator = new LoginValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate((email, password));
            if (!result.IsValid)
            {
                // Tüm hataları tek bir mesajda ilet
                string errorMessage = result.Errors.Select(x => x.ErrorMessage).Aggregate((i, j) => i + "\n" + j);
                XtraMessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}