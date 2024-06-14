using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_de_datos;

namespace capa_de_negocio
{
  public class CN_libro
    {
        private CD_libros objetoCD = new CD_libros();
        public DataTable Mostrarlib()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void Insertarlib(string nombre, string tipo, string fecha)
        {
            objetoCD.Insertar(nombre, tipo, fecha);
        }
        public void Editarlib(string nombre, string tipo, string fecha, string id)
        {
            objetoCD.Editar(nombre, tipo,fecha, Convert.ToInt32(id));
        }
        public void Eliminarlib(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
