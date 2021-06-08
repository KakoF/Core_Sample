using System.Collections.Generic;
using System.Threading.Tasks;
using CredisanOpenBanking.Domain.Dtos.Usuario;

namespace CredisanOpenBanking.Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<ResponseUsuarioDto> Get(int id);
        Task<IEnumerable<ResponseUsuarioDto>> Get();
        Task<ResponseUsuarioDto> Post(CreateUsuarioDto item);
        Task<ResponseUsuarioDto> Put(int id, UpdateUsuarioDto item);
        Task<bool> Delete(int id);
    }
}