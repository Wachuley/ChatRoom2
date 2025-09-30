namespace ChatRoom
{
    partial class CHATMENU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.Mensaje = new System.Windows.Forms.Label();
            this.TextContraseña = new System.Windows.Forms.Label();
            this.TextUsuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.TextRepetirContraseña = new System.Windows.Forms.Label();
            this.repetirContraseña = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHATMENU
            // 
            this.panel1.Controls.Add(this.TextRepetirContraseña);
            this.panel1.Controls.Add(this.repetirContraseña);
            this.panel1.Controls.Add(this.IngresarBtn);
            this.panel1.Controls.Add(this.Mensaje);
            this.panel1.Controls.Add(this.TextContraseña);
            this.panel1.Controls.Add(this.TextUsuario);
            this.panel1.Controls.Add(this.Contraseña);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Location = new System.Drawing.Point(223, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 387);
            this.panel1.TabIndex = 2;
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
            this.Mensaje.Size = new System.Drawing.Size(152, 20);
            this.Mensaje.TabIndex = 4;
            this.Mensaje.Text = "(inserte mensaje ok)";
            this.Mensaje.Click += new System.EventHandler(this.Mensaje_Click);
            // 
            // TextContraseña
            // 
            this.TextContraseña.AutoSize = true;
            this.TextContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContraseña.Location = new System.Drawing.Point(115, 156);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(120, 25);
            this.TextContraseña.TabIndex = 3;
            this.TextContraseña.Text = "Contraseña:";
            // 
            // TextUsuario
            // 
            this.TextUsuario.AutoSize = true;
            this.TextUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsuario.Location = new System.Drawing.Point(115, 86);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(85, 25);
            this.TextUsuario.TabIndex = 2;
            this.TextUsuario.Text = "Usuario:";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(120, 184);
            this.Contraseña.Multiline = true;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(260, 34);
            this.Contraseña.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(120, 114);
            this.Usuario.Multiline = true;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(260, 34);
            this.Usuario.TabIndex = 0;
            // 
            // TextRepetirContraseña
            // 
            this.TextRepetirContraseña.AutoSize = true;
            this.TextRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRepetirContraseña.Location = new System.Drawing.Point(115, 224);
            this.TextRepetirContraseña.Name = "TextRepetirContraseña";
            this.TextRepetirContraseña.Size = new System.Drawing.Size(181, 25);
            this.TextRepetirContraseña.TabIndex = 6;
            this.TextRepetirContraseña.Text = "Repetir contraseña:";
            // 
            // repetirContraseña
            // 
            this.repetirContraseña.Location = new System.Drawing.Point(120, 252);
            this.repetirContraseña.Multiline = true;
            this.repetirContraseña.Name = "repetirContraseña";
            this.repetirContraseña.Size = new System.Drawing.Size(260, 34);
            this.repetirContraseña.TabIndex = 5;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 572);
            this.Controls.Add(this.panel1);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CHATMENU";
            this.Text = "ChatRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextRepetirContraseña;
        private System.Windows.Forms.TextBox repetirContraseña;
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.Label TextContraseña;
        private System.Windows.Forms.Label TextUsuario;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Usuario;
    }
}