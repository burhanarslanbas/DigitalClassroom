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
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.Forms.Controls.Pages.Announcements;
using DigitalClassroom.Forms.Controls.Pages.Courses;
using DigitalClassroom.Forms.Controls.Pages.HomePage;
using DigitalClassroom.Forms.Controls.Pages.Institutions;
using DigitalClassroom.Forms.Controls.Pages.Users;

namespace DigitalClassroom.Forms.MainForms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private User AuthUser;
        public MainForm(User AuthUser)
        {
            this.AuthUser = AuthUser;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPage(new HomePage(AuthUser));
            GetSidebarElementsByUserRole(AuthUser.Role);
            string formTitle = $"Digital Classroom - {AuthUser.Role.RoleName} Panel";
            this.Text = formTitle;
        }

        private void GetSidebarElementsByUserRole(Role authUserRole)
        {
            switch (authUserRole.RoleName)
            {
                case "Student":
                    sidebar_Announcements_CreateAnnouncement.Visible = false;
                    sidebar_Courses_CreateCourse.Visible = false;
                    sidebar_Institutions.Visible = false;
                    sidebar_Users.Visible = false;
                    break;
                case "Teacher":
                    sidebar_Courses_JoinCourse.Visible = false;
                    sidebar_Institutions.Visible = false;
                    sidebar_Users.Visible = false;
                    break;
                case "Manager":
                    sidebar_Institutions.Visible = false;
                    sidebar_Courses_JoinCourse.Visible = false;
                    break;
            }
        }

        private void LoadPage(UserControl page)
        {
            //this.homePage = page;
            //panelContent.Controls.Clear(); // Önceki sayfayı temizle
            //page.Dock = DockStyle.Fill; // Sayfayı tam oturt
            //panelContent.Controls.Add(page); // Yeni sayfayı ekle
            // Mevcut kontrolleri temizle
            foreach (Control control in panelContent.Controls)
            {
                control.Dispose(); // Kontrolleri bellekten sil
            }

            // Tüm kontrolleri koleksiyondan kaldır
            panelContent.Controls.Clear();

            // Yeni kontrolü ekle
            var newControl = page;
            panelContent.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill; // Yeni kontrolü tam ekrana yay
        }

        private void sidebar_HomePage_Click(object sender, EventArgs e)
        {
            LoadPage(new HomePage(AuthUser));
        }

        private void sidebar_Announcements_CreateAnnouncement_Click(object sender, EventArgs e)
        {
            LoadPage(new CreateAnnouncement(AuthUser));
        }

        private void sidebar_Courses_CreateCourse_Click(object sender, EventArgs e)
        {
            LoadPage(new CreateCourse(AuthUser));
        }

        private void sidebar_Users_CreateUser_Click(object sender, EventArgs e)
        {
            LoadPage(new CreateUser(AuthUser));
        }

        private void sidebar_Account_Edit_Click(object sender, EventArgs e)
        {
            LoadPage(new EditUser(AuthUser));
        }

        private void sidebar_Users_ViewUsers_Click(object sender, EventArgs e)
        {
            LoadPage(new ViewUsers(AuthUser));
        }

        private void sidebar_Account_Logout_Click(object sender, EventArgs e)
        {
            // Çıkış yapmak istediğinize emin misiniz?
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void sidebar_Institutions_AddInstitution_Click(object sender, EventArgs e)
        {
            LoadPage(new AddInstitution(AuthUser));
        }

        private void sidebar_Institutions_ViewInstitutions_Click(object sender, EventArgs e)
        {
            LoadPage(new ViewInstitutions());
        }

        private void sidebar_Courses_JoinCourse_Click(object sender, EventArgs e)
        {
            JoinCourse joinCourse = new JoinCourse(AuthUser);
            // Oluşturulan UserControl'ü MessageBox'ta göstermek için form'a dönüştür
            Form joinCourseForm = new Form();
            joinCourseForm.Controls.Add(joinCourse);
            joinCourseForm.FormBorderStyle = FormBorderStyle.None;
            joinCourseForm.Size = joinCourse.Size;
            joinCourseForm.StartPosition = FormStartPosition.CenterScreen;
            joinCourseForm.ShowDialog();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}