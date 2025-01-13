namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    partial class CreateCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCourse));
            this.comboBox_Institutions = new System.Windows.Forms.ComboBox();
            this.lblSelectInstitution = new DevExpress.XtraEditors.LabelControl();
            this.lblPageOfCreatingCourse = new DevExpress.XtraEditors.LabelControl();
            this.comboBox_Teachers = new System.Windows.Forms.ComboBox();
            this.lblSelectTeacher = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditCourse = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCreateCourse = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtCapacityOfCourse = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblCourseTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtCourseTitle = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacityOfCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Institutions
            // 
            this.comboBox_Institutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Institutions.FormattingEnabled = true;
            this.comboBox_Institutions.Items.AddRange(new object[] {
            "<Tüm Öğretmenleri Listele>",
            "Bireysel"});
            this.comboBox_Institutions.Location = new System.Drawing.Point(356, 49);
            this.comboBox_Institutions.Name = "comboBox_Institutions";
            this.comboBox_Institutions.Size = new System.Drawing.Size(220, 23);
            this.comboBox_Institutions.TabIndex = 42;
            this.comboBox_Institutions.Visible = false;
            this.comboBox_Institutions.SelectedIndexChanged += new System.EventHandler(this.comboBox_Institutions_SelectedIndexChanged);
            // 
            // lblSelectInstitution
            // 
            this.lblSelectInstitution.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblSelectInstitution.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelectInstitution.Appearance.Options.UseFont = true;
            this.lblSelectInstitution.Appearance.Options.UseForeColor = true;
            this.lblSelectInstitution.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSelectInstitution.Location = new System.Drawing.Point(356, 24);
            this.lblSelectInstitution.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSelectInstitution.Name = "lblSelectInstitution";
            this.lblSelectInstitution.Size = new System.Drawing.Size(89, 19);
            this.lblSelectInstitution.TabIndex = 41;
            this.lblSelectInstitution.Text = "Kurum Seçimi";
            this.lblSelectInstitution.Visible = false;
            // 
            // lblPageOfCreatingCourse
            // 
            this.lblPageOfCreatingCourse.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageOfCreatingCourse.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageOfCreatingCourse.Appearance.Options.UseFont = true;
            this.lblPageOfCreatingCourse.Appearance.Options.UseForeColor = true;
            this.lblPageOfCreatingCourse.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPageOfCreatingCourse.Location = new System.Drawing.Point(51, 7);
            this.lblPageOfCreatingCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPageOfCreatingCourse.Name = "lblPageOfCreatingCourse";
            this.lblPageOfCreatingCourse.Size = new System.Drawing.Size(222, 29);
            this.lblPageOfCreatingCourse.TabIndex = 39;
            this.lblPageOfCreatingCourse.Text = "Kurs Oluşturma Sayfası";
            // 
            // comboBox_Teachers
            // 
            this.comboBox_Teachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Teachers.FormattingEnabled = true;
            this.comboBox_Teachers.Location = new System.Drawing.Point(356, 114);
            this.comboBox_Teachers.Name = "comboBox_Teachers";
            this.comboBox_Teachers.Size = new System.Drawing.Size(220, 23);
            this.comboBox_Teachers.TabIndex = 44;
            this.comboBox_Teachers.Visible = false;
            this.comboBox_Teachers.SelectedIndexChanged += new System.EventHandler(this.comboBox_Teachers_SelectedIndexChanged);
            // 
            // lblSelectTeacher
            // 
            this.lblSelectTeacher.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblSelectTeacher.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSelectTeacher.Appearance.Options.UseFont = true;
            this.lblSelectTeacher.Appearance.Options.UseForeColor = true;
            this.lblSelectTeacher.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSelectTeacher.Location = new System.Drawing.Point(356, 89);
            this.lblSelectTeacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblSelectTeacher.Name = "lblSelectTeacher";
            this.lblSelectTeacher.Size = new System.Drawing.Size(128, 19);
            this.lblSelectTeacher.TabIndex = 43;
            this.lblSelectTeacher.Text = "Öğretmen Seçimi (*)";
            this.lblSelectTeacher.Visible = false;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.btnEditCourse);
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Controls.Add(this.lblPageOfCreatingCourse);
            this.panelControl4.Location = new System.Drawing.Point(21, 16);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(292, 44);
            this.panelControl4.TabIndex = 82;
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditCourse.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditCourse.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditCourse.Appearance.Options.UseBackColor = true;
            this.btnEditCourse.Appearance.Options.UseFont = true;
            this.btnEditCourse.Appearance.Options.UseForeColor = true;
            this.btnEditCourse.Location = new System.Drawing.Point(910, 6);
            this.btnEditCourse.Margin = new System.Windows.Forms.Padding(20);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(96, 32);
            this.btnEditCourse.TabIndex = 85;
            this.btnEditCourse.Text = "Kursu Düzenle";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(6, 5);
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
            this.panelControl1.Controls.Add(this.btnCreateCourse);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.lblDescription);
            this.panelControl1.Controls.Add(this.txtCapacityOfCourse);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblCourseTitle);
            this.panelControl1.Controls.Add(this.txtCourseTitle);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.lblSelectInstitution);
            this.panelControl1.Controls.Add(this.comboBox_Institutions);
            this.panelControl1.Controls.Add(this.lblSelectTeacher);
            this.panelControl1.Controls.Add(this.comboBox_Teachers);
            this.panelControl1.Location = new System.Drawing.Point(21, 83);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(657, 326);
            this.panelControl1.TabIndex = 83;
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateCourse.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCourse.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateCourse.Appearance.Options.UseBackColor = true;
            this.btnCreateCourse.Appearance.Options.UseFont = true;
            this.btnCreateCourse.Appearance.Options.UseForeColor = true;
            this.btnCreateCourse.Location = new System.Drawing.Point(20, 280);
            this.btnCreateCourse.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(91, 25);
            this.btnCreateCourse.TabIndex = 84;
            this.btnCreateCourse.Text = "Oluştur";
            this.btnCreateCourse.Click += new System.EventHandler(this.btnCreateCourse_Click_1);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(20, 181);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 87);
            this.txtDescription.TabIndex = 91;
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblDescription.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Appearance.Options.UseFont = true;
            this.lblDescription.Appearance.Options.UseForeColor = true;
            this.lblDescription.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblDescription.Location = new System.Drawing.Point(20, 156);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 19);
            this.lblDescription.TabIndex = 90;
            this.lblDescription.Text = "Açıklama (*)";
            // 
            // txtCapacityOfCourse
            // 
            this.txtCapacityOfCourse.EditValue = "";
            this.txtCapacityOfCourse.Location = new System.Drawing.Point(20, 118);
            this.txtCapacityOfCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCapacityOfCourse.Name = "txtCapacityOfCourse";
            this.txtCapacityOfCourse.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtCapacityOfCourse.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCapacityOfCourse.Properties.Appearance.Options.UseBackColor = true;
            this.txtCapacityOfCourse.Properties.AutoHeight = false;
            this.txtCapacityOfCourse.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCapacityOfCourse.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCapacityOfCourse.Properties.Mask.EditMask = "d";
            this.txtCapacityOfCourse.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCapacityOfCourse.Properties.MaxLength = 6;
            this.txtCapacityOfCourse.Properties.NullText = "Öğrenci Kapasitesi";
            this.txtCapacityOfCourse.Properties.NullValuePrompt = "Öğrenci Kapasitesi";
            this.txtCapacityOfCourse.Size = new System.Drawing.Size(220, 23);
            this.txtCapacityOfCourse.TabIndex = 89;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(20, 89);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 19);
            this.labelControl1.TabIndex = 88;
            this.labelControl1.Text = "Öğrenci Kapasitesi";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblCourseTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblCourseTitle.Appearance.Options.UseFont = true;
            this.lblCourseTitle.Appearance.Options.UseForeColor = true;
            this.lblCourseTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblCourseTitle.Location = new System.Drawing.Point(20, 24);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(98, 19);
            this.lblCourseTitle.TabIndex = 87;
            this.lblCourseTitle.Text = "Kurs Başlığı (*)";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.EditValue = "";
            this.txtCourseTitle.Location = new System.Drawing.Point(20, 49);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCourseTitle.Properties.Appearance.Options.UseBackColor = true;
            this.txtCourseTitle.Properties.AutoHeight = false;
            this.txtCourseTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCourseTitle.Properties.Mask.EditMask = ".+";
            this.txtCourseTitle.Properties.NullText = "Kurs Başlığı";
            this.txtCourseTitle.Properties.NullValuePrompt = "Kurs Başlığı";
            this.txtCourseTitle.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCourseTitle.Size = new System.Drawing.Size(220, 23);
            this.txtCourseTitle.TabIndex = 86;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(910, 6);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 32);
            this.simpleButton1.TabIndex = 85;
            this.simpleButton1.Text = "Kursu Düzenle";
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Name = "CreateCourse";
            this.Size = new System.Drawing.Size(841, 608);
            this.Load += new System.EventHandler(this.CreateCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacityOfCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseTitle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Institutions;
        private DevExpress.XtraEditors.LabelControl lblSelectInstitution;
        private DevExpress.XtraEditors.LabelControl lblPageOfCreatingCourse;
        private System.Windows.Forms.ComboBox comboBox_Teachers;
        private DevExpress.XtraEditors.LabelControl lblSelectTeacher;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnEditCourse;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreateCourse;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtCapacityOfCourse;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblCourseTitle;
        private DevExpress.XtraEditors.TextEdit txtCourseTitle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
