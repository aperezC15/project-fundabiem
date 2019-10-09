using AutoMapper;
using EntityModelFundabien.entities;
using EntityModelFundabien.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityModelFundabien.Interfaces
{
    public interface IFundabiemCommonLogic<TI, TC>
        where TI : struct, IEquatable<TI>
        where TC : struct
    {
        //add all task
        Task RegistrarPAciente();
        Task Saludar<TI>();

        ActionResult<AutorDTO> obtenerAutor(int id);

        Task<ActionResult<IEnumerable<Pais>>> getAllPaises();

        IEnumerable<Departamento> getDepartamentosByIdPais(double id);
    }
}
