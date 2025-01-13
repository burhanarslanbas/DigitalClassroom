namespace DigitalClassroom.Forms.Controls.Pages.Courses
{
    partial class JoinCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinCourse));
            this.lblPageOfCreatingCourse = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.txtAttendanceCode = new DevExpress.XtraEditors.TextEdit();
            this.lblAttendanceCode = new DevExpress.XtraEditors.LabelControl();
            this.btnJoinCourse = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditCourse = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttendanceCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageOfCreatingCourse
            // 
            this.lblPageOfCreatingCourse.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageOfCreatingCourse.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageOfCreatingCourse.Appearance.Options.UseFont = true;
            this.lblPageOfCreatingCourse.Appearance.Options.UseForeColor = true;
            this.lblPageOfCreatingCourse.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPageOfCreatingCourse.Location = new System.Drawing.Point(41, 6);
            this.lblPageOfCreatingCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblPageOfCreatingCourse.Name = "lblPageOfCreatingCourse";
            this.lblPageOfCreatingCourse.Size = new System.Drawing.Size(182, 29);
            this.lblPageOfCreatingCourse.TabIndex = 42;
            this.lblPageOfCreatingCourse.Text = "Kurs Katılım Formu";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(332, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 39);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Kapat";
            this.btnExit.ToolTip = "Kapat";
            this.btnExit.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnExit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAttendanceCode
            // 
            this.txtAttendanceCode.EditValue = "";
            this.txtAttendanceCode.Location = new System.Drawing.Point(75, 125);
            this.txtAttendanceCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAttendanceCode.Name = "txtAttendanceCode";
            this.txtAttendanceCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAttendanceCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtAttendanceCode.Properties.AutoHeight = false;
            this.txtAttendanceCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAttendanceCode.Properties.Mask.EditMask = ".+";
            this.txtAttendanceCode.Properties.MaxLength = 6;
            this.txtAttendanceCode.Properties.NullText = "6 haneli katılım kodunu giriniz.";
            this.txtAttendanceCode.Properties.NullValuePrompt = "6 haneli katılım kodunu giriniz.";
            this.txtAttendanceCode.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtAttendanceCode.Size = new System.Drawing.Size(220, 23);
            this.txtAttendanceCode.TabIndex = 41;
            // 
            // lblAttendanceCode
            // 
            this.lblAttendanceCode.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblAttendanceCode.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAttendanceCode.Appearance.Options.UseFont = true;
            this.lblAttendanceCode.Appearance.Options.UseForeColor = true;
            this.lblAttendanceCode.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblAttendanceCode.Location = new System.Drawing.Point(75, 100);
            this.lblAttendanceCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblAttendanceCode.Name = "lblAttendanceCode";
            this.lblAttendanceCode.Size = new System.Drawing.Size(102, 19);
            this.lblAttendanceCode.TabIndex = 43;
            this.lblAttendanceCode.Text = "Katılım Kodu (*)";
            // 
            // btnJoinCourse
            // 
            this.btnJoinCourse.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnJoinCourse.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJoinCourse.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnJoinCourse.Appearance.Options.UseBackColor = true;
            this.btnJoinCourse.Appearance.Options.UseFont = true;
            this.btnJoinCourse.Appearance.Options.UseForeColor = true;
            this.btnJoinCourse.Location = new System.Drawing.Point(138, 157);
            this.btnJoinCourse.Margin = new System.Windows.Forms.Padding(20);
            this.btnJoinCourse.Name = "btnJoinCourse";
            this.btnJoinCourse.Size = new System.Drawing.Size(91, 25);
            this.btnJoinCourse.TabIndex = 46;
            this.btnJoinCourse.Text = "Katıl";
            this.btnJoinCourse.Click += new System.EventHandler(this.btnJoinCourse_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.btnEditCourse);
            this.panelControl4.Controls.Add(this.lblPageOfCreatingCourse);
            this.panelControl4.Location = new System.Drawing.Point(51, 40);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(261, 44);
            this.panelControl4.TabIndex = 83;
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
            this.pictureEdit1.Location = new System.Drawing.Point(157, 17);
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
            // JoinCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnJoinCourse);
            this.Controls.Add(this.lblAttendanceCode);
            this.Controls.Add(this.txtAttendanceCode);
            this.Name = "JoinCourse";
            this.Size = new System.Drawing.Size(376, 201);
            this.Load += new System.EventHandler(this.JoinCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAttendanceCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblPageOfCreatingCourse;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.TextEdit txtAttendanceCode;
        private DevExpress.XtraEditors.LabelControl lblAttendanceCode;
        private DevExpress.XtraEditors.SimpleButton btnJoinCourse;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnEditCourse;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
