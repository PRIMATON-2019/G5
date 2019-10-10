using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Gestion_de_alumnos
{
    public class Class1
    {
        private const string Alumnosxml = @"Alumnos.xml";
        Form3 frm = new Form3();
        public DataTable TablaAlumnos = new DataTable("TablaAlumnos");
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
        public int AgregarAlumno(String NombreyApellido, DateTime FechaDeNacimiento, Int32 Edad, Int32 Dni, String Domicilio, String Localidad, Int32 Telefono, String EMail, Int32 TelefonoFijo, String Sexo)
        {
            int Valor = 0;
            TablaAlumnos.Rows.Add();
            if (NombreyApellido == "")
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Nombre_y_Apellido"] = NombreyApellido;
            }
            if (FechaDeNacimiento < Convert.ToDateTime("1/1/1900") | FechaDeNacimiento > Convert.ToDateTime("1/1/2020"))
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Fecha_de_Nacimiento"] = FechaDeNacimiento;
            }
            if (Edad == 0)
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Edad"] = Edad;
            }
            if (Dni == 0)
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["DNI"] = Dni;
            }
            if (Domicilio == "")
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Domicilio"] = Domicilio;
            }
            if (Localidad == "")
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Localidad"] = Localidad;
            }
            if (Telefono == 0)
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Telefono"] = Telefono;
            }
            if (EMail == "")
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["E_mail"] = EMail;
            }            
            if (Sexo == "")
            {
                Valor++;
            }
            else
            {
                TablaAlumnos.Rows[TablaAlumnos.Rows.Count - 1]["Genero"] = Sexo;
            }
            if (Valor == 0)
            {
                TablaAlumnos.WriteXml(Alumnosxml);
            }
            return Valor;
        }
    }
}
