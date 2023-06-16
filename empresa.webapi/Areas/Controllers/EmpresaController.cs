using empresa.webapi.Areas.Interface;
using empresa.webapi.Configurations;
using empresa.webapi.Dto.Empresa;
using Microsoft.AspNetCore.Mvc;

namespace empresa.webapi.Areas.Controllers
{
    [Route("api/[controller]")]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaApplication empresaApplication;
        public EmpresaController(IEmpresaApplication empresaApplication)
        {
            this.empresaApplication = empresaApplication;
        }

        [HttpGet]
        [Route("listaEmpresa")]
        public async Task<OperationResult<List<ListaEmpresaRespuestaDto>>> RegistrarPersona(string nombre, string apePaterno, string apeMaterno, string correo, int codigoPersona)
        {
            var resultado = await empresaApplication.RegistrarPersona(nombre, apePaterno, apeMaterno, correo, codigoPersona);
            return resultado;
        }
    }
}
