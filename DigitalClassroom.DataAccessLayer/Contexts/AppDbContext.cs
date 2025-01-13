using DigitalClassroom.DataAccessLayer.Configurations;
using DigitalClassroom.EntityLayer.Concrete;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;

namespace DigitalClassroom.DataAccessLayer.Contexts
{
    // Bütün ilişkileri tanımlayacağımız yer
    // Proje ayağa kalktığında belleğe yüklenmesini istediğimiz tabloları burada belirtiyoruz

    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DigitalClassroomConnection")
        {
        }

        // DbSet sınıfları, veritabanında oluşturulacak tabloları temsil eder.

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FileAssociation> FileAssociations { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<MailVerification> MailVerifications { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StudentSubmission> StudentSubmissions { get; set; }
        public DbSet<User> Users { get; set; }

        /* OnModelCreating: Veritabanı modelini oluşturmak için kullanılan metoddur.
         * modelBuilder: Veritabanı modelini oluşturmak için kullanılacak olan nesnedir.
         * Configurations : Veritabanı modelini oluştururken kullanılacak olan konfigürasyon sınıflarını tutar.
         * Add : Veritabanı modelini oluştururken kullanılacak olan konfigürasyon sınıflarını eklemek için kullanılır.
         */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Base sınıfının OnModelCreating metodunu çağırıyoruz.
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AnnouncementConfiguration());
            modelBuilder.Configurations.Add(new AssignmentConfiguration());
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new EnrollmentConfiguration());
            modelBuilder.Configurations.Add(new FileAssociationConfiguration());
            modelBuilder.Configurations.Add(new FileConfiguration());
            modelBuilder.Configurations.Add(new InstitutionConfiguration());
            modelBuilder.Configurations.Add(new MailVerificationConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new StudentSubmissionConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
