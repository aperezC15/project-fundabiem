using AutoMapper;
using EntityModelFundabien.entities;
using EntityModelFundabien.Models;
using EntityModelFundabien.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModelFundabien.mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Add as many of these lines as you need to mapy your objetct entities
            CreateMap<Autor, AutorDTO>();
            CreateMap<Pais, DTOPaises>();
            CreateMap<CreateAutorDTO, Autor>();
            CreateMap<Autor, CreateAutorDTO>();
        }
    }
}
