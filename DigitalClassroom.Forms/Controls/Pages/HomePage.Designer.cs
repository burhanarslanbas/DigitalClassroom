namespace DigitalClassroom.Forms.Controls.Pages.HomePage
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblGreetingMessage = new DevExpress.XtraEditors.LabelControl();
            this.gridControlAnnouncements = new DevExpress.XtraGrid.GridControl();
            this.gridAnnouncements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstitution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCourses = new DevExpress.XtraGrid.GridControl();
            this.cardCourses = new DevExpress.XtraGrid.Views.Card.CardView();
            this.cardColId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardColTeacherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardColTeacherSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnViewAnnouncement = new System.Windows.Forms.Button();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblCourseTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblCourseMessage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnnouncements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnnouncements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreetingMessage
            // 
            this.lblGreetingMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGreetingMessage.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblGreetingMessage.Appearance.Options.UseFont = true;
            this.lblGreetingMessage.Appearance.Options.UseForeColor = true;
            this.lblGreetingMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblGreetingMessage.Location = new System.Drawing.Point(67, 29);
            this.lblGreetingMessage.Name = "lblGreetingMessage";
            this.lblGreetingMessage.Size = new System.Drawing.Size(289, 24);
            this.lblGreetingMessage.TabIndex = 24;
            this.lblGreetingMessage.Text = "Merhaba {Ad}, Dijital Sınıfa Hoşgeldin!";
            // 
            // gridControlAnnouncements
            // 
            this.gridControlAnnouncements.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.Announcement);
            this.gridControlAnnouncements.Location = new System.Drawing.Point(23, 67);
            this.gridControlAnnouncements.MainView = this.gridAnnouncements;
            this.gridControlAnnouncements.Name = "gridControlAnnouncements";
            this.gridControlAnnouncements.Size = new System.Drawing.Size(869, 200);
            this.gridControlAnnouncements.TabIndex = 25;
            this.gridControlAnnouncements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAnnouncements});
            this.gridControlAnnouncements.Click += new System.EventHandler(this.gridControlAnnouncements_Click);
            // 
            // gridAnnouncements
            // 
            this.gridAnnouncements.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCourse,
            this.colInstitution,
            this.colTitle,
            this.colMessage,
            this.colCreatedAt,
            this.colUpdatedAt});
            this.gridAnnouncements.GridControl = this.gridControlAnnouncements;
            this.gridAnnouncements.Name = "gridAnnouncements";
            this.gridAnnouncements.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            this.colId.Caption = "Duyuru ID";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colCourse
            // 
            this.colCourse.Caption = "Kurs Adı";
            this.colCourse.FieldName = "Course.Title";
            this.colCourse.MinWidth = 23;
            this.colCourse.Name = "colCourse";
            this.colCourse.Visible = true;
            this.colCourse.VisibleIndex = 1;
            // 
            // colInstitution
            // 
            this.colInstitution.Caption = "İlgili Kurum";
            this.colInstitution.FieldName = "Institution.Name";
            this.colInstitution.Name = "colInstitution";
            this.colInstitution.Visible = true;
            this.colInstitution.VisibleIndex = 2;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Duyuru Başlığı";
            this.colTitle.FieldName = "Title";
            this.colTitle.MinWidth = 23;
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 3;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Duyuru Mesajı";
            this.colMessage.FieldName = "Message";
            this.colMessage.MinWidth = 23;
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 4;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.Caption = "Oluşturulma Tarihi";
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.MinWidth = 23;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 5;
            // 
            // colUpdatedAt
            // 
            this.colUpdatedAt.Caption = "Düzenlenme Tarihi";
            this.colUpdatedAt.FieldName = "UpdatedAt";
            this.colUpdatedAt.Name = "colUpdatedAt";
            this.colUpdatedAt.Visible = true;
            this.colUpdatedAt.VisibleIndex = 6;
            // 
            // gridControlCourses
            // 
            this.gridControlCourses.Location = new System.Drawing.Point(23, 325);
            this.gridControlCourses.MainView = this.cardCourses;
            this.gridControlCourses.Name = "gridControlCourses";
            this.gridControlCourses.Size = new System.Drawing.Size(869, 213);
            this.gridControlCourses.TabIndex = 26;
            this.gridControlCourses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardCourses});
            // 
            // cardCourses
            // 
            this.cardCourses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cardColId,
            this.cardColTeacherName,
            this.cardColTeacherSurname,
            this.cardColDescription});
            this.cardCourses.FocusedCardTopFieldIndex = 0;
            this.cardCourses.GridControl = this.gridControlCourses;
            this.cardCourses.Name = "cardCourses";
            this.cardCourses.OptionsBehavior.Editable = false;
            this.cardCourses.OptionsBehavior.ReadOnly = true;
            this.cardCourses.OptionsBehavior.Sizeable = false;
            this.cardCourses.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardCourses.CustomDrawCardCaption += new DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventHandler(this.cardCourses_CustomDrawCardCaption);
            // 
            // cardColId
            // 
            this.cardColId.Caption = "Kurs ID";
            this.cardColId.FieldName = "Id";
            this.cardColId.Name = "cardColId";
            this.cardColId.Visible = true;
            this.cardColId.VisibleIndex = 0;
            // 
            // cardColTeacherName
            // 
            this.cardColTeacherName.Caption = "Öğretmen Adı";
            this.cardColTeacherName.FieldName = "Teacher.Name";
            this.cardColTeacherName.Name = "cardColTeacherName";
            this.cardColTeacherName.Visible = true;
            this.cardColTeacherName.VisibleIndex = 1;
            // 
            // cardColTeacherSurname
            // 
            this.cardColTeacherSurname.Caption = "Soyadı";
            this.cardColTeacherSurname.FieldName = "Teacher.Surname";
            this.cardColTeacherSurname.Name = "cardColTeacherSurname";
            this.cardColTeacherSurname.Visible = true;
            this.cardColTeacherSurname.VisibleIndex = 2;
            // 
            // cardColDescription
            // 
            this.cardColDescription.Caption = "Açıklama";
            this.cardColDescription.FieldName = "Description";
            this.cardColDescription.Name = "cardColDescription";
            this.cardColDescription.Visible = true;
            this.cardColDescription.VisibleIndex = 3;
            // 
            // btnViewAnnouncement
            // 
            this.btnViewAnnouncement.Location = new System.Drawing.Point(713, 27);
            this.btnViewAnnouncement.Name = "btnViewAnnouncement";
            this.btnViewAnnouncement.Size = new System.Drawing.Size(179, 34);
            this.btnViewAnnouncement.TabIndex = 27;
            this.btnViewAnnouncement.Text = "Seçilen Duyuruyu Görüntüle";
            this.btnViewAnnouncement.UseVisualStyleBackColor = true;
            this.btnViewAnnouncement.Click += new System.EventHandler(this.btnViewAnnouncement_Click);
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Location = new System.Drawing.Point(713, 285);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(179, 34);
            this.btnViewCourse.TabIndex = 28;
            this.btnViewCourse.Text = "Seçilen Kursu Görüntüle";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(23, 23);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(37, 38);
            this.pictureEdit2.TabIndex = 67;
            this.pictureEdit2.TabStop = true;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Controls.Add(this.lblCourseTitle);
            this.panelControl4.Location = new System.Drawing.Point(23, 281);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(147, 38);
            this.panelControl4.TabIndex = 81;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 29);
            this.pictureEdit1.TabIndex = 65;
            this.pictureEdit1.TabStop = true;
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourseTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblCourseTitle.Appearance.Options.UseFont = true;
            this.lblCourseTitle.Appearance.Options.UseForeColor = true;
            this.lblCourseTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblCourseTitle.Location = new System.Drawing.Point(44, 8);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(90, 25);
            this.lblCourseTitle.TabIndex = 55;
            this.lblCourseTitle.Text = "Kurslarınız";
            // 
            // lblCourseMessage
            // 
            this.lblCourseMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourseMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblCourseMessage.Appearance.Options.UseFont = true;
            this.lblCourseMessage.Appearance.Options.UseForeColor = true;
            this.lblCourseMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblCourseMessage.Location = new System.Drawing.Point(176, 288);
            this.lblCourseMessage.Name = "lblCourseMessage";
            this.lblCourseMessage.Size = new System.Drawing.Size(60, 25);
            this.lblCourseMessage.TabIndex = 82;
            this.lblCourseMessage.Text = "{Mesaj}";
            this.lblCourseMessage.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCourseMessage);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.btnViewAnnouncement);
            this.Controls.Add(this.gridControlCourses);
            this.Controls.Add(this.gridControlAnnouncements);
            this.Controls.Add(this.lblGreetingMessage);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1429, 702);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnnouncements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnnouncements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblGreetingMessage;
        private DevExpress.XtraGrid.GridControl gridControlAnnouncements;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAnnouncements;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colInstitution;
        private DevExpress.XtraGrid.GridControl gridControlCourses;
        private DevExpress.XtraGrid.Views.Card.CardView cardCourses;
        private DevExpress.XtraGrid.Columns.GridColumn cardColId;
        private DevExpress.XtraGrid.Columns.GridColumn cardColTeacherName;
        private System.Windows.Forms.Button btnViewAnnouncement;
        private System.Windows.Forms.Button btnViewCourse;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblCourseTitle;
        private DevExpress.XtraEditors.LabelControl lblCourseMessage;
        private DevExpress.XtraGrid.Columns.GridColumn cardColTeacherSurname;
        private DevExpress.XtraGrid.Columns.GridColumn cardColDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedAt;
    }
}
