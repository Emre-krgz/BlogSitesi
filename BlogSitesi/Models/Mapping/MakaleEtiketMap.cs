using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlogSitesi.Models.Mapping
{
    public class MakaleEtiketMap : EntityTypeConfiguration<MakaleEtiket>
    {
        public MakaleEtiketMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MakaleId, t.EtiketId });

            // Properties
            this.Property(t => t.MakaleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EtiketId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MakaleEtiket");
            this.Property(t => t.MakaleId).HasColumnName("MakaleId");
            this.Property(t => t.EtiketId).HasColumnName("EtiketId");

            // Relationships
            this.HasRequired(t => t.Etiket)
                .WithMany(t => t.MakaleEtikets)
                .HasForeignKey(d => d.EtiketId);
            this.HasRequired(t => t.Etiket1)
                .WithMany(t => t.MakaleEtikets1)
                .HasForeignKey(d => d.EtiketId);
            this.HasRequired(t => t.Makale)
                .WithMany(t => t.MakaleEtikets)
                .HasForeignKey(d => d.MakaleId);

        }
    }
}
