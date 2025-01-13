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
using DigitalClassroom.BusinessLayer.Managers;
using DigitalClassroom.DataAccessLayer.Contexts;
using DigitalClassroom.DataAccessLayer.Repositories;
using DigitalClassroom.EntityLayer.Concrete;

namespace DigitalClassroom.Forms.Controls.Pages.Announcements
{
    public partial class AnnouncementDetail : DevExpress.XtraEditors.XtraUserControl
    {
        private int announcementId;
        private string institutionName;
        private Announcement announcement;
        private User user;
        public AnnouncementDetail(User user, int announcementId)
        {
            InitializeComponent();
            this.announcementId = announcementId;
            this.user = user;
        }

        private void AnnouncementDetail_Load(object sender, EventArgs e)
        {
            // Duyuru servisi oluştur
            IAnnouncementService announcementService = new AnnouncementManager(new AnnouncementRepository(new AppDbContext()));

            // Id'si announcementId olan duyuruyu getir
            announcement = announcementService.GetById(announcementId);

            // Eğer kullanıcı duyuruyu oluşturan kişi ise veya adminse duyuruyu düzenleyebilir 
            if (user.Role.RoleName == Role.RoleNames.Admin.ToString() || user.Id == announcement.CreatorId)
            {
                btnEditAnnouncement.Visible = true;
            }

            // Duyuru başlığını ve mesajını göster
            lblAnnouncementTitle.Text = announcement.Title;
            txtAnnouncementMessage.Text = announcement.Message;

            // Eğer duyuru bir kurum tarafından oluşturulmuşsa kurum adını, değilse "Tüm Kurumlar" yazısını göster
            if (announcement.InstitutionId != null)
            {
                institutionName = announcement.Institution.Name;
            }
            else
            {
                institutionName = "Tüm Kurumlar";
            }

            // Duyurunun hangi kurum tarafından oluşturulduğunu ve kimin tarafından oluşturulduğunu göster
            lblInstitutionAndCreator.Text = $"İlgili Kurum: {institutionName} - Oluşturan Kişi: {announcement.Creator.Name} {announcement.Creator.Surname}";

            // Duyuru tarihini gün, ay, yıl saat, dakika, saniye olarak göster
            lblCreatedAt.Text = $"Oluşturulma Tarihi: {announcement.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss")}";
        }

        private void btnEditAnnouncement_Click_1(object sender, EventArgs e)
        {
            // Düzenleme butonuna tıklandığında EditAnnouncement formunu aç
            EditAnnouncement editAnnouncement = new EditAnnouncement(user, announcement);
            editAnnouncement.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(editAnnouncement);
            this.Parent.Controls.Remove(this);
        }
    }
}
