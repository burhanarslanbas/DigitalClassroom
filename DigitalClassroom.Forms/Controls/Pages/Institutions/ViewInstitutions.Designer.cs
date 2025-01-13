namespace DigitalClassroom.Forms.Controls.Pages.Institutions
{
    partial class ViewInstitutions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInstitutions));
            this.gridControlInstitutions = new DevExpress.XtraGrid.GridControl();
            this.gridViewInstitutions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.institutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblViewUsers = new DevExpress.XtraEditors.LabelControl();
            this.btnViewSelectedInstitution = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInstitutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInstitutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlInstitutions
            // 
            this.gridControlInstitutions.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlInstitutions.Location = new System.Drawing.Point(18, 74);
            this.gridControlInstitutions.MainView = this.gridViewInstitutions;
            this.gridControlInstitutions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlInstitutions.Name = "gridControlInstitutions";
            this.gridControlInstitutions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditUser});
            this.gridControlInstitutions.Size = new System.Drawing.Size(961, 419);
            this.gridControlInstitutions.TabIndex = 56;
            this.gridControlInstitutions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInstitutions});
            // 
            // gridViewInstitutions
            // 
            this.gridViewInstitutions.GridControl = this.gridControlInstitutions;
            this.gridViewInstitutions.Name = "gridViewInstitutions";
            this.gridViewInstitutions.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewInstitutions.OptionsBehavior.Editable = false;
            this.gridViewInstitutions.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewInstitutions.OptionsFind.AlwaysVisible = true;
            this.gridViewInstitutions.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewInstitutions_CustomColumnDisplayText);
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoHeight = false;
            this.btnEditUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)});
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // institutionBindingSource
            // 
            this.institutionBindingSource.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.Institution);
            // 
            // lblViewUsers
            // 
            this.lblViewUsers.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblViewUsers.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblViewUsers.Appearance.Options.UseFont = true;
            this.lblViewUsers.Appearance.Options.UseForeColor = true;
            this.lblViewUsers.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblViewUsers.Location = new System.Drawing.Point(50, 8);
            this.lblViewUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblViewUsers.Name = "lblViewUsers";
            this.lblViewUsers.Size = new System.Drawing.Size(259, 25);
            this.lblViewUsers.TabIndex = 57;
            this.lblViewUsers.Text = "Kurumları Görüntüleme Sayfası";
            // 
            // btnViewSelectedInstitution
            // 
            this.btnViewSelectedInstitution.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewSelectedInstitution.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewSelectedInstitution.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewSelectedInstitution.Appearance.Options.UseBackColor = true;
            this.btnViewSelectedInstitution.Appearance.Options.UseFont = true;
            this.btnViewSelectedInstitution.Appearance.Options.UseForeColor = true;
            this.btnViewSelectedInstitution.Location = new System.Drawing.Point(839, 21);
            this.btnViewSelectedInstitution.Margin = new System.Windows.Forms.Padding(20);
            this.btnViewSelectedInstitution.Name = "btnViewSelectedInstitution";
            this.btnViewSelectedInstitution.Size = new System.Drawing.Size(140, 32);
            this.btnViewSelectedInstitution.TabIndex = 88;
            this.btnViewSelectedInstitution.Text = "Seçilen Kurumu Düzenle";
            this.btnViewSelectedInstitution.Click += new System.EventHandler(this.btnViewSelectedInstitution_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.pictureEdit2);
            this.panelControl3.Controls.Add(this.lblViewUsers);
            this.panelControl3.Location = new System.Drawing.Point(18, 13);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(330, 44);
            this.panelControl3.TabIndex = 89;
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
            // ViewInstitutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.btnViewSelectedInstitution);
            this.Controls.Add(this.gridControlInstitutions);
            this.Name = "ViewInstitutions";
            this.Size = new System.Drawing.Size(1021, 619);
            this.Load += new System.EventHandler(this.ViewInstitutions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInstitutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInstitutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlInstitutions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInstitutions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditUser;
        private DevExpress.XtraEditors.LabelControl lblViewUsers;
        private System.Windows.Forms.BindingSource institutionBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnViewSelectedInstitution;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}
