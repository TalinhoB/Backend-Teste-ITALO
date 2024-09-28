using Microsoft.AspNetCore.Mvc;
using SistemaListagem.Data;
using SistemaListagem.Models;
using SistemaListagem.Repositorios.Interfaces;

namespace SistemaListagem.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public async Task<bool> GravarUsuario([FromBody] List<Usuarios> dados)
        {
            for(int i =0;  i< dados.Count; i++)
            {
                _bancoContext.usuarios.Add(dados[i]);
            }
           
            await _bancoContext.SaveChangesAsync();;
            return true; 
           
        }
    }
}
