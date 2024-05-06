using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ServicioTaller.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ServicioTaller.DataAccess
{
    public class ClienteData
    {
        private readonly ConectionSQLServer _context;
        public ClienteData(ConectionSQLServer context)
        {
            this._context = context;
        }
        public async Task<ResponseAPI<List<ClienteData>>> ObtenerModulos(int conModulo = 0)
        {
            List<ClienteData> lModuloDTO = new List<ClienteData>();
            var resposeAPI = new ResponseAPI<List<ClienteData>>();
            using (var context = _context)
            {

                try
                {
                    var connection = (SqlConnection)context.Database.GetDbConnection();
                    var cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[Seguridad].[paObtenerModulos]";
                    cmd.Parameters.AddWithValue("@conModulo", conModulo);

                    connection.Open();
                    SqlDataReader r = cmd.ExecuteReader();

                    while (r.Read())
                    {
                        ClienteData moduloDTO = new ClienteData();
                        moduloDTO.conModulo = Convert.ToInt32(r["conModulo"]);
                        moduloDTO.codModulo = r["codModulo"].ToString();
                        moduloDTO.nomModulo = r["nomModulo"].ToString();
                        moduloDTO.urlModulo = r["urlModulo"].ToString();
                        moduloDTO.indEstado = Convert.ToBoolean(r["indEstado"]);
                        moduloDTO.usrCreacion = r["usrCreacion"].ToString();
                        moduloDTO.fecCreacion = Convert.ToDateTime(r["fecCreacion"]);
                        moduloDTO.sistema.conSistema = Convert.ToInt32(r["conSistema"]);
                        moduloDTO.sistema.nomSistema = r["nomSistema"].ToString();
                        lModuloDTO.Add(moduloDTO);

                    }
                    resposeAPI.indCorrecto = true;
                    resposeAPI.Valor = lModuloDTO;
                    resposeAPI.Mensaje = "Lista de sistemas";
                }
                catch (Exception ex)
                {

                    resposeAPI.indCorrecto = false;
                    resposeAPI.Valor = new List<ClienteData>();
                    resposeAPI.Mensaje = ex.Message;
                }

            }

            return resposeAPI;
        }
    }
}
