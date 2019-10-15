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
    public partial class Form3 : Form
    {
        private const string Alumnosxml = @"Alumnos.xml";
        public DataTable TablaAlumnos = new DataTable("TablaAlumnos");
        Class1 AlumnosR = new Class1();
        public Form3()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }
        public void ConfiguracionInicial()
        {
            TablaAlumnos.Columns.Add("Año");
            TablaAlumnos.Columns.Add("Nombre_y_Apellido");
            TablaAlumnos.Columns.Add("Fecha_de_Nacimiento");
            TablaAlumnos.Columns.Add("Edad");
            TablaAlumnos.Columns.Add("DNI");
            TablaAlumnos.Columns.Add("Domicilio");
            TablaAlumnos.Columns.Add("Localidad");
            TablaAlumnos.Columns.Add("Telefono");
            TablaAlumnos.Columns.Add("Telefono_Fijo");
            TablaAlumnos.Columns.Add("Genero");
            TablaAlumnos.Columns.Add("E_mail");
            TablaAlumnos.Columns.Add("Matematica");
            TablaAlumnos.Columns.Add("Sistema");
            TablaAlumnos.Columns.Add("Programacion");
            TablaAlumnos.Columns.Add("Arquitectura");
            TablaAlumnos.Columns.Add("Ingles");
            TablaAlumnos.Columns.Add("Lengua");
        }
        #region Guardar Datos
        private void Button3_Click( object sender, EventArgs e )
        {
            Class1 Alumnos = new Class1();
            if (Alumnos.VerificarVacios(comboBox2.Text, textBox1.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt16(textBox3.Text), Convert.ToInt64(textBox4.Text), textBox5.Text, textBox6.Text, Convert.ToInt64(textBox7.Text), textBox8.Text, textBox10.Text) == true)
            {
                TablaAlumnos.Rows.Add();
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Nombre_y_Apellido"] = textBox1.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Fecha_de_Nacimiento"] = dateTimePicker1.Value;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Edad"] = textBox3.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["DNI"] = textBox4.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Domicilio"] = textBox5.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Localidad"] = textBox6.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Telefono"] = textBox7.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["E_mail"] = textBox8.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Telefono_Fijo"] = textBox9.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Genero"] = textBox10.Text;
                if (checkBox1.Checked)
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Matematica"] = "1";
                }
                else
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Matematica"] = "0";
                }
                if (checkBox2.Checked)
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Sistema"] = "1";
                }
                else
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Sistema"] = "0";
                }
                if (checkBox3.Checked)
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Programacion"] = "1";
                }
                else
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Programacion"] = "0";
                }
                if (checkBox4.Checked)
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Arquitectura"] = "1";
                }
                else
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Arquitectura"] = "0";
                }
                if (checkBox5.Checked)
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Ingles"] = "1";
                }
                else
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Ingles"] = "0";
                }
                if (checkBox6.Checked)
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Lengua"] = "1";
                }
                else
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Lengua"] = "0";
                }
                if (comboBox2.Text == "Primero")
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Año"] = 1;
                }
                else if (comboBox2.Text == "Segundo")
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Año"] = 2;
                }
                else if (comboBox2.Text == "Tercero")
                {
                    TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Año"] = 3;
                }
                MessageBox.Show("Guardado Exitoso");
                TablaAlumnos.WriteXml(Alumnosxml);
            }
            else
            {
                MessageBox.Show( "No se admiten campos vacios", caption:"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
