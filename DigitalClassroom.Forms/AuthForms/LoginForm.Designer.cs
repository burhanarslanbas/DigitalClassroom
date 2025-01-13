namespace DigitalClassroom.Forms.AuthForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new DevExpress.XtraEditors.PanelControl();
            this.chkRememberMe = new DevExpress.XtraEditors.CheckEdit();
            this.lblLoginScreen = new DevExpress.XtraEditors.LabelControl();
            this.lblDigitalClassroom = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelLogin)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLogin.Appearance.Options.UseBackColor = true;
            this.panelLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelLogin.Controls.Add(this.chkRememberMe);
            this.panelLogin.Controls.Add(this.lblLoginScreen);
            this.panelLogin.Controls.Add(this.lblDigitalClassroom);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.lblEmail);
            this.panelLogin.Controls.Add(this.btnExit);
            this.panelLogin.Controls.Add(this.btnRegister);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(434, 621);
            this.panelLogin.TabIndex = 0;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.Location = new System.Drawing.Point(274, 331);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11F);
            this.chkRememberMe.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.chkRememberMe.Properties.Appearance.Options.UseFont = true;
            this.chkRememberMe.Properties.Appearance.Options.UseForeColor = true;
            this.chkRememberMe.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.chkRememberMe.Properties.Caption = "Beni Hatırla";
            this.chkRememberMe.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkRememberMe.Size = new System.Drawing.Size(76, 22);
            this.chkRememberMe.TabIndex = 23;
            // 
            // lblLoginScreen
            // 
            this.lblLoginScreen.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblLoginScreen.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblLoginScreen.Appearance.Options.UseFont = true;
            this.lblLoginScreen.Appearance.Options.UseForeColor = true;
            this.lblLoginScreen.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblLoginScreen.Location = new System.Drawing.Point(130, 201);
            this.lblLoginScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblLoginScreen.Name = "lblLoginScreen";
            this.lblLoginScreen.Size = new System.Drawing.Size(75, 19);
            this.lblLoginScreen.TabIndex = 22;
            this.lblLoginScreen.Text = "Giriş Ekranı";
            // 
            // lblDigitalClassroom
            // 
            this.lblDigitalClassroom.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDigitalClassroom.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblDigitalClassroom.Appearance.Options.UseFont = true;
            this.lblDigitalClassroom.Appearance.Options.UseForeColor = true;
            this.lblDigitalClassroom.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblDigitalClassroom.Location = new System.Drawing.Point(130, 164);
            this.lblDigitalClassroom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblDigitalClassroom.Name = "lblDigitalClassroom";
            this.lblDigitalClassroom.Size = new System.Drawing.Size(101, 29);
            this.lblDigitalClassroom.TabIndex = 21;
            this.lblDigitalClassroom.Text = "Dijital Sınıf";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Appearance.Options.UseForeColor = true;
            this.lblPassword.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPassword.Location = new System.Drawing.Point(88, 288);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(30, 23);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Şifre";
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblEmail.Location = new System.Drawing.Point(65, 241);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 23);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-posta";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(381, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.ToolTip = "Uygulamayı Kapat";
            this.btnExit.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnExit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.Location = new System.Drawing.Point(130, 359);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(20);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(91, 25);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(130, 288);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.AutoHeight = false;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(220, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.Location = new System.Drawing.Point(130, 329);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 25);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(130, 241);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.AutoHeight = false;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Properties.Mask.EditMask = ".+";
            this.txtEmail.Size = new System.Drawing.Size(220, 30);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 621);
            this.Controls.Add(this.panelLogin);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelLogin)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelLogin;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblLoginScreen;
        private DevExpress.XtraEditors.LabelControl lblDigitalClassroom;
        private DevExpress.XtraEditors.CheckEdit chkRememberMe;
    }
}