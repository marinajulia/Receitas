using AutoMapper;
using Receitas.Domain.Services.Receita.Dto;
using Receitas.Domain.Services.Receitas.Entities;

namespace Receitas.Domain.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ReceitaEntity, ReceitaDto>();
            CreateMap<ReceitaDto, ReceitaEntity>();
        }
       
    }
}
