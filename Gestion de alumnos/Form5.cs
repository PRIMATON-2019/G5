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
    public partial class Form5 : Form
    {
        private System.Data.DataTable TablaAlumnos = new DataTable("TablaAlumnos");
        private const string Name = @"Base de Datos.xml";
        public Form5()
        {
            InitializeComponent();
            Precarga();
        }
        public void Precarga()
        {
            if (System.IO.File.Exists(Name))
            {
                TablaAlumnos.ReadXml(Name);
            }
            TablaAlumnos.Columns.Add("Nombre");
            TablaAlumnos.Columns.Add("DNI");
        }
    }
}
