namespace ChatRoom
{
    partial class IniciarSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.Mensaje = new System.Windows.Forms.Label();
            this.TextContraseña = new System.Windows.Forms.Label();
            this.TextUsuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(120, 142);
            this.Usuario.Multiline = true;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(260, 34);
            this.Usuario.TabIndex = 0;
            this.Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IngresarBtn);
            this.panel1.Controls.Add(this.Mensaje);
            this.panel1.Controls.Add(this.TextContraseña);
            this.panel1.Controls.Add(this.TextUsuario);
            this.panel1.Controls.Add(this.Contraseña);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Location = new System.Drawing.Point(200, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 387);
            this.panel1.TabIndex = 1;
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.Location = new System.Drawing.Point(174, 327);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(151, 42);
            this.IngresarBtn.TabIndex = 2;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.UseVisualStyleBackColor = true;
            this.IngresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(116, 289);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(244, 20);
            this.Mensaje.TabIndex = 4;
            this.Mensaje.Text = "(aquí va contraseña incorrecta :p)";
            this.Mensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextContraseña
            // 
            this.TextContraseña.AutoSize = true;
            this.TextContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContraseña.Location = new System.Drawing.Point(115, 212);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(120, 25);
            this.TextContraseña.TabIndex = 3;
            this.TextContraseña.Text = "Contraseña:";
            // 
            // TextUsuario
            // 
            this.TextUsuario.AutoSize = true;
            this.TextUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsuario.Location = new System.Drawing.Point(115, 114);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(85, 25);
            this.TextUsuario.TabIndex = 2;
            this.TextUsuario.Text = "Usuario:";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(120, 240);
            this.Contraseña.Multiline = true;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(260, 34);
            this.Contraseña.TabIndex = 1;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 587);
            this.Controls.Add(this.panel1);
            this.Name = "IniciarSesion";
            this.Text = "Iniciar Sesión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Label TextUsuario;
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.Label TextContraseña;
    }
}