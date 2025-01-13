namespace DigitalClassroom.Forms.Controls.Pages.Institutions
{
    partial class AddInstitution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInstitution));
            this.lblPageOfCreatingInstitution = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblInstitutionAddress = new DevExpress.XtraEditors.LabelControl();
            this.btnCreateInstitution = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox_InstitutionManager = new System.Windows.Forms.ComboBox();
            this.lblSelectInstitutionManager = new DevExpress.XtraEditors.LabelControl();
            this.lblCourseTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtInstitutionName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInstitutionName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageOfCreatingInstitution
            // 
            this.lblPageOfCreatingInstitution.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageOfCreatingInstitution.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageOfCreatingInstitution.Appearance.Options.UseFont = true;
            this.lblPageOfCreatingInstitution.Appearance.Options.UseForeColor = true;
            this.lblPageOfCreatingInstitution.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPageOfCreatingInstitution.Location = new System.Drawing.Point(56, 8);
            this.lblPageOfCreatingInstitution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPageOfCreatingInstitution.Name = "lblPageOfCreatingInstitution";
            this.lblPageOfCreatingInstitution.Size = new System.Drawing.Size(211, 25);
            this.lblPageOfCreatingInstitution.TabIndex = 54;
            this.lblPageOfCreatingInstitution.Text = "Kurum Oluşturma Sayfası";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.pictureEdit2);
            this.panelControl3.Controls.Add(this.lblPageOfCreatingInstitution);
            this.panelControl3.Location = new System.Drawing.Point(15, 13);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(293, 44);
            this.panelControl3.TabIndex = 82;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(6, 1);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(37, 38);
            this.pictureEdit2.TabIndex = 66;
            this.pictureEdit2.TabStop = true;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.txtContactNumber);
            this.panelControl1.Controls.Add(this.lblContactNumber);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Controls.Add(this.lblEmail);
            this.panelControl1.Controls.Add(this.lblInstitutionAddress);
            this.panelControl1.Controls.Add(this.btnCreateInstitution);
            this.panelControl1.Controls.Add(this.comboBox_InstitutionManager);
            this.panelControl1.Controls.Add(this.lblSelectInstitutionManager);
            this.panelControl1.Controls.Add(this.lblCourseTitle);
            this.panelControl1.Controls.Add(this.txtInstitutionName);
            this.panelControl1.Location = new System.Drawing.Point(15, 77);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(570, 350);
            this.panelControl1.TabIndex = 105;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(22, 194);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 87);
            this.txtAddress.TabIndex = 115;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.EditValue = "";
            this.txtContactNumber.Location = new System.Drawing.Point(22, 125);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtContactNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtContactNumber.Properties.AutoHeight = false;
            this.txtContactNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtContactNumber.Properties.Mask.EditMask = "(90) \\d\\d\\d-\\d\\d\\d-\\d\\d\\d\\d";
            this.txtContactNumber.Properties.Mask.IgnoreMaskBlank = false;
            this.txtContactNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtContactNumber.Properties.NullValuePrompt = "Telefon Numarası";
            this.txtContactNumber.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtContactNumber.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtContactNumber.Size = new System.Drawing.Size(220, 23);
            this.txtContactNumber.TabIndex = 114;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblContactNumber.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblContactNumber.Appearance.Options.UseFont = true;
            this.lblContactNumber.Appearance.Options.UseForeColor = true;
            this.lblContactNumber.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblContactNumber.Location = new System.Drawing.Point(22, 96);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(133, 19);
            this.lblContactNumber.TabIndex = 113;
            this.lblContactNumber.Text = "İletişim Numarası (*)";
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(300, 49);
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
            this.txtEmail.TabIndex = 112;
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblEmail.Location = new System.Drawing.Point(300, 24);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(158, 19);
            this.lblEmail.TabIndex = 111;
            this.lblEmail.Text = "Kurumsal Mail Adresi (*)";
            // 
            // lblInstitutionAddress
            // 
            this.lblInstitutionAddress.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblInstitutionAddress.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstitutionAddress.Appearance.Options.UseFont = true;
            this.lblInstitutionAddress.Appearance.Options.UseForeColor = true;
            this.lblInstitutionAddress.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblInstitutionAddress.Location = new System.Drawing.Point(22, 169);
            this.lblInstitutionAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblInstitutionAddress.Name = "lblInstitutionAddress";
            this.lblInstitutionAddress.Size = new System.Drawing.Size(108, 19);
            this.lblInstitutionAddress.TabIndex = 110;
            this.lblInstitutionAddress.Text = "Kurum Adresi (*)";
            // 
            // btnCreateInstitution
            // 
            this.btnCreateInstitution.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateInstitution.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateInstitution.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateInstitution.Appearance.Options.UseBackColor = true;
            this.btnCreateInstitution.Appearance.Options.UseFont = true;
            this.btnCreateInstitution.Appearance.Options.UseForeColor = true;
            this.btnCreateInstitution.Location = new System.Drawing.Point(22, 294);
            this.btnCreateInstitution.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateInstitution.Name = "btnCreateInstitution";
            this.btnCreateInstitution.Size = new System.Drawing.Size(91, 25);
            this.btnCreateInstitution.TabIndex = 109;
            this.btnCreateInstitution.Text = "Oluştur";
            this.btnCreateInstitution.Click += new System.EventHandler(this.btnCreateInstitution_Click_1);
            // 
            // comboBox_InstitutionManager
            // 
            this.comboBox_InstitutionManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_InstitutionManager.FormattingEnabled = true;
            this.comboBox_InstitutionManager.Location = new System.Drawing.Point(300, 125);
            this.comboBox_InstitutionManager.Name = "comboBox_InstitutionManager";
            this.comboBox_InstitutionManager.Size = new System.Drawing.Size(220, 23);
            this.comboBox_InstitutionManager.TabIndex = 108;
            // 
            // lblSelectInstitutionManager
            // 
            this.lblSelectInstitutionManager.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblSelectInstitutionManager.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelectInstitutionManager.Appearance.Options.UseFont = true;
            this.lblSelectInstitutionManager.Appearance.Options.UseForeColor = true;
            this.lblSelectInstitutionManager.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSelectInstitutionManager.Location = new System.Drawing.Point(300, 96);
            this.lblSelectInstitutionManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSelectInstitutionManager.Name = "lblSelectInstitutionManager";
            this.lblSelectInstitutionManager.Size = new System.Drawing.Size(162, 19);
            this.lblSelectInstitutionManager.TabIndex = 107;
            this.lblSelectInstitutionManager.Text = "Kurum Müdürü Seçimi (*)";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblCourseTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblCourseTitle.Appearance.Options.UseFont = true;
            this.lblCourseTitle.Appearance.Options.UseForeColor = true;
            this.lblCourseTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblCourseTitle.Location = new System.Drawing.Point(22, 24);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(94, 19);
            this.lblCourseTitle.TabIndex = 106;
            this.lblCourseTitle.Text = "Kurum İsmi (*)";
            // 
            // txtInstitutionName
            // 
            this.txtInstitutionName.EditValue = "";
            this.txtInstitutionName.Location = new System.Drawing.Point(22, 49);
            this.txtInstitutionName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInstitutionName.Name = "txtInstitutionName";
            this.txtInstitutionName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtInstitutionName.Properties.Appearance.Options.UseBackColor = true;
            this.txtInstitutionName.Properties.AutoHeight = false;
            this.txtInstitutionName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtInstitutionName.Properties.Mask.EditMask = ".+";
            this.txtInstitutionName.Properties.NullValuePrompt = "İsim";
            this.txtInstitutionName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtInstitutionName.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtInstitutionName.Size = new System.Drawing.Size(220, 23);
            this.txtInstitutionName.TabIndex = 105;
            // 
            // AddInstitution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "AddInstitution";
            this.Size = new System.Drawing.Size(841, 608);
            this.Load += new System.EventHandler(this.AddInstitution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInstitutionName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblPageOfCreatingInstitution;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtAddress;
        private DevExpress.XtraEditors.TextEdit txtContactNumber;
        private DevExpress.XtraEditors.LabelControl lblContactNumber;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblInstitutionAddress;
        private DevExpress.XtraEditors.SimpleButton btnCreateInstitution;
        private System.Windows.Forms.ComboBox comboBox_InstitutionManager;
        private DevExpress.XtraEditors.LabelControl lblSelectInstitutionManager;
        private DevExpress.XtraEditors.LabelControl lblCourseTitle;
        private DevExpress.XtraEditors.TextEdit txtInstitutionName;
    }
}
