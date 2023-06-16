using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace empresa.webapi.Configurations
{
    public class ProcedureGeneral
    {
        public async Task<DataSet> Procedure(ProcedureRequestDto procedureRequestDto)
        {
            SqlConnectionStringBuilder CSChatSignalR = new ConnectionStringDB().ConnectionStringApi(procedureRequestDto.Database);

            DataSet Ds = new DataSet();

            await using (SqlConnection connection = new SqlConnection(CSChatSignalR.ConnectionString))
            {
                using (SqlDataAdapter bdcomand = new SqlDataAdapter(procedureRequestDto.Procedimiento, connection))
                {
                    bdcomand.SelectCommand.CommandType = CommandType.StoredProcedure;
                    bdcomand.SelectCommand.Parameters.Add(new SqlParameter("@Parametros", procedureRequestDto.Parametro));
                    bdcomand.SelectCommand.Parameters.Add(new SqlParameter("@Indice", procedureRequestDto.Indice));
                    bdcomand.SelectCommand.CommandTimeout = 1000;
                    bdcomand.Fill(Ds);
                }
            }
            return Ds;
        }
    }
    public class ProcedureRequestDto
    {
        [Required]
        public string Procedimiento { get; set; }
        public string Parametro { get; set; }
        public int Indice { get; set; }
        [Required]
        public string Database { get; set; }
    }
}
