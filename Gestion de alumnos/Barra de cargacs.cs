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
    public partial class Barra_de_cargacs : Form
    {
        public Barra_de_cargacs()
        {
            InitializeComponent();
        }

        private void Barra_de_cargacs_Load(object sender, EventArgs e)
        {

        }
        public void Cargar_Barra()
        {
            progressBar1.Increment(1);

            if (progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                FormInc frm = new FormInc();
                frm.Show();

            }


        }
                    


    }
}
