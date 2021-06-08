using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CredisanOpenBanking.Data.Interfaces;
using CredisanOpenBanking.Data.Repositories;
using CredisanOpenBanking.Domain.Dtos.Usuario;
using CredisanOpenBanking.Domain.Entities;
using CredisanOpenBanking.Domain.Models;
using CredisanOpenBanking.Service.Interfaces;


namespace CredisanOpenBanking.Service.Services
{
  public class UsuarioService : IUsuarioService
  {
    private readonly IUsuarioRepository _repository;
    private readonly IMapper _mapper;
    
    public UsuarioService(IUsuarioRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ResponseUsuarioDto>> Get()
    {
      var list = await _repository.Get();
      return _mapper.Map<IEnumerable<ResponseUsuarioDto>>(list);
    }

    public async Task<ResponseUsuarioDto> Get(int id)
    {
      var entity = await _repository.Get(id);
      return _mapper.Map<ResponseUsuarioDto>(entity);
    }

    public async Task<ResponseUsuarioDto> Post(CreateUsuarioDto item)
    {
      var model = _mapper.Map<UsuarioModel>(item);
      var entity = _mapper.Map<Usuario>(model);
      var result = await _repository.Post(entity);
      return _mapper.Map<ResponseUsuarioDto>(result);
    }
    
    public async Task<bool> Delete(int id)
    {
      return await _repository.Delete(id);
    }

  
    public async Task<ResponseUsuarioDto> Put(int id, UpdateUsuarioDto item)
    {
      var model = _mapper.Map<UsuarioModel>(item);
      var entity = _mapper.Map<Usuario>(model);
      var usuario = await _repository.Get(id);
      _mapper.Map(usuario, item);
      var result = await _repository.Put(id, usuario);
      return _mapper.Map<ResponseUsuarioDto>(result);
    }
  }
}