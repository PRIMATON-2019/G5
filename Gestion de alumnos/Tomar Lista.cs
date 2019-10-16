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
            ArmarEstructuraDatagrid();
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
        private void ArmarEstructuraDatagrid()
        {
            DataGridViewColumn Año = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            Año.CellTemplate = cell;
            Año.Name = "Año";

            DataGridViewColumn NombreApellido = new DataGridViewColumn();
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            NombreApellido.CellTemplate = cell2;
            NombreApellido.Name = "NombreApellido";

            DataGridViewColumn Dni = new DataGridViewColumn();
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            Dni.CellTemplate = cell3;
            Dni.Name = "Dni";
        }
        private void Form5_Load_1( object sender, EventArgs e )
        {
            Form6 frm6 = new Form6();
            DataTable A = new DataTable();
            A = frm6.TablaPersona;
            switch (textBox1.Text)
            {
                case "Matematica y Logica":
                    for (int i = 0; i < frm6.TablaPersona.Rows.Count; i++)
                    {
                        if (textBox1.Text == A.Rows[i][3].ToString())
                        {
                            dataGridView1.Rows.Add(A.Rows[i]);
                        }
                    }
                break;
                case "Sistema y Organizaciones":
                    for (int i = 0; i < frm6.TablaPersona.Rows.Count; i++)
                    {
                        if (textBox1.Text == A.Rows[i][3].ToString())
                        {
                            dataGridView1.Rows.Add(A.Rows[i]);
                        }
                    }
                    break;
                case "Arquitectura de las Computadoras":
                    for (int i = 0; i < frm6.TablaPersona.Rows.Count; i++)
                    {
                        if (textBox1.Text == A.Rows[i][3].ToString())
                        {
                            dataGridView1.Rows.Add(A.Rows[i]);
                        }
                    }
                    break;
                case "Ingles":
                    for (int i = 0; i < frm6.TablaPersona.Rows.Count; i++)
                    {
                        if (textBox1.Text == A.Rows[i][3].ToString())
                        {
                            dataGridView1.Rows.Add(A.Rows[i]);
                        }
                    }
                    break;
                case "Programacion":
                    for (int i = 0; i < frm6.TablaPersona.Rows.Count; i++)
                    {
                        if (textBox1.Text == A.Rows[i][3].ToString())
                        {
                            dataGridView1.Rows.Add(A.Rows[i]);
                        }
                    }
                    break;
                case "Lengua y Comunicacion":
                    for (int i = 0; i < frm6.TablaPersona.Rows.Count; i++)
                    {
                        if (textBox1.Text == A.Rows[i][3].ToString())
                        {
                            dataGridView1.Rows.Add(A.Rows[i]);
                        }
                    }
                    break;
            }
        }

        private void TextBox1_TextChanged( object sender, EventArgs e )
        {

        }
    }
}

