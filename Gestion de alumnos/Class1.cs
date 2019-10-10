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
        Form3 frm = new Form3();
        public int AgregarAlumno(String NombreyApellido, DateTime FechaDeNacimiento, Int32 Edad, Int32 Dni, String Domicilio, String Localidad, Int32 Telefono, String EMail, Int32 TelefonoFijo, String Sexo)
        {
            int Valor = 0;
            frm.TablaAlumnos.Rows.Add();
            if (NombreyApellido == "")
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Nombre_y_Apellido"] = NombreyApellido;
            }
            if (FechaDeNacimiento < Convert.ToDateTime("1/1/1900") | FechaDeNacimiento > Convert.ToDateTime("1/1/2020"))
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Fecha_de_Nacimiento"] = FechaDeNacimiento;
            }
            if (Edad == 0)
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Edad"] = Edad;
            }
            if (Dni == 0)
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["DNI"] = Dni;
            }
            if (Domicilio == "")
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Domicilio"] = Domicilio;
            }
            if (Localidad == "")
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Localidad"] = Localidad;
            }
            if (Telefono == 0)
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Telefono"] = Telefono;
            }
            if (EMail == "")
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["E_mail"] = EMail;
            }            
            if (Sexo == "")
            {
                Valor++;
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Genero"] = Sexo;
            }
            return Valor;
        }
    }
}
