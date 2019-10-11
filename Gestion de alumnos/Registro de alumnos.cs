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
        }
        private void Button2_Click( object sender, EventArgs e )
        {
            this.Hide();
            FormInc frm = new FormInc();
            frm.Show();
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            Class1 Alumnos = new Class1();
            if (Alumnos.VerificarVacios(textBox1.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text, Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text), textBox10.Text) == true)
            {
                TablaAlumnos.Rows.Add();
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Nombre_y_Apellido"] = textBox1.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Fecha_de_Nacimiento"] = dateTimePicker1;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Edad"] = textBox3.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["DNI"] = textBox4.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Domicilio"] = textBox5.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Localidad"] = textBox6.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Telefono"] = textBox7.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["E_mail"] = textBox8.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Telefono_Fijo"] = textBox9.Text;
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Genero"] = textBox10.Text;
                MessageBox.Show("Guardado Exitoso");
                TablaAlumnos.WriteXml(Alumnosxml);
            }
            else
            {
                MessageBox.Show( "El unico campo vacio admitido es 'Telefono Fijo'", caption:"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        
    }
}
