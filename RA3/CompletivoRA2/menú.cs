using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompletivoRA2
{
    public partial class frm_menú : Form
    {
        public frm_menú()
        {
            InitializeComponent();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            cliente cliente = new cliente();
            cliente.Show();
            Close();
        }

        private void btn_libro_Click(object sender, EventArgs e)
        {
            libro libro = new libro();
            libro.Show();
            Close();
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            prestamo prestamo = new prestamo();
            prestamo.Show();
            Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
