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
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.BusinessLayer.Validations.Register;
namespace DigitalClassroom.Forms.AuthForms
{
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        private IUserService userService;
        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userService = new UserManager(new UserRepository(new AppDbContext()));
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            // Register butonu tıklandığında yapılacak işlemler
            // Kullanıcı adı, soyadı, email ve şifre alınır ve veritabanına kaydedilir.
            btnRegister.Enabled = false;
            try
            {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                if (ValidateRegister(name,surname,email,password))
                { 
                    // Eğer bu mail adresiyle daha önce kayıt yapılmışsa hata ver
                    if (userService.Find(x => x.Email == email).Count() > 0)
                    {
                        XtraMessageBox.Show("Bu mail adresiyle daha önce kayıt yapılmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnRegister.Enabled = true;
                        return;
                    }
                    else
                    {
                        User user = new User()
                        {
                            // Register formundan kayıt olan kullanıcıların rolü öğrenci oluyor.
                            RoleId = (int)Role.RoleNames.Student,
                            Name = name,
                            Surname = surname,
                            Email = email,
                            Password = password,
                            CreatedAt = DateTime.Now,
                            IsActive = true
                        };
                        userService.Add(user);
                        XtraMessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti. Giriş ekranına yönlendiriliyorsunuz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            btnRegister.Enabled = true;
        }

        // Kayıt formundaki alanlar için belirlenen kurallara göre doğrulama işlemi yapar.
        private bool ValidateRegister(string name, string surname, string email, string password)
        {
            var validator = new RegisterValidator();
            // Tuple olarak değerleri doğrula
            FluentValidation.Results.ValidationResult result = validator.Validate((name, surname, email, password));
            if (!result.IsValid)
            {
                // Tüm hataları tek bir mesajda ilet
                string errorMessage = result.Errors.Select(x => x.ErrorMessage).Aggregate((i, j) => i + "\n" + j);
                XtraMessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnReturnLoginPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}