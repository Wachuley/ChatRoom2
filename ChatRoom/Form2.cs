using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChatRoom
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            string user = Usuario.Text.Trim();
            string password = Contraseña.Text.Trim();

            MySqlConnection conn;

            conn = new MySqlConnection("server=127.0.0.1;uid=root;database=ChatRoom");
            conn.Open();
            //intentando verificar contraseña :p send help para la encriptacion
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE id_usuario = @id"); //(? idk
        }
    }
}
