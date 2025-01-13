using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.BusinessLayer.Managers;
using DevExpress.XtraGrid.Columns;
using DigitalClassroom.EntityLayer.Concrete;

namespace DigitalClassroom.Forms.Controls.Pages.Institutions
{
    public partial class ViewInstitutions : DevExpress.XtraEditors.XtraUserControl
    {
        public ViewInstitutions()
        {
            InitializeComponent();
        }

        private void ViewInstitutions_Load(object sender, EventArgs e)
        {
            IInstitutionService institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
            IUserService userService = new UserManager(new UserRepository(new AppDbContext()));
            IEnumerable<Institution> institutions = institutionService.GetAll();
            BindingList<dynamic> institutionBindingList = new BindingList<dynamic>();
            foreach (var institution in institutions)
            {
                // ManagerId alanı ile Users sınıfındaki Id alanını karşılaştırarak eşleşen kaydın Name ve Surname alanlarını birleştirerek ManagerFullName alanına atama işlemi
                User manager = userService.GetById(institution.ManagerId);
                var managerFullName = manager.Name + " " + manager.Surname;
                institutionBindingList.Add(new
                {
                    institution.Id,
                    institution.Name,
                    ManagerFullName = managerFullName,
                    institution.Address,
                    institution.Email,
                    institution.ContactNumber,
                    IsActive = institution.IsActive ? "Aktif" : "Pasif",
                    institution.CreatedAt,
                });
            }
            gridControlInstitutions.DataSource = institutionBindingList;

            // Kurum Müdürü alanında Institutions sınıfının Manager alanının Name ve Surname alanlarını birleştirerek göster
        }
        private void gridViewInstitutions_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        private void btnViewSelectedInstitution_Click(object sender, EventArgs e)
        {
            // Seçili olan kurumun Id'sini al
            int selectedInstitutionId = Convert.ToInt32(gridViewInstitutions.GetRowCellValue(gridViewInstitutions.FocusedRowHandle, "Id"));
            // Seçili olan kurumun bilgilerini getir
            IInstitutionService institutionService = new InstitutionManager(new InstitutionRepository(new AppDbContext()));
            Institution selectedInstitution = institutionService.GetById(selectedInstitutionId);
            // Kurumun bilgilerini gösteren formu aç
            EditInstitution editInstitution = new EditInstitution(selectedInstitution);
            this.Parent.Controls.Add(editInstitution);
            this.Parent.Controls.Remove(this);
        }
    }
}