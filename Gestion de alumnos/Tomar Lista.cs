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
    public partial class Form5 : Form
    {
        DataTable Tomarlista = new DataTable();
        Form3 frm = new Form3();
        private const string Name = @"Alumnos.xml";
        public Form5()
        {
            InitializeComponent();
            Precarga();
        }
        public void Precarga()
        {
            Tomarlista.Columns.Add();
            Tomarlista.Columns.Add();
            if (System.IO.File.Exists(Name))
            {
                Tomarlista.ReadXml(Name);
            }
            else
            {
                MessageBox.Show("No existen alumnos para tomar lista",caption:"No se encontraron datos",MessageBoxButtons.OK);
                frm.Show();
                this.Hide();
            }
        }
    }
}
