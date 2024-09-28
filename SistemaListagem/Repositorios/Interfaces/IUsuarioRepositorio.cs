using SistemaListagem.Models;

namespace SistemaListagem.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
       Task<bool> GravarUsuario(List<Usuarios> dados);
    }
}
