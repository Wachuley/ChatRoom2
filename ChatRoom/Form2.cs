using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatRoom;
using MySql.Data.MySqlClient;

namespace ChatRoom
{
    public partial class Form2: Form
    {
        private STARTMENU _mainForm;
        private string connection = "server=127.0.0.1;uid=root;pwd=root;database=ChatRoom";
        public Form2(STARTMENU mainForm, int userId, string userName)
        {
            InitializeComponent();
            _mainForm = mainForm;
            MuestraUsuario(userId, userName);
        }

        private void MuestraUsuario(int userid, string username)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE id_usuario = @id", conn);
            cmd.Parameters.AddWithValue("@id", userid);

            MySqlDataReader Reader = cmd.ExecuteReader();
            if (Reader.Read())
            {
                label1.Text = Reader.GetString("nombre_usuario");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            STARTMENU menu = new STARTMENU();
            menu.Show();
            this.Close();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
