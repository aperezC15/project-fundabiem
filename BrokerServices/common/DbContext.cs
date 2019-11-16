
using EntityModelFundabien.entities;
using EntityModelFundabien.EntitySettings;
using EntityModelFundabien.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerServices.common
{
    public class dbContext : DbContext
    {
        //public dbContext(DbContextOptions<dbContext> options)
        //    : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConn = "Server =ec2-35-183-98-195.ca-central-1.compute.amazonaws.com; port = 5432; Database = fundabien; User Id = postgres; Password = Fundabien@2019; Pooling = true; MinPoolSize = 1; MaxPoolSize = 20; ";
            optionsBuilder.UseNpgsql(stringConn);
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Correo> Correos { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PersonaEncargada> PersonasEncargadas { get; set; }
        public DbSet<RegistroMedico> RegistrosMedicos { get; set; }
        public DbSet<RegistroMedicoDiagnostico> RegistrosMedicosDiagnostico { get; set; }
        public DbSet<TipoDirecciones> tipoDirecciones { get; set; }
        public DbSet<SeccionAnamnesis> SeccionesAnamnesis { get; set; }
        public DbSet<ItemAnamnesis> ItemsAnamnesis { get; set; }
        public DbSet<FamiliaresPaciente> familiaresPacientes { get; set; }
        //public DbSet<DetalleFormularioAnamnesis> DetalleFormularioAnamnesis { get; set; }
        //public DbSet<FormularioAnamnesis> FormularioAnamnesis { get; set; }
        //public DbSet<Personal> Personal { get; set; }
        public DbSet<DetalleTratamiento> DetallesTratamientos { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }
        public DbSet<Anamnesis> Anamnesis { get; set; }
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<ObjetivoDeIntervencion> ObjetivosDeIntervenciones { get; set; }
        public DbSet<CicloDeRehabilitacion> CicloDeRehabilitaciones { get; set; }
        public DbSet<DetalleCicloDeRehabilitacion> DetalleCicloDeRehabilitaciones { get; set; }
        public DbSet<EvolucionMedica> EvolucionesMedicas { get; set; }
        public DbSet<EstadoCitas> EstadoCitas { get; set; }
        public DbSet<Terapias> Terapias { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<EstudioSocioeconomico> EstudioSocioeconomico { get; set; }
        public DbSet<SeccionEstudioSocioeconomico> SeccionesEstudioSocioeconomico { get; set; }
        public DbSet<ItemEstudioSocioeconomico> ItemsEstudioSocioeconomico { get; set; }

        public DbSet<OpcionItemEstudioSocioeconomico> OpcionesItemsEstudioSocioeconomico { get; set; }
        public DbSet<EvaluacionEstudioSocioeconomico> EvaluacionesEstudioSocioeconomico { get; set; }
        public DbSet<TerapiaEstudioSocioeconomico> TerapiasEstudioSocioeconomico { get; set; }
        public DbSet<GrupoFamiliar> GrupoFamiliar { get; set; }

        public DbSet<EvolucionTecnica> EvolucionTenica { get; set; }
        public DbSet<HistoriaClinicaPsicologica> HistoriaClinicaPsicologicas { get; set; }
        public DbSet<antecedentesPaciente> AntecedentesPacientes { get; set; }
        public DbSet<examenMental> examenMental { get; set; }

        //to seeds
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.paisesSeed();
            modelBuilder.seedDepartamentos();
            modelBuilder.seddMunicipios();
            modelBuilder.seedTipoDirecciones();
            modelBuilder.seddSeccionesAnamnesis();
            modelBuilder.seedItemsAnamnesis();
            modelBuilder.ObjetivoDeIntervencionSeed();
            modelBuilder.seedSeccionEstudioSocioeconomico();
            modelBuilder.seedItemEstudioSocioeconomico();
            modelBuilder.seedOpcionesItemEstudioSocioeconomico();

            modelBuilder.PacienteConfig();
            modelBuilder.PersonaConfig();
            modelBuilder.EstadoCitaSedds();
            modelBuilder.TerapiasSeed();
        }
    }
}

    