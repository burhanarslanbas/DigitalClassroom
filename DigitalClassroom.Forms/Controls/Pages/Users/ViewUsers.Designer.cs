namespace DigitalClassroom.Forms.Controls.Pages.Users
{
    partial class ViewUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsers));
            this.lblViewUsers = new DevExpress.XtraEditors.LabelControl();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstitution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeactivetedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeactivetedReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnEditUser = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewUsers
            // 
            this.lblViewUsers.Appearance.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblViewUsers.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblViewUsers.Appearance.Options.UseFont = true;
            this.lblViewUsers.Appearance.Options.UseForeColor = true;
            this.lblViewUsers.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblViewUsers.Location = new System.Drawing.Point(61, 5);
            this.lblViewUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblViewUsers.Name = "lblViewUsers";
            this.lblViewUsers.Size = new System.Drawing.Size(183, 25);
            this.lblViewUsers.TabIndex = 54;
            this.lblViewUsers.Text = "Kullanıcıları Görüntüle";
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.DataSource = this.bindingSource1;
            this.gridControlUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlUsers.Location = new System.Drawing.Point(14, 75);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(1183, 419);
            this.gridControlUsers.TabIndex = 55;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DigitalClassroom.EntityLayer.Concrete.User);
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colSurname,
            this.colRoleName,
            this.colInstitution,
            this.colEmail,
            this.colPhoneNumber,
            this.colIsActive,
            this.colCreatedAt,
            this.colDeactivetedDate,
            this.colDeactivetedReason});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewUsers.OptionsBehavior.Editable = false;
            this.gridViewUsers.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridViewUsers.OptionsFind.AlwaysVisible = true;
            this.gridViewUsers.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewUsers_CustomColumnDisplayText);
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.FixedWidth = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 35;
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Soyadı";
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 2;
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Rolü";
            this.colRoleName.FieldName = "Role.RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 3;
            // 
            // colInstitution
            // 
            this.colInstitution.Caption = "Kurum İsmi";
            this.colInstitution.FieldName = "Institution.Name";
            this.colInstitution.Name = "colInstitution";
            this.colInstitution.Visible = true;
            this.colInstitution.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Mail Adresi";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.FixedWidth = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 87;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Telefon Numarası";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 6;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktiflik Durumu";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 7;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.Caption = "Oluşturulma Tarihi";
            this.colCreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 8;
            // 
            // colDeactivetedDate
            // 
            this.colDeactivetedDate.Caption = "Pasif Edilme Tarihi";
            this.colDeactivetedDate.FieldName = "DeactivetedDate";
            this.colDeactivetedDate.Name = "colDeactivetedDate";
            this.colDeactivetedDate.Visible = true;
            this.colDeactivetedDate.VisibleIndex = 9;
            // 
            // colDeactivetedReason
            // 
            this.colDeactivetedReason.Caption = "Pasif Edilme Nedeni";
            this.colDeactivetedReason.FieldName = "DeactivetedReason";
            this.colDeactivetedReason.Name = "colDeactivetedReason";
            this.colDeactivetedReason.Visible = true;
            this.colDeactivetedReason.VisibleIndex = 10;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditUser.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditUser.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditUser.Appearance.Options.UseBackColor = true;
            this.btnEditUser.Appearance.Options.UseFont = true;
            this.btnEditUser.Appearance.Options.UseForeColor = true;
            this.btnEditUser.Location = new System.Drawing.Point(1022, 505);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(23, 23, 23, 23);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(175, 29);
            this.btnEditUser.TabIndex = 60;
            this.btnEditUser.Text = "Seçilen Kullanıcıyı Düzenle";
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Controls.Add(this.lblViewUsers);
            this.panelControl4.Location = new System.Drawing.Point(14, 18);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(293, 42);
            this.panelControl4.TabIndex = 118;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(6, 3);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(37, 33);
            this.pictureEdit1.TabIndex = 65;
            this.pictureEdit1.TabStop = true;
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.gridControlUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(1217, 705);
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblViewUsers;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colInstitution;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colDeactivetedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeactivetedReason;
        private DevExpress.XtraEditors.SimpleButton btnEditUser;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
