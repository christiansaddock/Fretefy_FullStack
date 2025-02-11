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

            CreateMap<Regiao, RegiaoCidade>()
            .ForMember(dest => dest.Cidades, opt => opt.MapFrom(src => src.Cidades));

            CreateMap<Cidade, CidadeCreate>().ReverseMap();
            CreateMap<Cidade, CidadeUpdate>().ReverseMap();
            CreateMap<Cidade, CidadeDto>().ReverseMap();
            CreateMap<Cidade, CidadeGet>().ReverseMap();
        }
    }
}
