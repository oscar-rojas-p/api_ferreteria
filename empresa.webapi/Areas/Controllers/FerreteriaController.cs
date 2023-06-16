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
        [HttpPost]
        [Route("registrarProducto")]
        public async Task<OperationResult<List<ListaFerreteriaRespuestaDto>>> RegistrarProducto(string NomProducto, string AbrevProducto, string DescripcionProducto, string CodigoProducto, int CodSubCategoria, int CantidadMinima, int CantidadMaxima, double PrecioCompra, double PrecioVenta, int CodMonedaCompra, int CodMonedaVenta, int CodUsuarioCreacion)
        {
            var resultado = await ferreteriaApplication.RegistrarProducto(NomProducto, AbrevProducto, DescripcionProducto, CodigoProducto, CodSubCategoria, CantidadMinima, CantidadMaxima, PrecioCompra, PrecioVenta, CodMonedaCompra, CodMonedaVenta, CodUsuarioCreacion);
            return resultado;
        }



        [HttpGet]
        [Route("listarProductos")]
        public async Task<OperationResult<List<ListaProductosDto>>> ListarProductos()
        {
            var resultado = await ferreteriaApplication.ListarProductos();
            return resultado;
        }

    }
}
