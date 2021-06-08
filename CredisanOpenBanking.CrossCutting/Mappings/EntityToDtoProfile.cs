using AutoMapper;
using CredisanOpenBanking.Domain.Dtos.Usuario;
using CredisanOpenBanking.Domain.Entities;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ResponseUsuarioDto, Usuario>().ReverseMap();
            CreateMap<CreateUsuarioDto, Usuario>().ReverseMap();
            CreateMap<UpdateUsuarioDto, Usuario>().ReverseMap();
        }
    }
}