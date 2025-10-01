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

        //DECLARACION DE VARIABLES EXTRA -----------------------------------------------------------
        Form f = null;

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            
            startmenulayout.Visible = true;
            loginmenulayout.Visible = false;
            registermenulayout.Visible = false;


        }

        //DISEÑO -----------------------------------------------------------
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //EVENTOS BOTONES -----------------------------------------------------------
        //Menu principal ***************
        //iniciar sesión
        private void loginButton_Click(object sender, EventArgs e) 
        {
            loginmenulayout.Visible = true;
            startmenulayout.Visible = false;
            registermenulayout.Visible = false;
        }
        //registrarse
        private void registerButton_Click(object sender, EventArgs e)
        {
            registermenulayout.Visible = true;
            startmenulayout.Visible = false;
            loginmenulayout.Visible = false;
        }
        //salir del programa
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Menu login ***************
        //iniciar sesion
        private void loginuserbutton_Click(object sender, EventArgs e)
        {
             if (userlogin.Text == "root" && passwordlogin.Text == "root")
            {
                Form2 f = new Form2(this);
                f.Show();
                this.Hide();
            }
            else
            {
                //Mostrar texto de error
            }

            userlogin.Text = "Usuario";
            userlogin.ForeColor = Color.Gray;
            passwordlogin.Text = "Contraseña";
            passwordlogin.ForeColor = Color.Gray;
            passwordlogin.UseSystemPasswordChar = false;
            passwordlogin.PasswordChar = '\0';
        }
        //volver al menu principal
        private void loginBackButton_Click(object sender, EventArgs e)
        {
            startmenulayout.Visible = true;
            loginmenulayout.Visible = false;
            registermenulayout.Visible = false;
            userlogin.Text = "Usuario";
            userlogin.ForeColor = Color.Gray;
            passwordlogin.Text = "Contraseña";
            passwordlogin.ForeColor = Color.Gray;
            passwordlogin.UseSystemPasswordChar = false;
            passwordlogin.PasswordChar = '\0';
        }
        //Menu register ***************
        //registrarse
        private void registeruserbutton_Click(object sender, EventArgs e)
        {
            registeruser.Text = "Usuario";
            registeruser.ForeColor = Color.Gray;
            registerpassword.Text = "Contraseña";
            registerpassword.ForeColor = Color.Gray;
            registerpassword.UseSystemPasswordChar = false;
            registerpassword.PasswordChar = '\0';
            confirmpassword.Text = "Confirmar Contraseña";
            confirmpassword.ForeColor = Color.Gray;
            confirmpassword.UseSystemPasswordChar = false;
            confirmpassword.PasswordChar = '\0';
        }
        //volver al menu principal
        private void registerbackbutton_Click(object sender, EventArgs e)
        {
            startmenulayout.Visible = true;
            loginmenulayout.Visible = false;
            registermenulayout.Visible = false;
            registeruser.Text = "Usuario";
            registeruser.ForeColor = Color.Gray;
            registerpassword.Text = "Contraseña";
            registerpassword.ForeColor = Color.Gray;
            registerpassword.UseSystemPasswordChar = false; //Estos bloques de codigo son temporales
            registerpassword.PasswordChar = '\0';
            confirmpassword.Text = "Confirmar Contraseña"; //luego veo como lo optimizo 
            confirmpassword.ForeColor = Color.Gray;
            confirmpassword.UseSystemPasswordChar = false;
            confirmpassword.PasswordChar = '\0';
        }

        //EVENTOS TEXTBOX -----------------------------------------------------------
        //Menu login ***************
        private void userlogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void passwordlogin_TextChanged(object sender, EventArgs e)
        {

        }
        //Menu register ***************
        private void registeruser_TextChanged(object sender, EventArgs e)
        {

        }
        private void registerpassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        //ENCRIPTACION Y DESENCRIPTACION -----------------------------------------------------------
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

        //PLACEHOLDERS -----------------------------------------------------------
        //registeruser
        private void registeruser_Enter(object sender, EventArgs e)
        {
            if(registeruser.Text == "Usuario")
            {
                registeruser.Text = "";
                registeruser.ForeColor = Color.Black;
            }
        }
        private void registeruser_Leave(object sender, EventArgs e)
        {
            if (registeruser.Text == "")
            {
                registeruser.Text = "Usuario";
                registeruser.ForeColor = Color.Gray;
            }
        }
        //registerpassword
        private void registerpassword_Enter(object sender, EventArgs e)
        {
            if (registerpassword.Text == "Contraseña")
            {
                registerpassword.Text = "";
                registerpassword.ForeColor = Color.Black;
                registerpassword.UseSystemPasswordChar = true;
                registerpassword.PasswordChar = '*';
            }
        }
        private void registerpassword_Leave(object sender, EventArgs e)
        {
            if (registerpassword.Text == "")
            {
                registerpassword.Text = "Contraseña";
                registerpassword.ForeColor = Color.Gray;
                registerpassword.UseSystemPasswordChar = false;
                registerpassword.PasswordChar = '\0';
            }
        }
        //confirmregisterpassword
        private void confirmpassword_Enter(object sender, EventArgs e)
        {
            if (confirmpassword.Text == "Confirmar Contraseña")
            {
                confirmpassword.Text = "";
                confirmpassword.ForeColor = Color.Black;
                confirmpassword.UseSystemPasswordChar = true;
                confirmpassword.PasswordChar = '*';
            }
        }
        private void confirmpassword_Leave(object sender, EventArgs e)
        {
            if (confirmpassword.Text == "")
            {
                confirmpassword.Text = "Confirmar Contraseña";
                confirmpassword.ForeColor = Color.Gray;
                confirmpassword.UseSystemPasswordChar = false;
                confirmpassword.PasswordChar = '\0';
            }
        }
        //userlogin
        private void userlogin_Enter(object sender, EventArgs e)
        {
            if (userlogin.Text == "Usuario")
            {
                userlogin.Text = "";
                userlogin.ForeColor = Color.Black;
            }
        }
        private void userlogin_Leave(object sender, EventArgs e)
        {
            if (userlogin.Text == "")
            {
                userlogin.Text = "Usuario";
                userlogin.ForeColor = Color.Gray;
            }
        }
        //passwordlogin
        private void passwordlogin_Enter(object sender, EventArgs e)
        {
            if (passwordlogin.Text == "Contraseña")
            {
                passwordlogin.Text = "";
                passwordlogin.ForeColor = Color.Black;
                passwordlogin.UseSystemPasswordChar = true;
                passwordlogin.PasswordChar= '*';
            }
        }
        private void passwordlogin_Leave(object sender, EventArgs e)
        {
            if (passwordlogin.Text == "")
            {
                passwordlogin.Text = "Contraseña";
                passwordlogin.ForeColor = Color.Gray;
                passwordlogin.UseSystemPasswordChar = false;
                passwordlogin.PasswordChar = '\0';
            }
        }
    }
}