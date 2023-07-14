namespace empresa.webapi.Dto.Ferreteria
{
    public class ListaVentaPeticionDto
    {
        public int CodDocumento { get; set; }
        public int CodPersona { get; set; }
        public int CodMoneda { get; set; }
        public string DireccionEntrega { get; set; }
        public int CorrelativoDocumento { get; set; }
        public int CantidadTotal { get; set; }
        public string ParametroVentaDetalleCuota { get; set; }
    }
}
