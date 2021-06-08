using AutoMapper;
using CredisanOpenBanking.Domain.Entities;
using CredisanOpenBanking.Domain.Models;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<Usuario, UsuarioModel>().ReverseMap();
        }
    }
}