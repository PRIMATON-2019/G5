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
    public partial class perfil : Form
    {
        private const string NombreArchivo = @"usuario.xml";

        /// <summary>
        /// Tabla en memoria con la lista de personas
        /// </summary>
        public System.Data.DataTable TablaPersona = new DataTable("TablaPersonas");
        public perfil()
        {
            InitializeComponent();

            ConfiguracionInicial();

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }
       

          

            private void ConfiguracionInicial()
            {

            Login inicio = new Login();
            label1.Text = inicio.textBox1.Text;


            // diseño de la TablaPersona
            TablaPersona.Columns.Add("usuario");
                TablaPersona.Columns.Add("contraseña");
                TablaPersona.Columns.Add("email");
                TablaPersona.Columns.Add("tipo");


                // busca si el archivo ya existe para precargar sus datos
                if (System.IO.File.Exists(NombreArchivo))
                {
                    TablaPersona.ReadXml(NombreArchivo);
                }

                /* asigna TablaPersona a dgvPersonas
                dgvPersonas.DataSource = TablaPersona;
                // elimina la posibilidad de ingresar datos en el datagridview
                dgvPersonas.AllowUserToAddRows = false;
                elimina el encabezado de las filas
                dgvPersonas.RowHeadersVisible = false;    */
            }
            private void Button1_Click_1(object sender, EventArgs e)
            {

        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("tipo no espesificado.", "Presione ok para redirigir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textemail.Text != "" && comboBox1.Text != "" && txtusuario.Text != "" && textcontraseña.Text != "")
            {
                TablaPersona.Rows.Add();
                LlenaRegistroTabla();
                txtusuario.Focus();
                TablaPersona.WriteXml(NombreArchivo);
                MessageBox.Show("Usuario creado con exito.",
      "Presione ok para redirigir", MessageBoxButtons.OK,
          MessageBoxIcon.Information);
                this.Hide();
                Login frm = new Login();
                frm.Show();
            }
            else MessageBox.Show("Complete todos los campos.", "Presione ok para redirigir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LlenaRegistroTabla()
        {

            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["usuario"] = txtusuario.Text;
            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["contraseña"] = textcontraseña.Text;
            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["email"] = textemail.Text;
            TablaPersona.Rows[TablaPersona.Rows.Count - 1]["tipo"] = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();

            //pones la instancia y te apareceran los campos que desees mandar 
            label1.Text = f2.textBox1.Text;

           


        }
    }
    }
