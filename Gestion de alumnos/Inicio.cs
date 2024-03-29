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
    public partial class FormInc : Form
    {
        public FormInc()
        {
            InitializeComponent();
            elmenu(); // inicializamos

        }
        private void elmenu()
        {            // los tres se ocultan para dar el efecto en los paneles
            panelPerfil.Visible = false; // primer panel
            panelacciones.Visible = false; // segundo panel
            panelconfiguracion.Visible = false; // tercer panel
        }
        private void abrirpaneles( Panel abierto ) //tipo panel de nombre abierto
        {
            if (abierto.Visible == false) // si no esta visible 
            {
                elmenu();
                abierto.Visible = true;// lo cambiamos a verdader, el panel se muestra
            }
            else
                abierto.Visible = false; // peroooo si el si esta abierto se cierra
        }
        private void BtnMedia_Click( object sender, EventArgs e )
        {
            abrirpaneles(panelPerfil);
        }
        private void Button4_Click( object sender, EventArgs e )
        {
            abrirpaneles(panelacciones);
        }
        private void Button13_Click( object sender, EventArgs e )
        {
            openChildForm(new Form3());
        }
        private void BtnHelp_Click( object sender, EventArgs e )
        {
            abrirpaneles(panelconfiguracion);
        }
        private void Button12_Click( object sender, EventArgs e )
        {
            //Form5 frm = new Form5();
            //this.Hide();
            //frm.Show();
            openChildForm(new Form5());
        }
        private void BtnSalir_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }
        private Form activeForm = null;
        private void openChildForm( Form childForm )
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Button6_Click( object sender, EventArgs e )
        {





            perfil f2 = new perfil();
            //pones la instancia y te apareceran los campos que desees mandar 
            f2.label1.Text = label1.Text;
            

            f2.Show();
            openChildForm(new perfil());
        }

        private void Button10_Click( object sender, EventArgs e )
        {
            openChildForm(new Form4());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();

           Login frm = new Login();

            frm.Show();
        }
    }
}