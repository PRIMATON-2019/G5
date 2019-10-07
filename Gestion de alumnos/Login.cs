using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_alumnos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            String usuario = "admin";
            String password = "123456";
            if ((textBox1.Text== usuario) && textBox2.Text == password) { 
            this.Hide();
            Barra_de_cargacs frm = new Barra_de_cargacs();
            frm.Show();
            }
            else
                  MessageBox.Show("Datos incorrectos");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label4_MouseClick( object sender, MouseEventArgs e )
        {
            Form6 frm = new Form6();
            this.Hide();
            frm.Show();
        }
    }
}
