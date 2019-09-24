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
    public partial class FormInc : Form
    {
        public FormInc()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm = new Form3();

            frm.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click( object sender, EventArgs e )
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.Show();
        }
    }
}
