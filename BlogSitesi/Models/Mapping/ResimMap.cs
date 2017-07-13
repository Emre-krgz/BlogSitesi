using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BlogSitesi.Models.Mapping
{
    public class ResimMap : EntityTypeConfiguration<Resim>
    {
        public ResimMap()
        {
            // Primary Key
            this.HasKey(t => t.ResimId);

            // Properties
            this.Property(t => t.KucukBoyut)
                .HasMaxLength(250);

            this.Property(t => t.OrtaBoyut)
                .HasMaxLength(250);

            this.Property(t => t.BuyukByout)
                .HasMaxLength(250);

            this.Property(t => t.Video)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Resim");
            this.Property(t => t.ResimId).HasColumnName("ResimId");
            this.Property(t => t.KucukBoyut).HasColumnName("KucukBoyut");
            this.Property(t => t.OrtaBoyut).HasColumnName("OrtaBoyut");
            this.Property(t => t.BuyukByout).HasColumnName("BuyukByout");
            this.Property(t => t.Video).HasColumnName("Video");
            this.Property(t => t.MakaleId).HasColumnName("MakaleId");

            // Relationships
            this.HasOptional(t => t.Makale)
                .WithMany(t => t.Resims)
                .HasForeignKey(d => d.MakaleId);

        }
    }
}
