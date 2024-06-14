using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_de_negocio;

namespace CompletivoRA2
{
    public partial class prestamo : Form
    {
        CN_prestamo objetoCN = new CN_prestamo();
        private string idprestamo = null;
        private bool Editar = false;
        public prestamo()
        {
            InitializeComponent();
        }
        private void Mostrarprestamo()
        {
            CN_prestamo objeto = new CN_prestamo();
            dataGridView1.DataSource = objeto.Mostrarpre();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.Insertarpre(txt_cliente.Text, txt_libro.Text, txt_fechaingreso.Text);
                    MessageBox.Show("se inserto correctamente");
                    Mostrarprestamo();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    objetoCN.Editarpre(txt_cliente.Text, txt_libro.Text, txt_fechaingreso.Text, idprestamo);
                    MessageBox.Show("se edito correctamente");
                    Mostrarprestamo();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_cliente.Text = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
                txt_libro.Text = dataGridView1.CurrentRow.Cells["id_libro"].Value.ToString();
                txt_fechaingreso.Text = dataGridView1.CurrentRow.Cells["fecha_regreso"].Value.ToString();
                idprestamo = dataGridView1.CurrentRow.Cells["id_prestamo"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idprestamo = dataGridView1.CurrentRow.Cells["id_prestamo"].Value.ToString();
                objetoCN.Eliminarpre(idprestamo);
                MessageBox.Show("Eliminado correctamente");
                Mostrarprestamo();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_menú menu = new frm_menú();
            menu.Show();
            Close();
        }
        private void limpiarForm()
        {
            txt_cliente.Clear();
            txt_libro.Clear();
            txt_fechaingreso.Clear();
        }

        private void prestamo_Load(object sender, EventArgs e)
        {
            Mostrarprestamo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
