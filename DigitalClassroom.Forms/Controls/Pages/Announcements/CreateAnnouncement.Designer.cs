namespace DigitalClassroom.Forms.Controls.Pages.Announcements
{
    partial class CreateAnnouncement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnnouncement));
            this.lblPageOfCreatingAnnouncement = new DevExpress.XtraEditors.LabelControl();
            this.btnCreateAnnouncement = new DevExpress.XtraEditors.SimpleButton();
            this.txtMessage = new DevExpress.XtraEditors.TextEdit();
            this.institutionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.lblAnnouncementMessage = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imageEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.comboBox_Courses = new System.Windows.Forms.ComboBox();
            this.lblSelectCourse = new DevExpress.XtraEditors.LabelControl();
            this.comboBox_Institutions = new System.Windows.Forms.ComboBox();
            this.lblSelectInstitution = new DevExpress.XtraEditors.LabelControl();
            this.lblAnnouncementTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageOfCreatingAnnouncement
            // 
            this.lblPageOfCreatingAnnouncement.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageOfCreatingAnnouncement.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageOfCreatingAnnouncement.Appearance.Options.UseFont = true;
            this.lblPageOfCreatingAnnouncement.Appearance.Options.UseForeColor = true;
            this.lblPageOfCreatingAnnouncement.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPageOfCreatingAnnouncement.Location = new System.Drawing.Point(52, 10);
            this.lblPageOfCreatingAnnouncement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPageOfCreatingAnnouncement.Name = "lblPageOfCreatingAnnouncement";
            this.lblPageOfCreatingAnnouncement.Size = new System.Drawing.Size(246, 29);
            this.lblPageOfCreatingAnnouncement.TabIndex = 31;
            this.lblPageOfCreatingAnnouncement.Text = "Duyuru Oluşturma Sayfası";
            // 
            // btnCreateAnnouncement
            // 
            this.btnCreateAnnouncement.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateAnnouncement.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateAnnouncement.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateAnnouncement.Appearance.Options.UseBackColor = true;
            this.btnCreateAnnouncement.Appearance.Options.UseFont = true;
            this.btnCreateAnnouncement.Appearance.Options.UseForeColor = true;
            this.btnCreateAnnouncement.Location = new System.Drawing.Point(11, 461);
            this.btnCreateAnnouncement.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            this.btnCreateAnnouncement.Size = new System.Drawing.Size(91, 25);
            this.btnCreateAnnouncement.TabIndex = 27;
            this.btnCreateAnnouncement.Text = "Oluştur";
            this.btnCreateAnnouncement.Click += new System.EventHandler(this.btnCreateAnnouncement_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.EditValue = "";
            this.txtMessage.Location = new System.Drawing.Point(8, 49);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.Properties.Appearance.Options.UseBackColor = true;
            this.txtMessage.Properties.AutoHeight = false;
            this.txtMessage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMessage.Properties.Mask.EditMask = ".+";
            this.txtMessage.Properties.NullText = "Duyuru Başlığı";
            this.txtMessage.Properties.NullValuePrompt = "Duyuru Başlığı";
            this.txtMessage.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMessage.Size = new System.Drawing.Size(459, 217);
            this.txtMessage.TabIndex = 33;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.pictureEdit3);
            this.panelControl4.Controls.Add(this.lblAnnouncementMessage);
            this.panelControl4.Controls.Add(this.txtMessage);
            this.panelControl4.Location = new System.Drawing.Point(11, 172);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(473, 280);
            this.panelControl4.TabIndex = 84;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(8, 5);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit3.Size = new System.Drawing.Size(37, 38);
            this.pictureEdit3.TabIndex = 68;
            this.pictureEdit3.TabStop = true;
            // 
            // lblAnnouncementMessage
            // 
            this.lblAnnouncementMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnnouncementMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAnnouncementMessage.Appearance.Options.UseFont = true;
            this.lblAnnouncementMessage.Appearance.Options.UseForeColor = true;
            this.lblAnnouncementMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblAnnouncementMessage.LineVisible = true;
            this.lblAnnouncementMessage.Location = new System.Drawing.Point(52, 11);
            this.lblAnnouncementMessage.Name = "lblAnnouncementMessage";
            this.lblAnnouncementMessage.Size = new System.Drawing.Size(110, 27);
            this.lblAnnouncementMessage.TabIndex = 65;
            this.lblAnnouncementMessage.Text = "Duyuru Mesajı";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.imageEdit1);
            this.panelControl1.Controls.Add(this.lblPageOfCreatingAnnouncement);
            this.panelControl1.Location = new System.Drawing.Point(11, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(816, 49);
            this.panelControl1.TabIndex = 85;
            // 
            // imageEdit1
            // 
            this.imageEdit1.EditValue = ((object)(resources.GetObject("imageEdit1.EditValue")));
            this.imageEdit1.Location = new System.Drawing.Point(5, 6);
            this.imageEdit1.Name = "imageEdit1";
            this.imageEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imageEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.imageEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.imageEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imageEdit1.Size = new System.Drawing.Size(40, 37);
            this.imageEdit1.TabIndex = 61;
            this.imageEdit1.TabStop = true;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.comboBox_Courses);
            this.panelControl2.Controls.Add(this.lblSelectCourse);
            this.panelControl2.Controls.Add(this.comboBox_Institutions);
            this.panelControl2.Controls.Add(this.lblSelectInstitution);
            this.panelControl2.Controls.Add(this.lblAnnouncementTitle);
            this.panelControl2.Controls.Add(this.txtTitle);
            this.panelControl2.Location = new System.Drawing.Point(11, 74);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(816, 85);
            this.panelControl2.TabIndex = 86;
            // 
            // comboBox_Courses
            // 
            this.comboBox_Courses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Courses.FormattingEnabled = true;
            this.comboBox_Courses.Items.AddRange(new object[] {
            "Tüm Kurslar"});
            this.comboBox_Courses.Location = new System.Drawing.Point(293, 39);
            this.comboBox_Courses.Name = "comboBox_Courses";
            this.comboBox_Courses.Size = new System.Drawing.Size(220, 23);
            this.comboBox_Courses.TabIndex = 45;
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblSelectCourse.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelectCourse.Appearance.Options.UseFont = true;
            this.lblSelectCourse.Appearance.Options.UseForeColor = true;
            this.lblSelectCourse.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSelectCourse.Location = new System.Drawing.Point(293, 14);
            this.lblSelectCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(76, 19);
            this.lblSelectCourse.TabIndex = 44;
            this.lblSelectCourse.Text = "Kurs Seçimi";
            // 
            // comboBox_Institutions
            // 
            this.comboBox_Institutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Institutions.FormattingEnabled = true;
            this.comboBox_Institutions.Items.AddRange(new object[] {
            "Tüm Kurumlar"});
            this.comboBox_Institutions.Location = new System.Drawing.Point(576, 39);
            this.comboBox_Institutions.Name = "comboBox_Institutions";
            this.comboBox_Institutions.Size = new System.Drawing.Size(220, 23);
            this.comboBox_Institutions.TabIndex = 43;
            this.comboBox_Institutions.Visible = false;
            // 
            // lblSelectInstitution
            // 
            this.lblSelectInstitution.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblSelectInstitution.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelectInstitution.Appearance.Options.UseFont = true;
            this.lblSelectInstitution.Appearance.Options.UseForeColor = true;
            this.lblSelectInstitution.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSelectInstitution.Location = new System.Drawing.Point(576, 14);
            this.lblSelectInstitution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSelectInstitution.Name = "lblSelectInstitution";
            this.lblSelectInstitution.Size = new System.Drawing.Size(89, 19);
            this.lblSelectInstitution.TabIndex = 42;
            this.lblSelectInstitution.Text = "Kurum Seçimi";
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblAnnouncementTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAnnouncementTitle.Appearance.Options.UseFont = true;
            this.lblAnnouncementTitle.Appearance.Options.UseForeColor = true;
            this.lblAnnouncementTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(10, 14);
            this.lblAnnouncementTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(94, 19);
            this.lblAnnouncementTitle.TabIndex = 41;
            this.lblAnnouncementTitle.Text = "Duyuru Başlığı";
            // 
            // txtTitle
            // 
            this.txtTitle.EditValue = "";
            this.txtTitle.Location = new System.Drawing.Point(10, 39);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTitle.Properties.Appearance.Options.UseBackColor = true;
            this.txtTitle.Properties.AutoHeight = false;
            this.txtTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTitle.Properties.Mask.EditMask = ".+";
            this.txtTitle.Properties.NullText = "Duyuru Başlığı";
            this.txtTitle.Properties.NullValuePrompt = "Duyuru Başlığı";
            this.txtTitle.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTitle.Size = new System.Drawing.Size(220, 23);
            this.txtTitle.TabIndex = 40;
            // 
            // CreateAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.btnCreateAnnouncement);
            this.Name = "CreateAnnouncement";
            this.Size = new System.Drawing.Size(841, 608);
            this.Load += new System.EventHandler(this.CreateAnnouncement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblPageOfCreatingAnnouncement;
        private DevExpress.XtraEditors.SimpleButton btnCreateAnnouncement;
        private DevExpress.XtraEditors.TextEdit txtMessage;
        private System.Windows.Forms.BindingSource institutionsBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl lblAnnouncementMessage;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit imageEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox comboBox_Courses;
        private DevExpress.XtraEditors.LabelControl lblSelectCourse;
        private System.Windows.Forms.ComboBox comboBox_Institutions;
        private DevExpress.XtraEditors.LabelControl lblSelectInstitution;
        private DevExpress.XtraEditors.LabelControl lblAnnouncementTitle;
        private DevExpress.XtraEditors.TextEdit txtTitle;
    }
}
