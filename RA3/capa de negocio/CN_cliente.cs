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
    public class CN_cliente
    {
        private CD_clientes objetoCD = new CD_clientes();
        public DataTable Mostrarcli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void Insertarcli(string nombre, string apellido, string telefono)
        {
            objetoCD.Insertar(nombre, apellido, telefono);
        }
        public void Editarcli(string nombre, string apellido, string telefono, string id)
        {
            objetoCD.Editar(nombre, apellido, telefono, Convert.ToInt32(id));
        }
        public void Eliminarcli(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
