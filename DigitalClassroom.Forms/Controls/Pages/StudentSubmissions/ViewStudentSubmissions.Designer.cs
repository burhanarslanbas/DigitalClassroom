namespace DigitalClassroom.Forms.Controls.Pages.StudentSubmissions
{
    partial class ViewStudentSubmissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentSubmissions));
            this.lblPageOfCreatingStudentSubmission = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.btnViewStudentSubmissionDetail = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlStudentSubmissions = new DevExpress.XtraGrid.GridControl();
            this.gridViewStudentSubmissions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblSubmissionMessage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudentSubmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudentSubmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageOfCreatingStudentSubmission
            // 
            this.lblPageOfCreatingStudentSubmission.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageOfCreatingStudentSubmission.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageOfCreatingStudentSubmission.Appearance.Options.UseFont = true;
            this.lblPageOfCreatingStudentSubmission.Appearance.Options.UseForeColor = true;
            this.lblPageOfCreatingStudentSubmission.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPageOfCreatingStudentSubmission.Location = new System.Drawing.Point(47, 8);
            this.lblPageOfCreatingStudentSubmission.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPageOfCreatingStudentSubmission.Name = "lblPageOfCreatingStudentSubmission";
            this.lblPageOfCreatingStudentSubmission.Size = new System.Drawing.Size(344, 29);
            this.lblPageOfCreatingStudentSubmission.TabIndex = 78;
            this.lblPageOfCreatingStudentSubmission.Text = "Ödev Teslimleri Görüntüleme Sayfası";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.lblPageOfCreatingStudentSubmission);
            this.panelControl1.Controls.Add(this.pictureEdit3);
            this.panelControl1.Location = new System.Drawing.Point(15, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(406, 45);
            this.panelControl1.TabIndex = 79;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(6, 5);
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
            // btnViewStudentSubmissionDetail
            // 
            this.btnViewStudentSubmissionDetail.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewStudentSubmissionDetail.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewStudentSubmissionDetail.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewStudentSubmissionDetail.Appearance.Options.UseBackColor = true;
            this.btnViewStudentSubmissionDetail.Appearance.Options.UseFont = true;
            this.btnViewStudentSubmissionDetail.Appearance.Options.UseForeColor = true;
            this.btnViewStudentSubmissionDetail.Location = new System.Drawing.Point(849, 311);
            this.btnViewStudentSubmissionDetail.Margin = new System.Windows.Forms.Padding(20);
            this.btnViewStudentSubmissionDetail.Name = "btnViewStudentSubmissionDetail";
            this.btnViewStudentSubmissionDetail.Size = new System.Drawing.Size(180, 32);
            this.btnViewStudentSubmissionDetail.TabIndex = 81;
            this.btnViewStudentSubmissionDetail.Text = "Seçilen Ödevi Detaylı Görüntüle";
            this.btnViewStudentSubmissionDetail.Visible = false;
            this.btnViewStudentSubmissionDetail.Click += new System.EventHandler(this.btnViewStudentSubmissionDetail_Click);
            // 
            // gridControlStudentSubmissions
            // 
            this.gridControlStudentSubmissions.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlStudentSubmissions.Location = new System.Drawing.Point(15, 74);
            this.gridControlStudentSubmissions.MainView = this.gridViewStudentSubmissions;
            this.gridControlStudentSubmissions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlStudentSubmissions.Name = "gridControlStudentSubmissions";
            this.gridControlStudentSubmissions.Size = new System.Drawing.Size(1014, 231);
            this.gridControlStudentSubmissions.TabIndex = 80;
            this.gridControlStudentSubmissions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStudentSubmissions});
            this.gridControlStudentSubmissions.Click += new System.EventHandler(this.gridControlAssignments_Click);
            // 
            // gridViewStudentSubmissions
            // 
            this.gridViewStudentSubmissions.DetailHeight = 404;
            this.gridViewStudentSubmissions.GridControl = this.gridControlStudentSubmissions;
            this.gridViewStudentSubmissions.Name = "gridViewStudentSubmissions";
            this.gridViewStudentSubmissions.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewStudentSubmissions.OptionsBehavior.Editable = false;
            this.gridViewStudentSubmissions.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewStudentSubmissions.OptionsFind.AlwaysVisible = true;
            // 
            // lblSubmissionMessage
            // 
            this.lblSubmissionMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubmissionMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubmissionMessage.Appearance.Options.UseFont = true;
            this.lblSubmissionMessage.Appearance.Options.UseForeColor = true;
            this.lblSubmissionMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSubmissionMessage.Location = new System.Drawing.Point(427, 24);
            this.lblSubmissionMessage.Name = "lblSubmissionMessage";
            this.lblSubmissionMessage.Size = new System.Drawing.Size(60, 25);
            this.lblSubmissionMessage.TabIndex = 84;
            this.lblSubmissionMessage.Text = "{Mesaj}";
            this.lblSubmissionMessage.Visible = false;
            // 
            // ViewStudentSubmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSubmissionMessage);
            this.Controls.Add(this.btnViewStudentSubmissionDetail);
            this.Controls.Add(this.gridControlStudentSubmissions);
            this.Controls.Add(this.panelControl1);
            this.Name = "ViewStudentSubmissions";
            this.Size = new System.Drawing.Size(1105, 755);
            this.Load += new System.EventHandler(this.ViewStudentSubmissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudentSubmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudentSubmissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblPageOfCreatingStudentSubmission;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.SimpleButton btnViewStudentSubmissionDetail;
        private DevExpress.XtraGrid.GridControl gridControlStudentSubmissions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudentSubmissions;
        private DevExpress.XtraEditors.LabelControl lblSubmissionMessage;
    }
}
