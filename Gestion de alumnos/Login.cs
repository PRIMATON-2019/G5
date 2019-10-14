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
        private const string NombreArchivo = @"usuario.xml";
        Form6 frm = new Form6();

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        private System.Data.DataTable Tablausuarios = new DataTable("TablaPersonas");
        #endregion
        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        private void ConfiguracionInicial()
        {
            // diseño de la TablaPersona
            frm.TablaPersona.Columns.Add("Usuario");
            frm.TablaPersona.Columns.Add("Contraseña");
            frm.TablaPersona.Columns.Add("Email");
            frm.TablaPersona.Columns.Add("Tipo");
            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                frm.TablaPersona.ReadXml(NombreArchivo);
            }
        }

        // Llena con string vacio los texbox






        public Login()
        {
            InitializeComponent();
            ConfiguracionInicial();
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            frm.TablaPersona.ReadXml(NombreArchivo);
            frm.TablaPersona.Rows.Add();
            for (int i = 0; i < frm.TablaPersona.Rows.Count; i++)
            {
                if (textBox1.Text == frm.TablaPersona.Rows[i][0].ToString() && textBox2.Text == frm.TablaPersona.Rows[i][1].ToString() && comboBox2.Text == frm.TablaPersona.Rows[i][4].ToString())
                {
                    MessageBox.Show("Bienvenido ", caption: "Inicio de sesion correcto", MessageBoxButtons.OK);
                    Barra_de_cargacs frm2 = new Barra_de_cargacs();
                    this.Hide();
                    frm2.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos",caption:"Error de inicio de sesion",MessageBoxButtons.OK);
                }
            }
            
            //if ((textBox1.Text== "Nombre") && textBox2.Text == "Nombre") { 
            //this.Hide();
            //Barra_de_cargacs frm = new Barra_de_cargacs();
            //frm.Show();
            //}
            //else
            //      MessageBox.Show("Datos incorrectos");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Label4_MouseClick( object sender, MouseEventArgs e )
        {
            Form6 frm = new Form6();
            this.Hide();
            frm.Show();
        }
    }
}
#endregion
