using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_de_datos;

namespace capa_de_negocio
{
    public class CN_prestamo
    {
        private CD_prestamo objetoCD = new CD_prestamo();
        public DataTable Mostrarpre()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void Insertarpre(string cliente, string libro, string fecha_regeso)
        {
            objetoCD.Insertar(Convert.ToInt32(cliente), Convert.ToInt32(libro), fecha_regeso);
        }
        public void Editarpre(string cliente, string libro, string fecha_regeso, string id)
        {
            objetoCD.Editar(Convert.ToInt32(cliente), Convert.ToInt32(libro), fecha_regeso, Convert.ToInt32(id));
        }
        public void Eliminarpre(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
