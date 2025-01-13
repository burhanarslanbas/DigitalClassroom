namespace DigitalClassroom.Forms.MainForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.sidebar_HomePage = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Announcements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Announcements_CreateAnnouncement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Courses = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Courses_CreateCourse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Courses_JoinCourse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Institutions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Institutions_ViewInstitutions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Institutions_AddInstitution = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Users_ViewUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Users_CreateUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Account = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Account_Edit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sidebar_Account_Logout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Bil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelContent = new DevExpress.XtraEditors.PanelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sidebar_HomePage,
            this.sidebar_Announcements,
            this.sidebar_Courses,
            this.sidebar_Institutions,
            this.sidebar_Users,
            this.sidebar_Account});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(303, 701);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "sidebar";
            // 
            // sidebar_HomePage
            // 
            this.sidebar_HomePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_HomePage.ImageOptions.Image")));
            this.sidebar_HomePage.Name = "sidebar_HomePage";
            this.sidebar_HomePage.Text = "Ana Sayfa";
            this.sidebar_HomePage.Click += new System.EventHandler(this.sidebar_HomePage_Click);
            // 
            // sidebar_Announcements
            // 
            this.sidebar_Announcements.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sidebar_Announcements_CreateAnnouncement});
            this.sidebar_Announcements.Expanded = true;
            this.sidebar_Announcements.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Announcements.ImageOptions.Image")));
            this.sidebar_Announcements.Name = "sidebar_Announcements";
            this.sidebar_Announcements.Text = "Duyurular";
            // 
            // sidebar_Announcements_CreateAnnouncement
            // 
            this.sidebar_Announcements_CreateAnnouncement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Announcements_CreateAnnouncement.ImageOptions.Image")));
            this.sidebar_Announcements_CreateAnnouncement.Name = "sidebar_Announcements_CreateAnnouncement";
            this.sidebar_Announcements_CreateAnnouncement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Announcements_CreateAnnouncement.Text = "Duyuru Oluştur";
            this.sidebar_Announcements_CreateAnnouncement.Click += new System.EventHandler(this.sidebar_Announcements_CreateAnnouncement_Click);
            // 
            // sidebar_Courses
            // 
            this.sidebar_Courses.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sidebar_Courses_CreateCourse,
            this.sidebar_Courses_JoinCourse});
            this.sidebar_Courses.Expanded = true;
            this.sidebar_Courses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Courses.ImageOptions.Image")));
            this.sidebar_Courses.Name = "sidebar_Courses";
            this.sidebar_Courses.Text = "Kurslar";
            // 
            // sidebar_Courses_CreateCourse
            // 
            this.sidebar_Courses_CreateCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Courses_CreateCourse.ImageOptions.Image")));
            this.sidebar_Courses_CreateCourse.Name = "sidebar_Courses_CreateCourse";
            this.sidebar_Courses_CreateCourse.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Courses_CreateCourse.Text = "Kurs Oluştur";
            this.sidebar_Courses_CreateCourse.Click += new System.EventHandler(this.sidebar_Courses_CreateCourse_Click);
            // 
            // sidebar_Courses_JoinCourse
            // 
            this.sidebar_Courses_JoinCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Courses_JoinCourse.ImageOptions.Image")));
            this.sidebar_Courses_JoinCourse.Name = "sidebar_Courses_JoinCourse";
            this.sidebar_Courses_JoinCourse.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Courses_JoinCourse.Text = "Kursa Katıl";
            this.sidebar_Courses_JoinCourse.Click += new System.EventHandler(this.sidebar_Courses_JoinCourse_Click);
            // 
            // sidebar_Institutions
            // 
            this.sidebar_Institutions.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sidebar_Institutions_ViewInstitutions,
            this.sidebar_Institutions_AddInstitution});
            this.sidebar_Institutions.Expanded = true;
            this.sidebar_Institutions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Institutions.ImageOptions.Image")));
            this.sidebar_Institutions.Name = "sidebar_Institutions";
            this.sidebar_Institutions.Text = "Kurumlar";
            // 
            // sidebar_Institutions_ViewInstitutions
            // 
            this.sidebar_Institutions_ViewInstitutions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Institutions_ViewInstitutions.ImageOptions.Image")));
            this.sidebar_Institutions_ViewInstitutions.Name = "sidebar_Institutions_ViewInstitutions";
            this.sidebar_Institutions_ViewInstitutions.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Institutions_ViewInstitutions.Text = "Kurumları Görüntüle";
            this.sidebar_Institutions_ViewInstitutions.Click += new System.EventHandler(this.sidebar_Institutions_ViewInstitutions_Click);
            // 
            // sidebar_Institutions_AddInstitution
            // 
            this.sidebar_Institutions_AddInstitution.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Institutions_AddInstitution.ImageOptions.Image")));
            this.sidebar_Institutions_AddInstitution.Name = "sidebar_Institutions_AddInstitution";
            this.sidebar_Institutions_AddInstitution.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Institutions_AddInstitution.Text = "Kurum Ekle";
            this.sidebar_Institutions_AddInstitution.Click += new System.EventHandler(this.sidebar_Institutions_AddInstitution_Click);
            // 
            // sidebar_Users
            // 
            this.sidebar_Users.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sidebar_Users_ViewUsers,
            this.sidebar_Users_CreateUser});
            this.sidebar_Users.Expanded = true;
            this.sidebar_Users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Users.ImageOptions.Image")));
            this.sidebar_Users.Name = "sidebar_Users";
            this.sidebar_Users.Text = "Kullanıcılar";
            // 
            // sidebar_Users_ViewUsers
            // 
            this.sidebar_Users_ViewUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Users_ViewUsers.ImageOptions.Image")));
            this.sidebar_Users_ViewUsers.Name = "sidebar_Users_ViewUsers";
            this.sidebar_Users_ViewUsers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Users_ViewUsers.Text = "Kullanıcıları Görüntüle";
            this.sidebar_Users_ViewUsers.Click += new System.EventHandler(this.sidebar_Users_ViewUsers_Click);
            // 
            // sidebar_Users_CreateUser
            // 
            this.sidebar_Users_CreateUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Users_CreateUser.ImageOptions.Image")));
            this.sidebar_Users_CreateUser.Name = "sidebar_Users_CreateUser";
            this.sidebar_Users_CreateUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Users_CreateUser.Text = "Kullanıcı Oluştur";
            this.sidebar_Users_CreateUser.Click += new System.EventHandler(this.sidebar_Users_CreateUser_Click);
            // 
            // sidebar_Account
            // 
            this.sidebar_Account.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.sidebar_Account_Edit,
            this.sidebar_Account_Logout});
            this.sidebar_Account.Expanded = true;
            this.sidebar_Account.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Account.ImageOptions.Image")));
            this.sidebar_Account.Name = "sidebar_Account";
            this.sidebar_Account.Text = "Hesabım";
            // 
            // sidebar_Account_Edit
            // 
            this.sidebar_Account_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Account_Edit.ImageOptions.Image")));
            this.sidebar_Account_Edit.Name = "sidebar_Account_Edit";
            this.sidebar_Account_Edit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Account_Edit.Text = "Profil Bilgilerimi Düzenle";
            this.sidebar_Account_Edit.Click += new System.EventHandler(this.sidebar_Account_Edit_Click);
            // 
            // sidebar_Account_Logout
            // 
            this.sidebar_Account_Logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sidebar_Account_Logout.ImageOptions.Image")));
            this.sidebar_Account_Logout.Name = "sidebar_Account_Logout";
            this.sidebar_Account_Logout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sidebar_Account_Logout.Text = "Çıkış Yap";
            this.sidebar_Account_Logout.Click += new System.EventHandler(this.sidebar_Account_Logout_Click);
            // 
            // Bil
            // 
            this.Bil.Name = "Bil";
            this.Bil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Bil.Text = "Bilgileri Düzenle";
            // 
            // panelContent
            // 
            this.panelContent.AutoSize = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(303, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(981, 701);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "Kurslar";
            // 
            // tileItem1
            // 
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.Text = "tileItem1";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 2;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "tileItem2";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 3;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            tileItemElement3.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 4;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 740);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Classroom - {Rol ismi} Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_HomePage;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Account;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Account_Logout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Bil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Account_Edit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Courses;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Institutions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Announcements;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Announcements_CreateAnnouncement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Institutions_ViewInstitutions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Institutions_AddInstitution;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Users_ViewUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Users_CreateUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Courses_CreateCourse;
        private DevExpress.XtraEditors.PanelControl panelContent;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sidebar_Courses_JoinCourse;
    }
}