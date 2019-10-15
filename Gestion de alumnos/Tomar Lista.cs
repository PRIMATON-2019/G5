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
        DataSet Tomarlista = new DataSet();
        private const string NombreArchivo = @"Alumnos.xml";
        public Form5()
        {
            InitializeComponent();
            Precarga();
            CargarLista();
        }
        public void Precarga()
        {
            if (System.IO.File.Exists(NombreArchivo))
            {
                Tomarlista.ReadXml(NombreArchivo);
            }
            else
            {
                MessageBox.Show("No existen alumnos para tomar lista",caption:"No se encontraron datos",MessageBoxButtons.OK);
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
        }

        private void Form5_Load( object sender, EventArgs e )
        {
            Form6 frm6 = new Form6();
            DataTable A = new DataTable();
            A = frm6.TablaPersona;
            comboBox1.Text = A.Rows[0][3].ToString();
        }
        private void CargarLista()
        {
            for (int i = 0; i < Tomarlista.Tables[0].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(Tomarlista.Tables[0].Rows[i]);
            }
        }
    }
}
