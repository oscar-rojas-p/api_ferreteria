namespace empresa.webapi.Dto.Ferreteria
{
    public class ListaVentasDto
    {
        public int CodVenta { get; set; }
        public int CodDocumento { get; set; }
        public int CodPersona { get; set; }
        public string FechaHoraVenta { get; set; }
        public int CodMoneda { get; set; }
        public decimal ImporteSubTotal { get; set; }
        public decimal ImporteIGV { get; set; }
        public decimal IGV { get; set; }
        public int CantidadTotal { get; set; }
        public string DireccionEntrega { get; set; }
        public string SerieDocumento { get; set; }
        public int CorrelativoDocumento {get;set;}

    }
}
