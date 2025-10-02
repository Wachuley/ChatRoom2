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

namespace ChatRoom
{
    public partial class Form2: Form
    {
        private STARTMENU _mainForm;
        public Form2(STARTMENU mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
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
    }
}
