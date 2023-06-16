using empresa.webapi.Configurations;
using empresa.webapi.Dto.Empresa;

namespace empresa.webapi.Areas.Interface
{
    public interface IEmpresaApplication
    {
        Task<OperationResult<List<ListaEmpresaRespuestaDto>>> RegistrarPersona(string nombre, string apePaterno, string apeMaterno, string correo, int codigoPersona);
    }
}
