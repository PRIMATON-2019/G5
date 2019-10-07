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


        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"usuarios.xml";


        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        private System.Data.DataTable Tablausuarios = new DataTable("TablaPersonas");
        #endregion


























        private void BtGrabar_Click(object sender, EventArgs e)
        {
            Tablausuarios.WriteXml(NombreArchivo);
        }
           

        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        private void ConfiguracionInicial()
        {
            // diseño de la TablaPersona
            Tablausuarios.Columns.Add("Nombre");
            Tablausuarios.Columns.Add("Contraseña");
            Tablausuarios.Columns.Add("DNI");
            Tablausuarios.Columns.Add("Edad");

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                Tablausuarios.ReadXml(NombreArchivo);
            }

           
         
        }

        // Llena con string vacio los texbox






        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();

            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {





            if ((textBox1.Text== "Nombre") && textBox2.Text == "Nombre") { 
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
#endregion
