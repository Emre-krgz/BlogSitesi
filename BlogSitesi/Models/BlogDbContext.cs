using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BlogSitesi.Models.Mapping;

namespace BlogSitesi.Models
{
    public partial class BlogDbContext : DbContext
    {
        static BlogDbContext()
        {
            Database.SetInitializer<BlogDbContext>(null);
        }

        public BlogDbContext()
            : base("Name=BlogDbContext")
        {
        }

        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<MakaleEtiket> MakaleEtikets { get; set; }
        public DbSet<Resim> Resims { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorum> Yorums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EtiketMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new MakaleMap());
            modelBuilder.Configurations.Add(new MakaleEtiketMap());
            modelBuilder.Configurations.Add(new ResimMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new YorumMap());
        }
    }
}
