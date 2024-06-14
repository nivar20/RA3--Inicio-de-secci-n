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
    public partial class cliente : Form
    {
        CN_cliente objetoCN = new CN_cliente();
        private string idcliente = null;
        private bool Editar = false;
        private void Mostrarclientes()
        {
            CN_cliente objeto = new CN_cliente();
            dataGridView1.DataSource = objeto.Mostrarcli();
        }

            public cliente()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.Insertarcli(txt_nombre.Text, txt_apellido.Text, txt_telefono.Text);
                    MessageBox.Show("se inserto correctamente");
                    Mostrarclientes();
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
                    objetoCN.Editarcli(txt_nombre.Text,txt_apellido.Text,txt_telefono.Text, idcliente);
                    MessageBox.Show("se edito correctamente");
                    Mostrarclientes();
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
                txt_nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_apellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txt_telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                idcliente = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idcliente = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
                objetoCN.Eliminarcli(idcliente);
                MessageBox.Show("Eliminado correctamente");
                Mostrarclientes();
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

        private void cliente_Load(object sender, EventArgs e)
        {
            Mostrarclientes();
        }
        private void limpiarForm()
        {
            txt_telefono.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
        }
    }
}
