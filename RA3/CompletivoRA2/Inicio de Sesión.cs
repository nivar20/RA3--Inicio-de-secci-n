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
    public partial class Form1 : Form
    {
       public CN_usuario iniciar = new CN_usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;

            if (iniciar.ValidateUser(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                frm_menú menu = new frm_menú();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
        }
    }
}
