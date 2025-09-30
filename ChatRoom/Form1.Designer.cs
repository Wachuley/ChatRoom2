namespace ChatRoom
{
    partial class Inicio
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
            this.IniciarSesionBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registrarse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IniciarSesionBtn
            // 
            this.IniciarSesionBtn.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionBtn.Location = new System.Drawing.Point(125, 144);
            this.IniciarSesionBtn.Name = "IniciarSesionBtn";
            this.IniciarSesionBtn.Size = new System.Drawing.Size(250, 66);
            this.IniciarSesionBtn.TabIndex = 0;
            this.IniciarSesionBtn.Text = "Iniciar Sesión";
            this.IniciarSesionBtn.UseVisualStyleBackColor = true;
            this.IniciarSesionBtn.Click += new System.EventHandler(this.IniciarSesionBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registrarse);
            this.groupBox1.Controls.Add(this.IniciarSesionBtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(200, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(500, 387);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // registrarse
            // 
            this.registrarse.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrarse.Location = new System.Drawing.Point(125, 266);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(250, 66);
            this.registrarse.TabIndex = 1;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarSesionBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registrarse;
    }
}

