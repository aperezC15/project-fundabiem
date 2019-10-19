using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.entities;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.Models;
using EntityModelFundabien.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelFundabien.common
{
    public class clsFundabiemCommonLogic<TI, TC> : IFundabiemCommonLogic<TI, TC>
    where TI : struct, IEquatable<TI>
        where TC : struct
    {
        private readonly Func<IFundabiemCommonLogic<TI, TC>> contratoEntityFactory;
        private readonly dbContext context;
        private readonly IMapper mapper;

        public clsFundabiemCommonLogic(IMapper mapper, dbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        

        public Task RegistrarPAciente()
        {
            throw new NotImplementedException();
        }

        public Task Saludar<TI1>()
        {
            throw new NotImplementedException();
        }

        public ActionResult<AutorDTO> obtenerAutor(int id)
        {
            var autor = context.Autores.FirstOrDefault(x => x.AutorId == id);
            var autorDTO = mapper.Map<AutorDTO>(autor);
            return autorDTO;
        }

        //obtiene todos los paises existentes
        public ActionResult<IEnumerable<DTOPaises>> getAllPaises()
        {
            var paises = context.Paises.ToList();
            var paisDTO = mapper.Map<List<DTOPaises>>(paises);
            return paisDTO;
                
        }
        //obtiene los departamento de un pais
        public  IEnumerable<departamentosDTO> getDepartamentosByIdPais(double id)
        {
            var departamentos = context.Departamentos.Where(x => x.idPais == id).ToList();
            var dep = mapper.Map<List<departamentosDTO>>(departamentos);
            return dep;
        }

        //obtiene los municpios de un departamento
        public IEnumerable<municipiosDTO> MunicipiosByIdDepartamento(double idDepartamento)
        {
            var municipios = context.Municipios.Where(x => x.idDepartamento == idDepartamento).ToList();
            var munis = mapper.Map<List<municipiosDTO>>(municipios);
            return munis;
        }

        //obtiene los tipos de direcciones
        public IEnumerable<TipoDirecciones> getTipoDirecciones()
        {
            var tipos = context.tipoDirecciones.ToList();
            return tipos;
        }

        public IEnumerable<SeccionAnamnesisDTO> getSeccionesconItemsAnamnesis()
        {
            var secciones = context.SeccionesAnamnesis.Include(seccion => seccion.itemsAnamnesis).ToList();

            var seccionesDTO = mapper.Map<List<SeccionAnamnesisDTO>>(secciones);

            return seccionesDTO;
        }
    }

   
}
