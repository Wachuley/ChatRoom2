using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoom
{
    public partial class STARTMENU : Form
    {
        public STARTMENU()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            
            startmenulayout.Visible = true;
            loginmenulayout.Visible = false;
            registermenulayout.Visible = false;


        }

        private void ConfigurarBotonRedondo(Button boton, int radio)
        {
            boton.Paint += new PaintEventHandler(Boton_Paint);
            boton.Tag = radio;
        }

        //Aplicar el dibujo a un botón
        private void Boton_Paint(object sender, PaintEventArgs e)
        {
            Button botonActual = (Button)sender;
            int radio = (int)botonActual.Tag;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath path = CrearPathRedondeado(botonActual.Width, botonActual.Height, radio);
            botonActual.Region = new System.Drawing.Region(path);
        }

        //Diseñar y dibujar el redondeado
        private System.Drawing.Drawing2D.GraphicsPath CrearPathRedondeado(int ancho, int alto, int radio)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(ancho - radio, 0, radio, radio, 270, 90);
            path.AddArc(ancho - radio, alto - radio, radio, radio, 0, 90);
            path.AddArc(0, alto - radio, radio, radio, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void IniciarSesionBtn_Click(object sender, EventArgs e)
        {
            //nota de prueba
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginmenulayout.Visible = true;
            startmenulayout.Visible = false;
            registermenulayout.Visible = false;



        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registermenulayout.Visible = true;
            startmenulayout.Visible = false;
            loginmenulayout.Visible = false;
        }

        private void registerbackbutton_Click(object sender, EventArgs e)
        {
            startmenulayout.Visible = true;
            loginmenulayout.Visible = false;
            registermenulayout.Visible = false;
        }

        private void loginBackButton_Click(object sender, EventArgs e)
        {
            startmenulayout.Visible = true;
            loginmenulayout.Visible = false;
            registermenulayout.Visible = false;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginuserbutton_Click(object sender, EventArgs e)
        {

        }

        //1ra prueba para encriptacion y desencriptacion bestis :)
        public static class Crypto
        {
            private static string key = "claveFija";
            private static string Encrypt(string text)
            {
                byte[] datos = Encoding.UTF8.GetBytes(text);
                byte[] claveBytes = Encoding.UTF8.GetBytes(key);
                byte[] resultado = new byte[datos.Length];

                for(int i = 0; i < datos.Length; i++)
                {
                    resultado[i] = (byte)(datos[i] ^ claveBytes[i % claveBytes.Length]);
                }
                return Convert.ToBase64String(resultado);
            }

            private static string Decrypt(string text)
            {
                byte[] datos = Convert.FromBase64String(text);
                byte[] claveBytes = Encoding.UTF8.GetBytes(key);
                byte[] resultado = new byte[datos.Length];

                for(int i = 0; i < datos.Length; i++)
                {
                    resultado[i] = (byte)(datos[i] ^ claveBytes[i % claveBytes.Length]);
                }
                return Encoding.UTF8.GetString(resultado);
            }
        }
    }


}
