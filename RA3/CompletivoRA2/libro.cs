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
    public partial class libro : Form
    {
        CN_libro objetoCN = new CN_libro();
        private string idlibro = null;
        private bool Editar = false;
        private void Mostrarlibros()
        {
            CN_libro objeto = new CN_libro();
            dataGridView1.DataSource = objeto.Mostrarlib();
        }
        public libro()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.Insertarlib(txt_nombre.Text, txt_tipo.Text, txt_fecha.Text);
                    MessageBox.Show("se inserto correctamente");
                    Mostrarlibros();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.Editarlib(txt_nombre.Text, txt_tipo.Text, txt_fecha.Text, idlibro);
                    MessageBox.Show("se edito correctamente");
                    Mostrarlibros();
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
                txt_nombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txt_tipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
                txt_fecha.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
                idlibro = dataGridView1.CurrentRow.Cells["id_libro"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idlibro = dataGridView1.CurrentRow.Cells["id_libro"].Value.ToString();
                objetoCN.Eliminarlib(idlibro);
                MessageBox.Show("Eliminado correctamente");
                Mostrarlibros();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
            frm_menú menu = new frm_menú();
            menu.Show();
        }
        private void limpiarForm()
        {
            txt_tipo.Clear();
            txt_nombre.Clear();
            txt_fecha.Clear();
        }

        private void libro_Load(object sender, EventArgs e)
        {
            Mostrarlibros();
        }
    }
}
