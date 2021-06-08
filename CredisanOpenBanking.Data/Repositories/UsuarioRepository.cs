using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CredisanOpenBanking.Data.Interfaces;
using CredisanOpenBanking.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace CredisanOpenBanking.Data.Repositories
{
  public class UsuarioRepository : IUsuarioRepository
  {
    private readonly IConfiguration config;

    public UsuarioRepository(IConfiguration config)
    {
      this.config = config;
    }
    public async Task<IEnumerable<Usuario>> Get()
    {
      string cs = config["ConnectionStrings:default"];
      var data = new List<Usuario>(){
        new Usuario(){
          Id = 1,
          Nome = "Kako",
          Email = "kakoferrare87@gmail.com",
        },
        new Usuario(){
          Id = 1,
          Nome = "Marcos",
          Email = "marcosferrare87@gmail.com",
        },
        new Usuario(){
          Id = 1,
          Nome = "Eu",
          Email = "euferrare87@gmail.com",
        },
        new Usuario(){
          Id = 1,
          Nome = "Outro",
          Email = "outroferrare87@gmail.com",
        }
      };
      return data;
    }
   
    public async Task<Usuario> Get(int id)
    {
      var data = new Usuario()
      {
        Id = 1,
        Nome = "Kako",
        Email = "kakoferrare87@gmail.com",
      };
      return data;
    }

    public async Task<Usuario> Post(Usuario item)
    {
      var data = new Usuario()
      {
        Id = 1,
        Nome = "Kako",
        Email = "kakoferrare87@gmail.com",
        DataCriacao = DateTime.UtcNow
      };
      return data;
    }

    public async Task<Usuario> Put(int id, Usuario item)
    {
      var data = new Usuario()
      {
        Id = 1,
        Nome = "Marcos",
        Email = "kakoferrare87@gmail.com",
        DataAtualizacao = DateTime.UtcNow
      };
      return data;
    }

    public async Task<bool> Delete(int id)
    {
      if(id > 0)
        return true;
      return false;
    }
  }
}

