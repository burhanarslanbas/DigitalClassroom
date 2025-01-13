namespace DigitalClassroom.Forms.Controls.Pages.Users
{
    partial class CreateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.lblSurname = new DevExpress.XtraEditors.LabelControl();
            this.btnCreateUser = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox_Institutions = new System.Windows.Forms.ComboBox();
            this.lblSelectInstitution = new DevExpress.XtraEditors.LabelControl();
            this.lblCourseTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblPageOfCreatingUser = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox_Roles = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSurname
            // 
            this.txtSurname.EditValue = "";
            this.txtSurname.Location = new System.Drawing.Point(258, 50);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSurname.Properties.Appearance.Options.UseBackColor = true;
            this.txtSurname.Properties.AutoHeight = false;
            this.txtSurname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSurname.Properties.Mask.EditMask = ".+";
            this.txtSurname.Properties.NullValuePrompt = "Soyisim";
            this.txtSurname.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSurname.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtSurname.Size = new System.Drawing.Size(220, 23);
            this.txtSurname.TabIndex = 61;
            // 
            // lblSurname
            // 
            this.lblSurname.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblSurname.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSurname.Appearance.Options.UseFont = true;
            this.lblSurname.Appearance.Options.UseForeColor = true;
            this.lblSurname.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSurname.Location = new System.Drawing.Point(258, 25);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(62, 19);
            this.lblSurname.TabIndex = 60;
            this.lblSurname.Text = "Soyadı (*)";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateUser.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateUser.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateUser.Appearance.Options.UseBackColor = true;
            this.btnCreateUser.Appearance.Options.UseFont = true;
            this.btnCreateUser.Appearance.Options.UseForeColor = true;
            this.btnCreateUser.Location = new System.Drawing.Point(627, 194);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(91, 25);
            this.btnCreateUser.TabIndex = 59;
            this.btnCreateUser.Text = "Oluştur";
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // comboBox_Institutions
            // 
            this.comboBox_Institutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Institutions.FormattingEnabled = true;
            this.comboBox_Institutions.Items.AddRange(new object[] {
            "Bireysel"});
            this.comboBox_Institutions.Location = new System.Drawing.Point(14, 197);
            this.comboBox_Institutions.Name = "comboBox_Institutions";
            this.comboBox_Institutions.Size = new System.Drawing.Size(220, 23);
            this.comboBox_Institutions.TabIndex = 56;
            this.comboBox_Institutions.Visible = false;
            // 
            // lblSelectInstitution
            // 
            this.lblSelectInstitution.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblSelectInstitution.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelectInstitution.Appearance.Options.UseFont = true;
            this.lblSelectInstitution.Appearance.Options.UseForeColor = true;
            this.lblSelectInstitution.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSelectInstitution.Location = new System.Drawing.Point(14, 172);
            this.lblSelectInstitution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSelectInstitution.Name = "lblSelectInstitution";
            this.lblSelectInstitution.Size = new System.Drawing.Size(89, 19);
            this.lblSelectInstitution.TabIndex = 55;
            this.lblSelectInstitution.Text = "Kurum Seçimi";
            this.lblSelectInstitution.Visible = false;
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblCourseTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblCourseTitle.Appearance.Options.UseFont = true;
            this.lblCourseTitle.Appearance.Options.UseForeColor = true;
            this.lblCourseTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblCourseTitle.Location = new System.Drawing.Point(14, 25);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(41, 19);
            this.lblCourseTitle.TabIndex = 54;
            this.lblCourseTitle.Text = "Adı (*)";
            // 
            // lblPageOfCreatingUser
            // 
            this.lblPageOfCreatingUser.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageOfCreatingUser.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageOfCreatingUser.Appearance.Options.UseFont = true;
            this.lblPageOfCreatingUser.Appearance.Options.UseForeColor = true;
            this.lblPageOfCreatingUser.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPageOfCreatingUser.Location = new System.Drawing.Point(51, 8);
            this.lblPageOfCreatingUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPageOfCreatingUser.Name = "lblPageOfCreatingUser";
            this.lblPageOfCreatingUser.Size = new System.Drawing.Size(226, 25);
            this.lblPageOfCreatingUser.TabIndex = 53;
            this.lblPageOfCreatingUser.Text = "Kullanıcı Oluşturma Sayfası";
            // 
            // txtName
            // 
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(14, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.AutoHeight = false;
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtName.Properties.Mask.EditMask = ".+";
            this.txtName.Properties.NullValuePrompt = "İsim";
            this.txtName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtName.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtName.Size = new System.Drawing.Size(220, 23);
            this.txtName.TabIndex = 52;
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(498, 50);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.AutoHeight = false;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEmail.Properties.Mask.EditMask = ".+";
            this.txtEmail.Properties.NullValuePrompt = "Mail Adresi";
            this.txtEmail.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtEmail.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtEmail.Size = new System.Drawing.Size(220, 23);
            this.txtEmail.TabIndex = 63;
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblEmail.Location = new System.Drawing.Point(498, 25);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 19);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "Mail Adresi (*)";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.EditValue = "";
            this.txtPhoneNumber.Location = new System.Drawing.Point(258, 132);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtPhoneNumber.Properties.AutoHeight = false;
            this.txtPhoneNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPhoneNumber.Properties.Mask.EditMask = "(90) \\d\\d\\d-\\d\\d\\d-\\d\\d\\d\\d";
            this.txtPhoneNumber.Properties.Mask.IgnoreMaskBlank = false;
            this.txtPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtPhoneNumber.Properties.NullValuePrompt = "Telefon Numarası";
            this.txtPhoneNumber.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPhoneNumber.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(220, 23);
            this.txtPhoneNumber.TabIndex = 65;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblPhoneNumber.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPhoneNumber.Appearance.Options.UseFont = true;
            this.lblPhoneNumber.Appearance.Options.UseForeColor = true;
            this.lblPhoneNumber.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPhoneNumber.Location = new System.Drawing.Point(258, 103);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(111, 19);
            this.lblPhoneNumber.TabIndex = 64;
            this.lblPhoneNumber.Text = "Telefon Numarası";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(498, 132);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.AutoHeight = false;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPassword.Properties.Mask.EditMask = ".+";
            this.txtPassword.Properties.NullValuePrompt = "Şifre";
            this.txtPassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPassword.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtPassword.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.TabIndex = 67;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(498, 103);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 19);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Şifre (*)";
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Items.AddRange(new object[] {
            "Admin",
            "Kurum Müdürü",
            "Öğretmen",
            "Öğrenci"});
            this.comboBox_Roles.Location = new System.Drawing.Point(14, 133);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(220, 23);
            this.comboBox_Roles.TabIndex = 69;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.Location = new System.Drawing.Point(14, 103);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 19);
            this.labelControl2.TabIndex = 68;
            this.labelControl2.Text = "Rol Seçimi";
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Controls.Add(this.lblPageOfCreatingUser);
            this.panelControl4.Location = new System.Drawing.Point(16, 19);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(287, 42);
            this.panelControl4.TabIndex = 86;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(6, 3);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(37, 34);
            this.pictureEdit1.TabIndex = 65;
            this.pictureEdit1.TabStop = true;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.txtSurname);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.comboBox_Roles);
            this.panelControl1.Controls.Add(this.lblCourseTitle);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblSelectInstitution);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Controls.Add(this.comboBox_Institutions);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnCreateUser);
            this.panelControl1.Controls.Add(this.txtPhoneNumber);
            this.panelControl1.Controls.Add(this.lblSurname);
            this.panelControl1.Controls.Add(this.lblPhoneNumber);
            this.panelControl1.Controls.Add(this.lblEmail);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Location = new System.Drawing.Point(16, 77);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(740, 259);
            this.panelControl1.TabIndex = 87;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Name = "CreateUser";
            this.Size = new System.Drawing.Size(841, 608);
            this.Load += new System.EventHandler(this.CreateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.LabelControl lblSurname;
        private DevExpress.XtraEditors.SimpleButton btnCreateUser;
        private System.Windows.Forms.ComboBox comboBox_Institutions;
        private DevExpress.XtraEditors.LabelControl lblSelectInstitution;
        private DevExpress.XtraEditors.LabelControl lblCourseTitle;
        private DevExpress.XtraEditors.LabelControl lblPageOfCreatingUser;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox comboBox_Roles;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
