using AutoMapper;
using CredisanOpenBanking.Domain.Dtos.Usuario;
using CredisanOpenBanking.Domain.Models;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<ResponseUsuarioDto, UsuarioModel>().ReverseMap();
            CreateMap<CreateUsuarioDto, UsuarioModel>().ReverseMap();
            CreateMap<UpdateUsuarioDto, UsuarioModel>().ReverseMap();
        }
    }
}