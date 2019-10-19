using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;

namespace EntityModelFundabien.Seeds
{
    public static class tipoDireccionesSeeds
    {
        public static void seedTipoDirecciones(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDirecciones>().HasData(
                new TipoDirecciones
                {
                    Id = 1,
                    Descripcion = "Dirección"
                },
                new TipoDirecciones
                {
                    Id = 2,
                    Descripcion = "Residencia Habitual"
                },
                new TipoDirecciones
                {
                    Id = 3,
                    Descripcion = "Domicilio"
                }
            );
        }
    }
}
