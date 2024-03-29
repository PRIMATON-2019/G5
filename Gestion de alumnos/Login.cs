﻿using System;
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
        public string Z;
        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"usuario.xml";
        Form6 frm = new Form6();

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public System.Data.DataTable Tablausuarios = new DataTable("TablaPersonas");
        #endregion
        #region METODOS

        /// <summary>
        /// Diseña columnas del datatable, 
        /// verifica si el archivo existe previamente
        /// asigna tabla al DataGridView
        /// </summary>
        private void ConfiguracionInicial()
        {
            // diseño de la TablaPersona;
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
                if (textBox1.Text == frm.TablaPersona.Rows[i][0].ToString() && textBox3.Text == frm.TablaPersona.Rows[i][1].ToString() && comboBox1.Text == frm.TablaPersona.Rows[i][3].ToString())
                {
                        MessageBox.Show("Bienvenido " + textBox1.Text, caption: "Inicio de sesion correcto", MessageBoxButtons.OK);
                        FormInc f2 = new FormInc();
                        //pones la instancia y te apareceran los campos que desees mandar 
                        f2.label1.Text = textBox1.Text;
                        f2.label2.Text = " Profesor";
                        //muestras el formulario al que se enviaron los datos
                        this.Hide();
                        f2.Show();
                    Form5 frm2 = new Form5();
                    Z = frm.TablaPersona.Rows[i][3].ToString();
                }
                else if (textBox1.Text != frm.TablaPersona.Rows[i][0].ToString() && textBox3.Text != frm.TablaPersona.Rows[i][1].ToString() && comboBox1.Text != frm.TablaPersona.Rows[i][3].ToString())
                {
                    MessageBox.Show("Datos Incorrectos", caption: "Error de inicio de sesion", MessageBoxButtons.OK);
                }

                else if (textBox1.Text == frm.TablaPersona.Rows[i][0].ToString() && textBox3.Text != frm.TablaPersona.Rows[i][1].ToString() && comboBox1.Text != frm.TablaPersona.Rows[i][3].ToString())
                {

                    MessageBox.Show("Datos Incorrectos", caption: "Error de inicio de sesion", MessageBoxButtons.OK);

                }
                else if (textBox1.Text != frm.TablaPersona.Rows[i][0].ToString() && textBox3.Text == frm.TablaPersona.Rows[i][1].ToString() && comboBox1.Text != frm.TablaPersona.Rows[i][3].ToString())
                {

                    MessageBox.Show("Datos Incorrectos", caption: "Error de inicio de sesion", MessageBoxButtons.OK);

                }
                else if (textBox1.Text != frm.TablaPersona.Rows[i][0].ToString() && textBox3.Text == frm.TablaPersona.Rows[i][1].ToString() && comboBox1.Text == frm.TablaPersona.Rows[i][3].ToString())
                {

                    MessageBox.Show("Datos Incorrectos", caption: "Error de inicio de sesion", MessageBoxButtons.OK);

                }

                break;
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
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {


            if (textBox3.Text == "Contraseña")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.LightGray;
                textBox3.UseSystemPasswordChar = true;
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

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

#endregion
