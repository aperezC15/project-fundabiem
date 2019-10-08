using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;

namespace EntityModelFundabien.Seeds
{
    public static class DepartamentosSeeds
    {
        public static void seedDepartamentos(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento
                {
                    idDepartamento = 1,
                    idPais =1,
                    nombre = "Alta Verapaz"
                },
                new Departamento
                {
                    idDepartamento = 2,
                    idPais = 1,
                    nombre = "Baja Verapaz"
                },
                new Departamento
                {
                    idDepartamento = 3,
                    idPais = 1,
                    nombre = "Chimaltenango"
                },
                new Departamento
                {
                    idDepartamento = 4,
                    idPais = 1,
                    nombre = "Chiquimula"
                },
                new Departamento
                {
                    idDepartamento = 5,
                    idPais = 1,
                    nombre = "El Progreso"
                },
                new Departamento
                {
                    idDepartamento = 6,
                    idPais = 1,
                    nombre = "Escuintla"
                },
                new Departamento
                {
                    idDepartamento = 7,
                    idPais = 1,
                    nombre = "Guatemala"
                },
                new Departamento
                {
                    idDepartamento = 8,
                    idPais = 1,
                    nombre = "Huehuetenango"
                },
                new Departamento
                {
                    idDepartamento = 9,
                    idPais = 1,
                    nombre = "Izabal"
                },
                new Departamento
                {
                    idDepartamento = 10,
                    idPais = 1,
                    nombre = "Jutiapa"
                },
                new Departamento
                {
                    idDepartamento = 11,
                    idPais = 1,
                    nombre = "Petén"
                },
                new Departamento
                {
                    idDepartamento = 12,
                    idPais = 1,
                    nombre = "Quetzaltenango"
                },
                new Departamento
                {
                    idDepartamento = 13,
                    idPais = 1,
                    nombre = "Quiché"
                },
                new Departamento
                {
                    idDepartamento = 14,
                    idPais = 1,
                    nombre = "Retalhuleu"
                },
                new Departamento
                {
                    idDepartamento = 15,
                    idPais = 1,
                    nombre = "Sacatepéquez"
                },
                new Departamento
                {
                    idDepartamento = 16,
                    idPais = 1,
                    nombre = "San Marcos"
                },
                new Departamento
                {
                    idDepartamento = 17,
                    idPais = 1,
                    nombre = "Santa Rosa"
                },
                new Departamento
                {
                    idDepartamento = 18,
                    idPais = 1,
                    nombre = "Sololá"
                },
                new Departamento
                {
                    idDepartamento = 19,
                    idPais = 1,
                    nombre = "Suchitepéquez"
                },
                new Departamento
                {
                    idDepartamento = 20,
                    idPais = 1,
                    nombre = "Totonicapán"
                },
                new Departamento
                {
                    idDepartamento = 21,
                    idPais = 1,
                    nombre = "Zacapa"
                },
                new Departamento
                {
                    idDepartamento = 22,
                    idPais = 1,
                    nombre = "Jalapa"
                }
            );
        }

    }
}
