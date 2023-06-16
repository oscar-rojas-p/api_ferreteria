namespace empresa.webapi.Dto.Ferreteria
{
    public class ListaProductosDto
    {
        public int CodProducto { get; set; }
        public string? NomProducto { get; set; }
        public int CantidadActual  {get;set;}
        public int CantidadMinima  {get;set;}
        public int CantidadMaxima  {get;set;}
        public double PrecioCompra  {get;set;}
        public double PrecioVenta   {get;set;}
        public int CodMonedaCompra {get;set;}
        public int CodMonedaVenta  {get;set;}
    }
}
