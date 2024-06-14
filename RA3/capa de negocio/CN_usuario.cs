using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_de_datos;

namespace capa_de_negocio
{
    public class CN_usuario
    {
        private CD_usuarios usuario = new CD_usuarios();

        public bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM usuario WHERE usuario = @usuario AND contraseña = @contraseña";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@usuario", username),
            new SqlParameter("@contraseña", password)
            };

            DataTable result = usuario.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 && (int)result.Rows[0][0] > 0;
        }
    }
}
