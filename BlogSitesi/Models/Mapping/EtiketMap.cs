using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BlogSitesi.Models.Mapping
{
    public class EtiketMap : EntityTypeConfiguration<Etiket>
    {
        public EtiketMap()
        {
            // Primary Key
            this.HasKey(t => t.EtiketId);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Etiket");
            this.Property(t => t.EtiketId).HasColumnName("EtiketId");
            this.Property(t => t.Adi).HasColumnName("Adi");
        }
    }
}
