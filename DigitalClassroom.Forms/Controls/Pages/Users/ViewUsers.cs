﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using DevExpress.Utils.Extensions;
using DigitalClassroom.EntityLayer.Concrete;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.DataAccessLayer.Contexts;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace DigitalClassroom.Forms.Controls.Pages.Users
{
    public partial class ViewUsers : DevExpress.XtraEditors.XtraUserControl
    {
        private User user;
        private IEnumerable<User> filteredUsers;

        public ViewUsers(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            GetFilteredUsers();
            gridViewUsers.CalcColumnBestWidth(colCreatedAt);
            /* Deneme Kodları
            // gridControlUsers.DataSource = filteredUsers;
            //BindingList<dynamic> userBindingList = new BindingList<dynamic>();
            //foreach (var user in filteredUsers)
            //{
            //    userBindingList.Add(new
            //    {
            //        user.Id,
            //        FullName = $"{user.Name} {user.Surname}",
            //        user.Role.RoleName,
            //        user.Email,
            //        user.PhoneNumber,
            //        user.CreatedAt,
            //        user.UpdatedAt,
            //        IsActive = user.IsActive ? "Aktif" : "Pasif",
            //    });
            //}
            //gridControlUsers.DataSource = userBindingList;

            //// RepositoryItemButtonEdit tanımlama
            //RepositoryItemButtonEdit btnEdittUser = new RepositoryItemButtonEdit();
            //btnEdittUser.Click += btnEdittUser_Click;

            //// Buton özelliklerini ayarla
            //btnEdittUser.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            //btnEdittUser.Buttons[0].Caption = "Düzenle";
            //btnEdittUser.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;

            //// GridView için yeni bir kolon oluştur ve özelliklerini ata
            //GridColumn editColumn = new GridColumn()
            //{
            //    Caption = "Düzenle Butonu",
            //    FieldName = "Düzenle",
            //    Name = "Edit",
            //    UnboundType = DevExpress.Data.UnboundColumnType.Object,
            //    Visible = true,
            //    ColumnEdit = btnEdittUser
            //};

            //// Kolon görünüm sırasını ayarla ve GridView'e ekle
            //editColumn.VisibleIndex = gridViewUsers.Columns.Count;
            //gridViewUsers.Columns.Add(editColumn);

            //// GridView'in buton modu ayarlarını yap
            //gridViewUsers.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            */
        }
        private void GetFilteredUsers()
        {
            AppDbContext dbContext = new AppDbContext();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Users.Load();
            // This line of code is generated by Data Source Configuration Wizard.
            // int ins = user.InstitutionId.Value;
            switch (user.Role.Id)
            {
                // Eğer kullanıcı Admin ise Users tablosundaki tüm kayıtları getir
                case (int)Role.RoleNames.Admin:
                    gridControlUsers.DataSource = dbContext.Users.Local.ToList();
                    break;

                // Eğer kullanıcı Kurum Müdürü ise Users tablosundaki sadece kendi kurumuna ait kayıtları getir
                case (int)Role.RoleNames.Manager:
                    gridControlUsers.DataSource = dbContext.Users.Local.ToList().Where(u => u.InstitutionId == user.InstitutionId);
                    break;
            }
        }

        private void gridViewUsers_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            // Hedef kolonun FieldName'i
            if (e.Column.FieldName == "Institution.Name" && string.IsNullOrEmpty(e.DisplayText))
            {
                e.DisplayText = "Bağımsız Kullanıcı";
            }
            // Diğer tüm boş hücreler için "N/A" yaz
            if (string.IsNullOrEmpty(e.DisplayText))
            {
                e.DisplayText = "N/A";
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Grid üzerinde seçili olan kullanıcının Id'sini al
            int userId = Convert.ToInt32(gridViewUsers.GetRowCellValue(gridViewUsers.FocusedRowHandle, "Id"));
            // Kullanıcıyı görüntülemek için yeni bir form aç
            EditUser editUser = new EditUser(userId,user);
            this.Parent.Controls.Add(editUser);
            this.Parent.Controls.Remove(this);
        }
    }
}