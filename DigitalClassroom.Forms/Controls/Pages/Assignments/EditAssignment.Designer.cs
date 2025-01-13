namespace DigitalClassroom.Forms.Controls.Pages.Assignments
{
    partial class EditAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAssignment));
            this.lblMaxScore = new DevExpress.XtraEditors.LabelControl();
            this.txtMaxScore = new DevExpress.XtraEditors.TextEdit();
            this.dateEditAssignment = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblAssignmentTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblPageOfEditAssignment = new DevExpress.XtraEditors.LabelControl();
            this.txtAssignmentTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblRemainingTime = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnCreateStudentSubmission = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangeIsActiveAssignment = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditAssignment = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxScore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAssignment.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAssignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssignmentTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblMaxScore.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblMaxScore.Appearance.Options.UseFont = true;
            this.lblMaxScore.Appearance.Options.UseForeColor = true;
            this.lblMaxScore.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblMaxScore.Location = new System.Drawing.Point(17, 169);
            this.lblMaxScore.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(125, 19);
            this.lblMaxScore.TabIndex = 82;
            this.lblMaxScore.Text = "Maksimum Puan (*)";
            // 
            // txtMaxScore
            // 
            this.txtMaxScore.EditValue = "";
            this.txtMaxScore.Location = new System.Drawing.Point(17, 198);
            this.txtMaxScore.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMaxScore.Name = "txtMaxScore";
            this.txtMaxScore.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaxScore.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaxScore.Properties.AutoHeight = false;
            this.txtMaxScore.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMaxScore.Properties.Mask.EditMask = ".+";
            this.txtMaxScore.Properties.NullText = "Maksimum Puan";
            this.txtMaxScore.Properties.NullValuePrompt = "Maksimum Puan";
            this.txtMaxScore.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMaxScore.Size = new System.Drawing.Size(257, 27);
            this.txtMaxScore.TabIndex = 81;
            // 
            // dateEditAssignment
            // 
            this.dateEditAssignment.EditValue = null;
            this.dateEditAssignment.Location = new System.Drawing.Point(17, 125);
            this.dateEditAssignment.Name = "dateEditAssignment";
            this.dateEditAssignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAssignment.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dateEditAssignment.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAssignment.Properties.CalendarTimeProperties.Mask.EditMask = "g";
            this.dateEditAssignment.Properties.Mask.EditMask = "g";
            this.dateEditAssignment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditAssignment.Properties.ShowOk = DevExpress.Utils.DefaultBoolean.True;
            this.dateEditAssignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditAssignment.Properties.ValidateOnEnterKey = true;
            this.dateEditAssignment.Size = new System.Drawing.Size(257, 22);
            this.dateEditAssignment.TabIndex = 80;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(17, 96);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 19);
            this.labelControl1.TabIndex = 77;
            this.labelControl1.Text = "Teslim Tarihi (*)";
            // 
            // lblAssignmentTitle
            // 
            this.lblAssignmentTitle.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblAssignmentTitle.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblAssignmentTitle.Appearance.Options.UseFont = true;
            this.lblAssignmentTitle.Appearance.Options.UseForeColor = true;
            this.lblAssignmentTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblAssignmentTitle.Location = new System.Drawing.Point(17, 17);
            this.lblAssignmentTitle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblAssignmentTitle.Name = "lblAssignmentTitle";
            this.lblAssignmentTitle.Size = new System.Drawing.Size(99, 19);
            this.lblAssignmentTitle.TabIndex = 71;
            this.lblAssignmentTitle.Text = "Ödev Başlığı (*)";
            // 
            // lblPageOfEditAssignment
            // 
            this.lblPageOfEditAssignment.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageOfEditAssignment.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageOfEditAssignment.Appearance.Options.UseFont = true;
            this.lblPageOfEditAssignment.Appearance.Options.UseForeColor = true;
            this.lblPageOfEditAssignment.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblPageOfEditAssignment.Location = new System.Drawing.Point(50, 8);
            this.lblPageOfEditAssignment.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblPageOfEditAssignment.Name = "lblPageOfEditAssignment";
            this.lblPageOfEditAssignment.Size = new System.Drawing.Size(273, 25);
            this.lblPageOfEditAssignment.TabIndex = 70;
            this.lblPageOfEditAssignment.Text = "Ödev Detayı Görüntüleme Sayfası";
            // 
            // txtAssignmentTitle
            // 
            this.txtAssignmentTitle.EditValue = "";
            this.txtAssignmentTitle.Location = new System.Drawing.Point(17, 52);
            this.txtAssignmentTitle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAssignmentTitle.Name = "txtAssignmentTitle";
            this.txtAssignmentTitle.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAssignmentTitle.Properties.Appearance.Options.UseBackColor = true;
            this.txtAssignmentTitle.Properties.AutoHeight = false;
            this.txtAssignmentTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAssignmentTitle.Properties.Mask.EditMask = ".+";
            this.txtAssignmentTitle.Properties.NullText = "Ödev Başlığı";
            this.txtAssignmentTitle.Properties.NullValuePrompt = "Ödev Başlığı";
            this.txtAssignmentTitle.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtAssignmentTitle.Size = new System.Drawing.Size(257, 27);
            this.txtAssignmentTitle.TabIndex = 69;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(310, 49);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(256, 176);
            this.txtDescription.TabIndex = 85;
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F);
            this.lblDescription.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Appearance.Options.UseFont = true;
            this.lblDescription.Appearance.Options.UseForeColor = true;
            this.lblDescription.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblDescription.Location = new System.Drawing.Point(310, 17);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 19);
            this.lblDescription.TabIndex = 84;
            this.lblDescription.Text = "Açıklama (*)";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.pictureEdit3);
            this.panelControl1.Controls.Add(this.lblPageOfEditAssignment);
            this.panelControl1.Location = new System.Drawing.Point(20, 14);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(344, 41);
            this.panelControl1.TabIndex = 87;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(5, 4);
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
            // lblMessage
            // 
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Appearance.Options.UseForeColor = true;
            this.lblMessage.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblMessage.Location = new System.Drawing.Point(50, 7);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 25);
            this.lblMessage.TabIndex = 88;
            this.lblMessage.Text = "{Message}";
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.pictureEdit2);
            this.panelControl4.Controls.Add(this.lblMessage);
            this.panelControl4.Location = new System.Drawing.Point(20, 67);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(591, 41);
            this.panelControl4.TabIndex = 96;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(5, 0);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(37, 38);
            this.pictureEdit2.TabIndex = 89;
            this.pictureEdit2.TabStop = true;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Controls.Add(this.lblRemainingTime);
            this.panelControl2.Location = new System.Drawing.Point(384, 14);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(419, 41);
            this.panelControl2.TabIndex = 97;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(6, 2);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(37, 38);
            this.pictureEdit1.TabIndex = 67;
            this.pictureEdit1.TabStop = true;
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTime.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblRemainingTime.Appearance.Options.UseFont = true;
            this.lblRemainingTime.Appearance.Options.UseForeColor = true;
            this.lblRemainingTime.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblRemainingTime.Location = new System.Drawing.Point(56, 8);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(94, 25);
            this.lblRemainingTime.TabIndex = 88;
            this.lblRemainingTime.Text = "Kalan Süre:";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.lblAssignmentTitle);
            this.panelControl3.Controls.Add(this.txtAssignmentTitle);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.dateEditAssignment);
            this.panelControl3.Controls.Add(this.txtMaxScore);
            this.panelControl3.Controls.Add(this.txtDescription);
            this.panelControl3.Controls.Add(this.lblMaxScore);
            this.panelControl3.Controls.Add(this.lblDescription);
            this.panelControl3.Location = new System.Drawing.Point(20, 123);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(591, 251);
            this.panelControl3.TabIndex = 98;
            // 
            // btnCreateStudentSubmission
            // 
            this.btnCreateStudentSubmission.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnCreateStudentSubmission.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateStudentSubmission.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateStudentSubmission.Appearance.Options.UseBackColor = true;
            this.btnCreateStudentSubmission.Appearance.Options.UseFont = true;
            this.btnCreateStudentSubmission.Appearance.Options.UseForeColor = true;
            this.btnCreateStudentSubmission.Location = new System.Drawing.Point(20, 384);
            this.btnCreateStudentSubmission.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateStudentSubmission.Name = "btnCreateStudentSubmission";
            this.btnCreateStudentSubmission.Size = new System.Drawing.Size(106, 32);
            this.btnCreateStudentSubmission.TabIndex = 101;
            this.btnCreateStudentSubmission.Text = "Ödev Teslim Et";
            this.btnCreateStudentSubmission.Click += new System.EventHandler(this.btnCreateStudentSubmission_Click);
            // 
            // btnChangeIsActiveAssignment
            // 
            this.btnChangeIsActiveAssignment.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnChangeIsActiveAssignment.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeIsActiveAssignment.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeIsActiveAssignment.Appearance.Options.UseBackColor = true;
            this.btnChangeIsActiveAssignment.Appearance.Options.UseFont = true;
            this.btnChangeIsActiveAssignment.Appearance.Options.UseForeColor = true;
            this.btnChangeIsActiveAssignment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeIsActiveAssignment.ImageOptions.Image")));
            this.btnChangeIsActiveAssignment.Location = new System.Drawing.Point(506, 384);
            this.btnChangeIsActiveAssignment.Margin = new System.Windows.Forms.Padding(23);
            this.btnChangeIsActiveAssignment.Name = "btnChangeIsActiveAssignment";
            this.btnChangeIsActiveAssignment.Size = new System.Drawing.Size(105, 32);
            this.btnChangeIsActiveAssignment.TabIndex = 100;
            this.btnChangeIsActiveAssignment.Text = "Ödevi İptal Et";
            this.btnChangeIsActiveAssignment.Click += new System.EventHandler(this.btnChangeIsActiveAssignment_Click);
            // 
            // btnEditAssignment
            // 
            this.btnEditAssignment.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditAssignment.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditAssignment.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditAssignment.Appearance.Options.UseBackColor = true;
            this.btnEditAssignment.Appearance.Options.UseFont = true;
            this.btnEditAssignment.Appearance.Options.UseForeColor = true;
            this.btnEditAssignment.Location = new System.Drawing.Point(384, 384);
            this.btnEditAssignment.Margin = new System.Windows.Forms.Padding(23);
            this.btnEditAssignment.Name = "btnEditAssignment";
            this.btnEditAssignment.Size = new System.Drawing.Size(119, 32);
            this.btnEditAssignment.TabIndex = 99;
            this.btnEditAssignment.Text = "Değişiklikleri Kaydet";
            this.btnEditAssignment.Click += new System.EventHandler(this.btnEditAssignment_Click);
            // 
            // EditAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateStudentSubmission);
            this.Controls.Add(this.btnChangeIsActiveAssignment);
            this.Controls.Add(this.btnEditAssignment);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.Name = "EditAssignment";
            this.Size = new System.Drawing.Size(983, 760);
            this.Load += new System.EventHandler(this.EditAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxScore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAssignment.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAssignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssignmentTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMaxScore;
        private DevExpress.XtraEditors.TextEdit txtMaxScore;
        private DevExpress.XtraEditors.DateEdit dateEditAssignment;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblAssignmentTitle;
        private DevExpress.XtraEditors.LabelControl lblPageOfEditAssignment;
        private DevExpress.XtraEditors.TextEdit txtAssignmentTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblRemainingTime;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCreateStudentSubmission;
        private DevExpress.XtraEditors.SimpleButton btnChangeIsActiveAssignment;
        private DevExpress.XtraEditors.SimpleButton btnEditAssignment;
    }
}
