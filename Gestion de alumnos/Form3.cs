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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
            try
            {
                if (Alumnos.AgregarAlumno(textBox1.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text, Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text), textBox10.Text) == true)
                {
                    MessageBox.Show("Se a guardado correctamente");
                }
                else
                {
                    MessageBox.Show("A ocurrido un error y no se guardaron los datos");
                }
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("El unico Campo Vacio permitido es 'Telefono Fijo'", caption:"Campo vacio no permitido", MessageBoxButtons.OK);
            }            
        }
    }
}
