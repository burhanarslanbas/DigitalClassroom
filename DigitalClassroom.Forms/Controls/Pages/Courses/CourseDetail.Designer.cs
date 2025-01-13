namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    partial class CourseDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseDetail));
            this.btnViewAnnouncementDetail = new DevExpress.XtraEditors.SimpleButton();
            this.lblInstitutionAndTeacher = new DevExpress.XtraEditors.LabelControl();
            this.lblCourseTitle = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridControlAnnouncements = new DevExpress.XtraGrid.GridControl();
            this.announcementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridAnnouncements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstitution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.announcementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.imageEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gridControlAssignments = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAssignments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitalClassroomDBDataSet = new DigitalClassroom.Forms.DigitalClassroomDBDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.assignmentsTableAdapter = new DigitalClassroom.Forms.DigitalClassroomDBDataSetTableAdapters.AssignmentsTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.btnCreateAssignment = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewAssignmentDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewStudentSubmissions = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnViewStudents = new DevExpress.XtraEditors.SimpleButton();
            this.lblAssignmentMessage = new DevExpress.XtraEditors.LabelControl();
            this.lblAnnouncementMessage = new DevExpress.XtraEditors.LabelControl();
            this.btnEditCourse = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnnouncements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnnouncements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalClassroomDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAnnouncementDetail
            // 
            this.btnViewAnnouncementDetail.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewAnnouncementDetail.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewAnnouncementDetail.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewAnnouncementDetail.Appearance.Options.UseBackColor = true;
            this.btnViewAnnouncementDetail.Appearance.Options.UseFont = true;
            this.btnViewAnnouncementDetail.Appearance.Options.UseForeColor = true;
            this.btnViewAnnouncementDetail.Location = new System.Drawing.Point(691, 123);
            this.btnViewAnnouncementDetail.Margin = new System.Windows.Forms.Padding(20);
            this.btnViewAnnouncementDetail.Name = "btnViewAnnouncementDetail";
            this.btnViewAnnouncementDetail.Size = new System.Drawing.Size(174, 32);
            this.btnViewAnnouncementDetail.TabIndex = 61;
            this.btnViewAnnouncementDetail.Text = "Seçilen Duyurunun Detayını Gör";
            this.btnViewAnnouncementDetail.Click += new System.EventHandler(this.btnCreateCourse_Click);
            // 
            // lblInstitutionAndTeacher
            // 
            this.lblInstitutionAndTeacher.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 14F);
            this.lblInstitutionAndTeacher.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstitutionAndTeacher.Appearance.Options.UseFont = true;
            this.lblInstitutionAndTeacher.Appearance.Options.UseForeColor = true;
            this.lblInstitutionAndTeacher.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblInstitutionAndTeacher.Location = new System.Drawing.Point(59, 9);
            this.lblInstitutionAndTeacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblInstitutionAndTeacher.Name = "lblInstitutionAndTeacher";
            this.lblInstitutionAndTeacher.Size = new System.Drawing.Size(282, 23);
            this.lblInstitutionAndTeacher.TabIndex = 56;
            this.lblInstitutionAndTeacher.Text = "{INSTITUTION} - {TEACHER FULL NAME}";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCourseTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblCourseTitle.Appearance.Options.UseFont = true;
            this.lblCourseTitle.Appearance.Options.UseForeColor = true;
            this.lblCourseTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblCourseTitle.Location = new System.Drawing.Point(59, 10);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(127, 25);
            this.lblCourseTitle.TabIndex = 55;
            this.lblCourseTitle.Text = "{COURSE TITLE}";
            // 
            // gridControlAnnouncements
            // 
            this.gridControlAnnouncements.DataSource = this.announcementBindingSource;
            this.gridControlAnnouncements.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlAnnouncements.Location = new System.Drawing.Point(13, 166);
            this.gridControlAnnouncements.MainView = this.gridAnnouncements;
            this.gridControlAnnouncements.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlAnnouncements.Name = "gridControlAnnouncements";
            this.gridControlAnnouncements.Size = new System.Drawing.Size(1014, 231);
            this.gridControlAnnouncements.TabIndex = 62;
            this.gridControlAnnouncements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAnnouncements});
            // 
            // announcementBindingSource
            // 
            this.announcementBindingSource.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.Announcement);
            // 
            // gridAnnouncements
            // 
            this.gridAnnouncements.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCourse,
            this.colInstitution,
            this.colTitle,
            this.colMessage,
            this.colCreatedAt});
            this.gridAnnouncements.DetailHeight = 404;
            this.gridAnnouncements.GridControl = this.gridControlAnnouncements;
            this.gridAnnouncements.Name = "gridAnnouncements";
            this.gridAnnouncements.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridAnnouncements.OptionsBehavior.Editable = false;
            this.gridAnnouncements.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridAnnouncements.OptionsFind.AlwaysVisible = true;
            // 
            // colId
            // 
            this.colId.Caption = "Duyuru ID";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 27;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 87;
            // 
            // colCourse
            // 
            this.colCourse.Caption = "Kurs Adı";
            this.colCourse.FieldName = "Course.Title";
            this.colCourse.MinWidth = 27;
            this.colCourse.Name = "colCourse";
            this.colCourse.Visible = true;
            this.colCourse.VisibleIndex = 1;
            this.colCourse.Width = 87;
            // 
            // colInstitution
            // 
            this.colInstitution.Caption = "İlgili Kurum";
            this.colInstitution.FieldName = "Institution.Name";
            this.colInstitution.MinWidth = 23;
            this.colInstitution.Name = "colInstitution";
            this.colInstitution.Visible = true;
            this.colInstitution.VisibleIndex = 2;
            this.colInstitution.Width = 87;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Duyuru Başlığı";
            this.colTitle.FieldName = "Title";
            this.colTitle.MinWidth = 27;
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 3;
            this.colTitle.Width = 87;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Duyuru Mesajı";
            this.colMessage.FieldName = "Message";
            this.colMessage.MinWidth = 27;
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 4;
            this.colMessage.Width = 87;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.Caption = "Oluşturulma Tarihi";
            this.colCreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.MinWidth = 27;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 5;
            this.colCreatedAt.Width = 87;
            // 
            // announcementsBindingSource
            // 
            this.announcementsBindingSource.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.Announcement);
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
            // imageEdit1
            // 
            this.imageEdit1.EditValue = ((object)(resources.GetObject("imageEdit1.EditValue")));
            this.imageEdit1.Location = new System.Drawing.Point(6, 4);
            this.imageEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imageEdit1.Name = "imageEdit1";
            this.imageEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imageEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.imageEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.imageEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imageEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.imageEdit1.Size = new System.Drawing.Size(28, 32);
            this.imageEdit1.TabIndex = 67;
            this.imageEdit1.TabStop = true;
            // 
            // gridControlAssignments
            // 
            this.gridControlAssignments.DataSource = this.bindingSource1;
            this.gridControlAssignments.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlAssignments.Location = new System.Drawing.Point(13, 466);
            this.gridControlAssignments.MainView = this.gridViewAssignments;
            this.gridControlAssignments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlAssignments.Name = "gridControlAssignments";
            this.gridControlAssignments.Size = new System.Drawing.Size(1014, 231);
            this.gridControlAssignments.TabIndex = 68;
            this.gridControlAssignments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAssignments});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.Assignment);
            // 
            // gridViewAssignments
            // 
            this.gridViewAssignments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colDescription,
            this.colCreatedDate,
            this.colDueDate});
            this.gridViewAssignments.DetailHeight = 404;
            this.gridViewAssignments.GridControl = this.gridControlAssignments;
            this.gridViewAssignments.Name = "gridViewAssignments";
            this.gridViewAssignments.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewAssignments.OptionsBehavior.Editable = false;
            this.gridViewAssignments.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewAssignments.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ödev Başlığı";
            this.gridColumn2.FieldName = "Title";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 87;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.Caption = "Oluşturulma Tarihi";
            this.colCreatedDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 2;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Teslim Tarihi";
            this.colDueDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 3;
            // 
            // assignmentsBindingSource
            // 
            this.assignmentsBindingSource.DataMember = "Assignments";
            this.assignmentsBindingSource.DataSource = this.digitalClassroomDBDataSet;
            // 
            // digitalClassroomDBDataSet
            // 
            this.digitalClassroomDBDataSet.DataSetName = "DigitalClassroomDBDataSet";
            this.digitalClassroomDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(39, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 21);
            this.labelControl1.TabIndex = 69;
            this.labelControl1.Text = "Sınıf Duyuruları";
            // 
            // assignmentsTableAdapter
            // 
            this.assignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.Location = new System.Drawing.Point(39, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 21);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Tüm Ödevler";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(2, 5);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(33, 32);
            this.pictureEdit3.TabIndex = 70;
            this.pictureEdit3.TabStop = true;
            // 
            // btnCreateAssignment
            // 
            this.btnCreateAssignment.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateAssignment.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateAssignment.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateAssignment.Appearance.Options.UseBackColor = true;
            this.btnCreateAssignment.Appearance.Options.UseFont = true;
            this.btnCreateAssignment.Appearance.Options.UseForeColor = true;
            this.btnCreateAssignment.Location = new System.Drawing.Point(921, 426);
            this.btnCreateAssignment.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateAssignment.Name = "btnCreateAssignment";
            this.btnCreateAssignment.Size = new System.Drawing.Size(106, 32);
            this.btnCreateAssignment.TabIndex = 72;
            this.btnCreateAssignment.Text = "Ödev Oluştur";
            this.btnCreateAssignment.Click += new System.EventHandler(this.btnCreateAssignment_Click);
            // 
            // btnViewAssignmentDetail
            // 
            this.btnViewAssignmentDetail.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewAssignmentDetail.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewAssignmentDetail.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewAssignmentDetail.Appearance.Options.UseBackColor = true;
            this.btnViewAssignmentDetail.Appearance.Options.UseFont = true;
            this.btnViewAssignmentDetail.Appearance.Options.UseForeColor = true;
            this.btnViewAssignmentDetail.Location = new System.Drawing.Point(841, 703);
            this.btnViewAssignmentDetail.Margin = new System.Windows.Forms.Padding(20);
            this.btnViewAssignmentDetail.Name = "btnViewAssignmentDetail";
            this.btnViewAssignmentDetail.Size = new System.Drawing.Size(186, 32);
            this.btnViewAssignmentDetail.TabIndex = 73;
            this.btnViewAssignmentDetail.Text = "Seçilen Ödevin Detayını Görüntüle";
            this.btnViewAssignmentDetail.Click += new System.EventHandler(this.btnViewAssignmentDetail_Click);
            // 
            // btnViewStudentSubmissions
            // 
            this.btnViewStudentSubmissions.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewStudentSubmissions.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewStudentSubmissions.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewStudentSubmissions.Appearance.Options.UseBackColor = true;
            this.btnViewStudentSubmissions.Appearance.Options.UseFont = true;
            this.btnViewStudentSubmissions.Appearance.Options.UseForeColor = true;
            this.btnViewStudentSubmissions.Location = new System.Drawing.Point(629, 703);
            this.btnViewStudentSubmissions.Margin = new System.Windows.Forms.Padding(20);
            this.btnViewStudentSubmissions.Name = "btnViewStudentSubmissions";
            this.btnViewStudentSubmissions.Size = new System.Drawing.Size(206, 32);
            this.btnViewStudentSubmissions.TabIndex = 74;
            this.btnViewStudentSubmissions.Text = "Seçilen Ödevin Teslimlerini Görüntüle";
            this.btnViewStudentSubmissions.Click += new System.EventHandler(this.btnViewStudentSubmissions_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.pictureEdit3);
            this.panelControl1.Location = new System.Drawing.Point(15, 419);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(128, 41);
            this.panelControl1.TabIndex = 76;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.imageEdit1);
            this.panelControl2.Location = new System.Drawing.Point(13, 119);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(151, 41);
            this.panelControl2.TabIndex = 77;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.pictureEdit2);
            this.panelControl3.Controls.Add(this.lblInstitutionAndTeacher);
            this.panelControl3.Location = new System.Drawing.Point(13, 62);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1014, 44);
            this.panelControl3.TabIndex = 79;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.btnEditCourse);
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Controls.Add(this.lblCourseTitle);
            this.panelControl4.Location = new System.Drawing.Point(13, 12);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1014, 44);
            this.panelControl4.TabIndex = 80;
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewStudents.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewStudents.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewStudents.Appearance.Options.UseBackColor = true;
            this.btnViewStudents.Appearance.Options.UseFont = true;
            this.btnViewStudents.Appearance.Options.UseForeColor = true;
            this.btnViewStudents.Location = new System.Drawing.Point(870, 123);
            this.btnViewStudents.Margin = new System.Windows.Forms.Padding(20);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(157, 32);
            this.btnViewStudents.TabIndex = 81;
            this.btnViewStudents.Text = "Öğrenci Listesini Görüntüle";
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // lblAssignmentMessage
            // 
            this.lblAssignmentMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAssignmentMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAssignmentMessage.Appearance.Options.UseFont = true;
            this.lblAssignmentMessage.Appearance.Options.UseForeColor = true;
            this.lblAssignmentMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblAssignmentMessage.Location = new System.Drawing.Point(149, 426);
            this.lblAssignmentMessage.Name = "lblAssignmentMessage";
            this.lblAssignmentMessage.Size = new System.Drawing.Size(60, 25);
            this.lblAssignmentMessage.TabIndex = 83;
            this.lblAssignmentMessage.Text = "{Mesaj}";
            this.lblAssignmentMessage.Visible = false;
            // 
            // lblAnnouncementMessage
            // 
            this.lblAnnouncementMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnnouncementMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAnnouncementMessage.Appearance.Options.UseFont = true;
            this.lblAnnouncementMessage.Appearance.Options.UseForeColor = true;
            this.lblAnnouncementMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblAnnouncementMessage.Location = new System.Drawing.Point(170, 126);
            this.lblAnnouncementMessage.Name = "lblAnnouncementMessage";
            this.lblAnnouncementMessage.Size = new System.Drawing.Size(60, 25);
            this.lblAnnouncementMessage.TabIndex = 84;
            this.lblAnnouncementMessage.Text = "{Mesaj}";
            this.lblAnnouncementMessage.Visible = false;
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
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // CourseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAnnouncementMessage);
            this.Controls.Add(this.lblAssignmentMessage);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnViewStudentSubmissions);
            this.Controls.Add(this.btnViewAssignmentDetail);
            this.Controls.Add(this.btnCreateAssignment);
            this.Controls.Add(this.gridControlAssignments);
            this.Controls.Add(this.gridControlAnnouncements);
            this.Controls.Add(this.btnViewAnnouncementDetail);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CourseDetail";
            this.Size = new System.Drawing.Size(1168, 789);
            this.Load += new System.EventHandler(this.CourseDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnnouncements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnnouncements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalClassroomDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnViewAnnouncementDetail;
        private DevExpress.XtraEditors.LabelControl lblInstitutionAndTeacher;
        private DevExpress.XtraEditors.LabelControl lblCourseTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.GridControl gridControlAnnouncements;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAnnouncements;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse;
        private DevExpress.XtraGrid.Columns.GridColumn colInstitution;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.Data.UnboundSource unboundSource1;
        private System.Windows.Forms.BindingSource announcementsBindingSource;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit imageEdit1;
        private System.Windows.Forms.BindingSource announcementBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlAssignments;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource assignmentsBindingSource;
        private DigitalClassroomDBDataSet digitalClassroomDBDataSet;
        private DigitalClassroomDBDataSetTableAdapters.AssignmentsTableAdapter assignmentsTableAdapter;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAssignments;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.SimpleButton btnCreateAssignment;
        private DevExpress.XtraEditors.SimpleButton btnViewAssignmentDetail;
        private DevExpress.XtraEditors.SimpleButton btnViewStudentSubmissions;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnViewStudents;
        private DevExpress.XtraEditors.LabelControl lblAssignmentMessage;
        private DevExpress.XtraEditors.LabelControl lblAnnouncementMessage;
        private DevExpress.XtraEditors.SimpleButton btnEditCourse;
    }
}
