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
    public partial class Form4 : Form
    {
        private const string NombreArchivo = @"Alumnos.xml";
        //DataTable TablaAlumnos = new DataTable();
        DataSet TablaAlumnos = new DataSet();
        public Form4()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }
        private void ConfiguracionInicial()
        {
            TablaAlumnos.ReadXml(NombreArchivo);
            CargarLista();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
        }
        private void CargarLista()
        {
            for (int i = 0; i < TablaAlumnos.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(TablaAlumnos.Tables[0].Rows[i][1].ToString());
            }
        }
        private void ComboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            for (int i = 0; i < TablaAlumnos.Tables[0].Rows.Count; i++)
            {
                if (comboBox1.Text == TablaAlumnos.Tables[0].Rows[i][1].ToString())
                {
                    if (TablaAlumnos.Tables[0].Rows[i][0].ToString() == "1")
                    {
                        comboBox2.Text = "Primero";
                    }
                    else if (TablaAlumnos.Tables[0].Rows[i][0].ToString() == "2")
                    {
                        comboBox2.Text = "Segundo";
                    }
                    else if (TablaAlumnos.Tables[0].Rows[i][0].ToString() == "3")
                    {
                        comboBox2.Text = "Tercero";
                    }
                    textBox1.Text = TablaAlumnos.Tables[0].Rows[i][1].ToString();
                    textBox2.Text = TablaAlumnos.Tables[0].Rows[i][2].ToString();
                    textBox3.Text = TablaAlumnos.Tables[0].Rows[i][3].ToString();
                    textBox4.Text = TablaAlumnos.Tables[0].Rows[i][4].ToString();
                    textBox5.Text = TablaAlumnos.Tables[0].Rows[i][6].ToString();
                    textBox6.Text = TablaAlumnos.Tables[0].Rows[i][7].ToString();
                    textBox7.Text = TablaAlumnos.Tables[0].Rows[i][10].ToString();
                    textBox8.Text = TablaAlumnos.Tables[0].Rows[i][8].ToString();
                    textBox9.Text = TablaAlumnos.Tables[0].Rows[i][5].ToString();
                    textBox10.Text = TablaAlumnos.Tables[0].Rows[i][9].ToString();
                }
            }
        }
    }
}
    

