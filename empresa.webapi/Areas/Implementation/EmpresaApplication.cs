using empresa.webapi.Areas.Interface;
using empresa.webapi.Configurations;
using empresa.webapi.Dto.Empresa;
using System.Data;

namespace empresa.webapi.Areas.Implementation
{
    public class EmpresaApplication : IEmpresaApplication
    {
        public async Task<OperationResult<List<ListaEmpresaRespuestaDto>>> RegistrarPersona(string nombre,string apePaterno, string apeMaterno, string correo, int codigoPersona)
        {
            var resultado = new OperationResult<List<ListaEmpresaRespuestaDto>> { isValid = false, exceptions = new List<OperationException>() };
            try
            {
                var ds = await new ProcedureGeneral().Procedure(new ProcedureRequestDto()
                {
                    Procedimiento = "dbo.ProcPersona",
                    Parametro = $"{nombre}|{apePaterno}|{apeMaterno}|{correo}|{codigoPersona}",
                    Indice = 20,
                    Database = "BDAdrian"
                });

                var listaMedidaTipo = (from x in ds.Tables[0].AsEnumerable() select x);

                var response = new List<ListaEmpresaRespuestaDto>();

                foreach (var medidaTipo in listaMedidaTipo)
                {
                    response.Add(new ListaEmpresaRespuestaDto()
                    {
                        CodResultado = medidaTipo.Field<int?>("CodResultado") ?? 0,
                        DesResultado = medidaTipo.Field<string?>("DesResultado") ?? "",
                    });
                }

                resultado.isValid = true;
                resultado.content = response;

                Console.WriteLine(DateTime.Now + ": " + resultado);

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now + ": " + e);
                throw new Exception(e.Message);
            }
        }
    }
}
