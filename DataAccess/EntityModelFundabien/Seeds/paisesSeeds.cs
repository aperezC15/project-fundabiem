using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;

namespace EntityModelFundabien.Seeds
{
    public static class paisesSeeds
    {
        public static void paisesSeed(this ModelBuilder modelBuider)
        {
            modelBuider.Entity<Pais>().HasData(
                new Pais {
                    idPais =1,
                    nombre = "Guatemala"
                }
            );
        }
    }
}
