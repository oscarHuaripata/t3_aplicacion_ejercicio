using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancistoCloneWeb.Models.Maps
{
    public class RutinaEjercicioMap : IEntityTypeConfiguration<RutinaEjercicio>
    {
        public void Configure(EntityTypeBuilder<RutinaEjercicio> builder)
        {
            builder.ToTable("RutinaEjercicio");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Rutina)
            .WithMany()
            .HasForeignKey(o => o.RutinaId);

            builder.HasOne(o => o.Ejercicio)
            .WithMany()
            .HasForeignKey(o => o.EjercicioId);
        }
    }
}
