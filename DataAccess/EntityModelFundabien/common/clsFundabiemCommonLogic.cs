using AutoMapper;
using EntityModelFundabien.Interfaces;
using EntityModelFundabien.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelFundabien.common
{
    public class clsFundabiemCommonLogic<TI, TC>: IFundabiemCommonLogic<TI, TC>
    where TI : struct, IEquatable<TI>
        where TC : struct
    {
        private readonly Func<IFundabiemCommonLogic<TI, TC>> contratoEntityFactory;
        //private readonly DbContext context;
        private readonly IMapper mapper;

        public Task RegistrarPAciente()
        {
            throw new NotImplementedException();
        }

        public Task Saludar<TI1>()
        {
            throw new NotImplementedException();
        }

        //public Task<AutorDTO> getId(int autorId)
        //{

        //}
    }

   
}
