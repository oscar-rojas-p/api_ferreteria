using empresa.webapi.Configurations;
using empresa.webapi.Dto.Ferreteria;

namespace empresa.webapi.Areas.Interface
{
    public interface IFerreteriaApplication
    {
        Task<OperationResult<List<ListaFerreteriaRespuestaDto>>> RegistrarPersona(string nombre, string apePaterno, string apeMaterno, string correo, int codigoPersona);
    }
}
