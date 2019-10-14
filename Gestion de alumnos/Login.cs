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
            frm.TablaPersona.Columns.Add("Nombre");
            frm.TablaPersona.Columns.Add("Contraseña");
            frm.TablaPersona.Columns.Add("DNI");
            frm.TablaPersona.Columns.Add("Edad");
            frm.TablaPersona.Rows.Add();
            frm.TablaPersona.Rows.Add();
            frm.TablaPersona.Rows.Add();
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
        private void button4_Click_1(object sender, EventArgs e)
        {
          

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
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            frm.TablaPersona.ReadXml(NombreArchivo);






            for (int i = 0; i < frm.TablaPersona.Rows.Count; i++)
            {
                if (textBox1.Text == frm.TablaPersona.Rows[i][0].ToString() && textBox3.Text == frm.TablaPersona.Rows[i][1].ToString())
                {

                    string alumno = "";
                    alumno = frm.TablaPersona.Rows[i][3].ToString();


                    if (alumno == "Alumno")
                    {

                        MessageBox.Show("Bienvenido " + textBox1.Text, caption: "Inicio de sesion correcto", MessageBoxButtons.OK);

                        FormInc f2 = new FormInc();

                        //pones la instancia y te apareceran los campos que desees mandar 
                        f2.label1.Text = textBox1.Text;
                        f2.label2.Text = " Alumno";

                        //muestras el formulario al que se enviaron los datos
                        this.Hide();
                        f2.Show();
                    }
                    else
                    {

                        MessageBox.Show("Bienvenido " + textBox1.Text, caption: "Inicio de sesion correcto", MessageBoxButtons.OK);

                        FormInc f2 = new FormInc();

                        //pones la instancia y te apareceran los campos que desees mandar 
                        f2.label1.Text = textBox1.Text;
                        f2.label2.Text = " Profesor";

                        //muestras el formulario al que se enviaron los datos
                        this.Hide();
                        f2.Show();

                    }

                    break;
                }
                else if (textBox1.Text != frm.TablaPersona.Rows[i][0].ToString() && textBox3.Text != frm.TablaPersona.Rows[i][1].ToString())
                {
                    MessageBox.Show("Datos Incorrectos", caption: "Error de inicio de sesion", MessageBoxButtons.OK);
                }
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            this.Hide();
            frm.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
        }
      
       
        

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Contraseña";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {


            if (textBox3.Text == "Contraseña")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.LightGray;
            }
         
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.Silver;
            }
        }
    }
    }

#endregion
