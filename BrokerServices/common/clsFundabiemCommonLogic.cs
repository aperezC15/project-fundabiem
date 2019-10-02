using AutoMapper;
using BrokerServices.common;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.Models;
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
        //private readonly dbContext context;
        //private readonly IMapper mapper;

        

        public Task RegistrarPAciente()
        {
            throw new NotImplementedException();
        }

        public Task Saludar<TI1>()
        {
            throw new NotImplementedException();
        }

        public ActionResult<AutorDTO> obtenerAutor(int id,  IMapper map)
        {
            var con = new dbContext();
            var autor = con.Autores.FirstOrDefault(x => x.AutorId == id);
            var autorDTO = map.Map<AutorDTO>(autor);
            return autorDTO;
        }

      
    }

   
}
