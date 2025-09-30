using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoom
{
    public partial class CHATMENU : Form
    {
        public CHATMENU()
        {
            InitializeComponent();
        }

        private void Mensaje_Click(object sender, EventArgs e)
        {

        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            IngresarBtn.Enabled = false;
            userName = Usuario.Text.Trim();
            string password = Contraseña.Text.Trim();
            string password2 = repetirContraseña.Text.Trim();

            if (password != password2) 
                Mensaje.Text = "Las contraseñas deben coincidir";

            MySqlConnection conn;

            conn = new MySqlConnection("server=127.0.0.1;uid=root;database=ChatRoom");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (id_usuario, nombre_usuario, contraseña) VALUES (@id, @nombre, @contraseña)", conn);
            cmd.Parameters.AddWithValue("@nombre", userName);
            cmd.Parameters.AddWithValue("@contraseña", password);
            cmd.ExecuteNonQuery();

            MySqlCommand cmd2 = new MySqlCommand("SELECT LAST_INSERT_ID() as id_usuario", conn);

            MySqlDataReader reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                userId = reader.GetInt32("id_usuario");
                userName = reader.GetString("nombre_usuario");
                IngresarBtn.Enabled = true; //sepa la bola si funciona así
            }


        }
    }
}
