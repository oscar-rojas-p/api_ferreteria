using empresa.webapi.Configurations;
using empresa.webapi.Dto.Ferreteria;

namespace empresa.webapi.Areas.Interface
{
    public interface IFerreteriaApplication
    {
        Task<OperationResult<List<ListaFerreteriaRespuestaDto>>> RegistrarPersona(string nombre, string apePaterno, string apeMaterno, string correo, int codigoPersona);
        Task<OperationResult<List<ListaPersonasDto>>> ListarPersonas();
        Task<OperationResult<List<ListaFerreteriaRespuestaDto>>> RegistrarProducto(string NomProducto, string AbrevProducto, string DescripcionProducto, string CodigoProducto, int CodSubCategoria, int CantidadMinima, int CantidadMaxima, double PrecioCompra, double PrecioVenta, int CodMonedaCompra, int CodMonedaVenta, int CodUsuarioCreacion);
        Task<OperationResult<List<ListaProductosDto>>> ListarProductos();
        Task<OperationResult<List<ListaFerreteriaRespuestaDto>>> RegistrarUsuario(string nombre, string clave, int codPersona, int codUsuarioTipo);
        Task<OperationResult<List<ListaUsuariosDto>>> ListarUsuarios();
        Task<OperationResult<List<ListaVentasDto>>> ListarVentas();

        Task<OperationResult<List<ListaFerreteriaRespuestaDto>>> RegistrarVenta(ListaVentaPeticionDto ListaVentaPeticion);

    }
}
