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
    public partial class Form6 : Form
    {

        #region PROPIEDADES PRIVADAS
        /// <summary>
        /// Path y nombre del archivo
        /// </summary>
        private const string NombreArchivo = @"usuario.xml";

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public System.Data.DataTable TablaPersona = new DataTable("TablaPersonas");
        #endregion

        #region CONSTRUCTOR
        public Form6()
        {
            InitializeComponent();

            ConfiguracionInicial();

        }
        #endregion
        private void ConfiguracionInicial()
        {
            // diseño de la TablaPersona
            TablaPersona.Columns.Add("usuario");
            TablaPersona.Columns.Add("contraseña");
            TablaPersona.Columns.Add("email");
            TablaPersona.Columns.Add("Materia que se dicta");


            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                TablaPersona.ReadXml(NombreArchivo);
            }
            else
            {
                TablaPersona.WriteXml(NombreArchivo);
            }

            /* asigna TablaPersona a dgvPersonas
            dgvPersonas.DataSource = TablaPersona;
            // elimina la posibilidad de ingresar datos en el datagridview
            dgvPersonas.AllowUserToAddRows = false;
            elimina el encabezado de las filas
            dgvPersonas.RowHeadersVisible = false;    */
        }
        private void Button1_Click_1( object sender, EventArgs e )
        {
        }
        private void LlenaRegistroTabla()
        {

            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["usuario"] = txtusuario1.Text;
            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["contraseña"] = textcontraseña.Text;
            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["email"] = textemail.Text;
            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Materia que se dicta"] = comboBox1.Text;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
          
                if (textcontraseña.Text == "contraseña")
                {
                textcontraseña.Text = "";
                textcontraseña.ForeColor = Color.LightGray;
                textcontraseña.UseSystemPasswordChar = true;
                }
        }

       

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            {
                if (textcontraseña.Text == "")
                    textcontraseña.Text = "contraseña";
                textcontraseña.ForeColor = Color.Silver;
                textcontraseña.UseSystemPasswordChar = false;
            }

        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (textemail.Text == "Email")
                textemail.Text = "";
            textemail.ForeColor = Color.Silver;
           
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (textemail.Text == "")
                textemail.Text = "Email";
            textemail.ForeColor = Color.Silver;
          
        }

        private void textcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario1_Enter(object sender, EventArgs e)
        {
            if (txtusuario1.Text == "Usuario")
            {
                txtusuario1.Text = "";
                txtusuario1.ForeColor = Color.LightGray;

            }
        }

       
           

        private void txtusuario1_Leave(object sender, EventArgs e)
        {
            if (txtusuario1.Text == "")
            {
                txtusuario1.Text = "Usuario";
                txtusuario1.ForeColor = Color.Silver;


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void Btnlogin_Click( object sender, EventArgs e )
        {
            TablaPersona.ReadXml(NombreArchivo);
            if (textemail.Text != "" && comboBox1.Text != "" && txtusuario1.Text != "" && textcontraseña.Text != "")
                {
                    TablaPersona.Rows.Add();
                    LlenaRegistroTabla();
                    TablaPersona.WriteXml(NombreArchivo);
                    MessageBox.Show("Usuario creado con exito.",
          "Presione ok para redirigir", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
                    this.Hide();
                    Login frm = new Login();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos.", "Presione ok para redirigir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
