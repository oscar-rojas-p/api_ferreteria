using empresa.webapi.Areas.Interface;
using empresa.webapi.Configurations;
using empresa.webapi.Dto.Ferreteria;
using Microsoft.AspNetCore.Mvc;

namespace empresa.webapi.Areas.Controllers
{
    [Route("api/[controller]")]
    public class FerreteriaController : Controller
    {
        private readonly IFerreteriaApplication ferreteriaApplication;
        public FerreteriaController(IFerreteriaApplication ferreteriaApplication)
        {
            this.ferreteriaApplication = ferreteriaApplication;
        }

        [HttpPost]
        [Route("registrarPersona")]
        public async Task<OperationResult<List<ListaFerreteriaRespuestaDto>>> RegistrarPersona(string nombre, string apePaterno, string apeMaterno, string correo, int codigoPersona)
        {
            var resultado = await ferreteriaApplication.RegistrarPersona(nombre, apePaterno, apeMaterno, correo, codigoPersona);
            return resultado;
        }
    }
}
