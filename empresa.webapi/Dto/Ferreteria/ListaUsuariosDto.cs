namespace empresa.webapi.Dto.Ferreteria
{
    public class ListaUsuariosDto
    {
        public int CodUsuario { get; set; }
        public string? NomUsuario { get; set; }
        public string? ClaveUsuario { get; set; }
        public int CodPersona { get; set; }
        public bool Activo { get; set; }
        public int CodUsuarioTipo { get; set; }

    }
}
