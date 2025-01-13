namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    partial class ViewStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudents));
            this.gridControlStudents = new DevExpress.XtraGrid.GridControl();
            this.gridViewStudents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblViewStudents = new DevExpress.XtraEditors.LabelControl();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblStudentMessage = new DevExpress.XtraEditors.LabelControl();
            this.btnChangeIsActiveStatus = new DevExpress.XtraEditors.SimpleButton();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlStudents
            // 
            this.gridControlStudents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlStudents.Location = new System.Drawing.Point(13, 78);
            this.gridControlStudents.MainView = this.gridViewStudents;
            this.gridControlStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlStudents.Name = "gridControlStudents";
            this.gridControlStudents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditUser});
            this.gridControlStudents.Size = new System.Drawing.Size(961, 419);
            this.gridControlStudents.TabIndex = 57;
            this.gridControlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStudents});
            // 
            // gridViewStudents
            // 
            this.gridViewStudents.GridControl = this.gridControlStudents;
            this.gridViewStudents.Name = "gridViewStudents";
            this.gridViewStudents.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewStudents.OptionsBehavior.Editable = false;
            this.gridViewStudents.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewStudents.OptionsFind.AlwaysVisible = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoHeight = false;
            this.btnEditUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)});
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.User);
            // 
            // lblViewStudents
            // 
            this.lblViewStudents.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblViewStudents.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblViewStudents.Appearance.Options.UseFont = true;
            this.lblViewStudents.Appearance.Options.UseForeColor = true;
            this.lblViewStudents.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblViewStudents.Location = new System.Drawing.Point(51, 8);
            this.lblViewStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblViewStudents.Name = "lblViewStudents";
            this.lblViewStudents.Size = new System.Drawing.Size(177, 25);
            this.lblViewStudents.TabIndex = 56;
            this.lblViewStudents.Text = "Öğrencileri Görüntüle";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.Course);
            // 
            // lblStudentMessage
            // 
            this.lblStudentMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblStudentMessage.Appearance.Options.UseFont = true;
            this.lblStudentMessage.Appearance.Options.UseForeColor = true;
            this.lblStudentMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblStudentMessage.Location = new System.Drawing.Point(259, 27);
            this.lblStudentMessage.Name = "lblStudentMessage";
            this.lblStudentMessage.Size = new System.Drawing.Size(60, 25);
            this.lblStudentMessage.TabIndex = 83;
            this.lblStudentMessage.Text = "{Mesaj}";
            this.lblStudentMessage.Visible = false;
            // 
            // btnChangeIsActiveStatus
            // 
            this.btnChangeIsActiveStatus.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnChangeIsActiveStatus.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeIsActiveStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeIsActiveStatus.Appearance.Options.UseBackColor = true;
            this.btnChangeIsActiveStatus.Appearance.Options.UseFont = true;
            this.btnChangeIsActiveStatus.Appearance.Options.UseForeColor = true;
            this.btnChangeIsActiveStatus.Location = new System.Drawing.Point(796, 31);
            this.btnChangeIsActiveStatus.Margin = new System.Windows.Forms.Padding(20);
            this.btnChangeIsActiveStatus.Name = "btnChangeIsActiveStatus";
            this.btnChangeIsActiveStatus.Size = new System.Drawing.Size(178, 31);
            this.btnChangeIsActiveStatus.TabIndex = 84;
            this.btnChangeIsActiveStatus.Text = "Seçilen öğrenciyi sınıftan çıkar";
            this.btnChangeIsActiveStatus.Click += new System.EventHandler(this.btnChangeIsActiveStatus_Click);
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.Enrollment);
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Controls.Add(this.lblViewStudents);
            this.panelControl4.Location = new System.Drawing.Point(13, 18);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(240, 44);
            this.panelControl4.TabIndex = 85;
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
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.btnChangeIsActiveStatus);
            this.Controls.Add(this.lblStudentMessage);
            this.Controls.Add(this.gridControlStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewStudents";
            this.Size = new System.Drawing.Size(1084, 755);
            this.Load += new System.EventHandler(this.ViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudents;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditUser;
        private DevExpress.XtraEditors.LabelControl lblViewStudents;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DevExpress.XtraEditors.LabelControl lblStudentMessage;
        private DevExpress.XtraEditors.SimpleButton btnChangeIsActiveStatus;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
