using AutoMapper;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.WebApi.Data.Dtos;

namespace Fretefy.Test.WebApi.Data.AutoMapperConfigu
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Regiao, RegiaoDto>().ReverseMap();
            CreateMap<Regiao, RegiaoCidade>().ReverseMap();
            CreateMap<Regiao, RegiaoCreate>().ReverseMap();
            CreateMap<Regiao, RegiaoUpdate>().ReverseMap();
        }
    }
}
