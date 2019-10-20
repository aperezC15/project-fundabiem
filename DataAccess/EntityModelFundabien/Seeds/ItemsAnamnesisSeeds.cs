using EntityModelFundabien.entities;
using Microsoft.EntityFrameworkCore;

namespace EntityModelFundabien.Seeds
{
    public static class ItemsAnamnesisSeeds
    {
        public static void seedItemsAnamnesis(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemAnamnesis>().HasData(
                // ANTECEDENTES FAMILIARES
                new ItemAnamnesis
                {
                    idItemAnamnesis = 1,
                    idSeccionAnamnesis = 1,
                    nombre = "Hijos vivos",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 2,
                    idSeccionAnamnesis = 1,
                    nombre = "Hijos muertos y sus causas",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 3,
                    idSeccionAnamnesis = 1,
                    nombre = "Padres",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 4,
                    idSeccionAnamnesis = 1,
                    nombre = "Otros",
                    descripcion = ""
                },

                // ANTECEDENTES MEDICOS
                new ItemAnamnesis
                {
                    idItemAnamnesis = 5,
                    idSeccionAnamnesis = 2,
                    nombre = "Peso al nacer",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 6,
                    idSeccionAnamnesis = 2,
                    nombre = "Duración del embarazo",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 7,
                    idSeccionAnamnesis = 2,
                    nombre = "Problemas gestacionales",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 8,
                    idSeccionAnamnesis = 2,
                    nombre = "Medicamentos durante el embarazo",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 9,
                    idSeccionAnamnesis = 2,
                    nombre = "Tabaquismo",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 10,
                    idSeccionAnamnesis = 2,
                    nombre = "Alcohol",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 11,
                    idSeccionAnamnesis = 2,
                    nombre = "Duración del trabajo de parto",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 12,
                    idSeccionAnamnesis = 2,
                    nombre = "Sufrimiento fetal",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 13,
                    idSeccionAnamnesis = 2,
                    nombre = "Vaginal",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 14,
                    idSeccionAnamnesis = 2,
                    nombre = "Cesarea",
                    descripcion = ""
                },

                // PERIODO NEONATAL
                new ItemAnamnesis
                {
                    idItemAnamnesis = 15,
                    idSeccionAnamnesis = 3,
                    nombre = "Estado al nacer",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 16,
                    idSeccionAnamnesis = 3,
                    nombre = "Apgar",
                    descripcion = ""
                },

                // DESARROLLO
                new ItemAnamnesis
                {
                    idItemAnamnesis = 17,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a sostener la cabeza",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 18,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a sonreir",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 19,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a rodar al lado",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 20,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a sentarse solo",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 21,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a pararse",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 22,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a andar",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 23,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a caminar solo",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 24,
                    idSeccionAnamnesis = 4,
                    nombre = "Edad en que empezó a hablar",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 25,
                    idSeccionAnamnesis = 4,
                    nombre = "Vacunaciones",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 26,
                    idSeccionAnamnesis = 4,
                    nombre = "Enfermedades",
                    descripcion = ""
                },
                new ItemAnamnesis
                {
                    idItemAnamnesis = 27,
                    idSeccionAnamnesis = 4,
                    nombre = "Antecedentes Qx",
                    descripcion = ""
                }
            );
        }
    }
}
