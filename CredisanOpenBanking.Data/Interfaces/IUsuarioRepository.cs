using System.Collections.Generic;
using System.Threading.Tasks;
using CredisanOpenBanking.Domain.Entities;

namespace CredisanOpenBanking.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> Get(int id);
        Task<IEnumerable<Usuario>> Get();
        Task<Usuario> Post(Usuario item);
        Task<Usuario> Put(int id, Usuario item);
        Task<bool> Delete(int id);
    }
}