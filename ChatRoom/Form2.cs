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
        private int usuarioId;
        private string usuarioName;

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
            usuarioName = Usuario.Text.Trim();
            string password = Contraseña.Text.Trim();

            if (ValidarUsuario(usuarioName, password))
            {
                //Pasar al chatroom
            }
            else
                Mensaje.Text = "Contraseña o usuario incorrecto";

        }

        private bool ValidarUsuario(string user, string password)
        {
            MySqlConnection conn;

            conn = new MySqlConnection("server=127.0.0.1;uid=root;database=ChatRoom");
            conn.Open();
            //send help para la encriptacion yes
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE nombre_usuario = @user AND contraseña = @password", conn);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("Password", password);

            cmd.ExecuteNonQuery();

            MySqlCommand cmd2 = new MySqlCommand("SELECT LAST_INSERT_ID() as id_usuario", conn);

            MySqlDataReader reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                usuarioId = reader.GetInt32("id_usuario");
                usuarioName = reader.GetString("nombre_usuario");
                return true;
            }
            return false;
        }
    }
}
