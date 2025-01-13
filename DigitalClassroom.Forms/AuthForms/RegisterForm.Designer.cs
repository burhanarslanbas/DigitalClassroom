namespace DigitalClassroom.Forms.AuthForms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panelRegister = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblSurname = new DevExpress.XtraEditors.LabelControl();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.lblRegisterScreen = new DevExpress.XtraEditors.LabelControl();
            this.btnReturnLoginPage = new DevExpress.XtraEditors.SimpleButton();
            this.lblDigitalClassroom = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelRegister)).BeginInit();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // panelRegister
            // 
            this.panelRegister.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRegister.Appearance.Options.UseBackColor = true;
            this.panelRegister.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelRegister.Controls.Add(this.labelControl1);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.lblPassword);
            this.panelRegister.Controls.Add(this.txtPassword);
            this.panelRegister.Controls.Add(this.lblEmail);
            this.panelRegister.Controls.Add(this.txtEmail);
            this.panelRegister.Controls.Add(this.lblName);
            this.panelRegister.Controls.Add(this.lblSurname);
            this.panelRegister.Controls.Add(this.txtSurname);
            this.panelRegister.Controls.Add(this.lblRegisterScreen);
            this.panelRegister.Controls.Add(this.btnReturnLoginPage);
            this.panelRegister.Controls.Add(this.lblDigitalClassroom);
            this.panelRegister.Controls.Add(this.txtName);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(434, 621);
            this.panelRegister.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(121, 374);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Uyarı: Sifreniz minimum 6 haneli olmalıdır.";
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.Location = new System.Drawing.Point(250, 407);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(20);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(91, 25);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Appearance.Options.UseForeColor = true;
            this.lblPassword.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPassword.Location = new System.Drawing.Point(77, 338);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(30, 23);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(121, 338);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.AutoHeight = false;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(220, 30);
            this.txtPassword.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblEmail.Location = new System.Drawing.Point(58, 298);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 23);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-posta";
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(121, 298);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.AutoHeight = false;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Properties.Mask.EditMask = ".+";
            this.txtEmail.Size = new System.Drawing.Size(220, 30);
            this.txtEmail.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Appearance.Options.UseForeColor = true;
            this.lblName.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblName.Location = new System.Drawing.Point(91, 226);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 23);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Ad";
            // 
            // lblSurname
            // 
            this.lblSurname.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSurname.Appearance.Options.UseFont = true;
            this.lblSurname.Appearance.Options.UseForeColor = true;
            this.lblSurname.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSurname.Location = new System.Drawing.Point(69, 262);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(38, 23);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Soyad";
            // 
            // txtSurname
            // 
            this.txtSurname.EditValue = "";
            this.txtSurname.Location = new System.Drawing.Point(121, 262);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSurname.Properties.Appearance.Options.UseBackColor = true;
            this.txtSurname.Properties.AutoHeight = false;
            this.txtSurname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSurname.Properties.Mask.EditMask = ".+";
            this.txtSurname.Size = new System.Drawing.Size(220, 30);
            this.txtSurname.TabIndex = 10;
            // 
            // lblRegisterScreen
            // 
            this.lblRegisterScreen.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblRegisterScreen.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblRegisterScreen.Appearance.Options.UseFont = true;
            this.lblRegisterScreen.Appearance.Options.UseForeColor = true;
            this.lblRegisterScreen.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblRegisterScreen.Location = new System.Drawing.Point(121, 185);
            this.lblRegisterScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblRegisterScreen.Name = "lblRegisterScreen";
            this.lblRegisterScreen.Size = new System.Drawing.Size(78, 19);
            this.lblRegisterScreen.TabIndex = 9;
            this.lblRegisterScreen.Text = "Kayıt Ekranı";
            // 
            // btnReturnLoginPage
            // 
            this.btnReturnLoginPage.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnReturnLoginPage.Appearance.Options.UseForeColor = true;
            this.btnReturnLoginPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnLoginPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnLoginPage.ImageOptions.Image")));
            this.btnReturnLoginPage.Location = new System.Drawing.Point(378, 8);
            this.btnReturnLoginPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturnLoginPage.Name = "btnReturnLoginPage";
            this.btnReturnLoginPage.Size = new System.Drawing.Size(47, 42);
            this.btnReturnLoginPage.TabIndex = 8;
            this.btnReturnLoginPage.Click += new System.EventHandler(this.btnReturnLoginPage_Click);
            // 
            // lblDigitalClassroom
            // 
            this.lblDigitalClassroom.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDigitalClassroom.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblDigitalClassroom.Appearance.Options.UseFont = true;
            this.lblDigitalClassroom.Appearance.Options.UseForeColor = true;
            this.lblDigitalClassroom.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblDigitalClassroom.Location = new System.Drawing.Point(121, 150);
            this.lblDigitalClassroom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblDigitalClassroom.Name = "lblDigitalClassroom";
            this.lblDigitalClassroom.Size = new System.Drawing.Size(101, 29);
            this.lblDigitalClassroom.TabIndex = 3;
            this.lblDigitalClassroom.Text = "Dijital Sınıf";
            // 
            // txtName
            // 
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(121, 226);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.AutoHeight = false;
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtName.Properties.Mask.EditMask = ".+";
            this.txtName.Size = new System.Drawing.Size(220, 30);
            this.txtName.TabIndex = 0;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 621);
            this.Controls.Add(this.panelRegister);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelRegister)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.PanelControl panelRegister;
        private DevExpress.XtraEditors.LabelControl lblRegisterScreen;
        private DevExpress.XtraEditors.SimpleButton btnReturnLoginPage;
        private DevExpress.XtraEditors.LabelControl lblDigitalClassroom;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblSurname;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}