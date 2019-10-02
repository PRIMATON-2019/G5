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
        Form5 frm = new Form5();
        Form3 frm3 = new Form3();
        public bool AgregarAlumno(String NombreyApellido, DateTime FechaDeNacimiento, int Edad, int Dni, String Domicilio, String Localidad, int Telefono, String EMail, int TelefonoFijo, String Sexo)
        {
            string msg = "";
            bool Valor = false;
            if (NombreyApellido == "")
            {
                msg = "El campo 'Nombre y Apellido' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Nombre"] = NombreyApellido;
            }
            if (FechaDeNacimiento < Convert.ToDateTime("1/1/1900") && FechaDeNacimiento > Convert.ToDateTime("1/1/2020"))
            {
                msg = msg + "El campo 'Fecha de Nacimiento' esta fuera de los limites" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Fecha de Nacimiento"] = FechaDeNacimiento;
            }
            if (Edad == 0)
            {
                msg = msg + "El campo 'Edad' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Edad"] = Edad;
            }
            if (Dni == 0)
            {
                msg = msg + "El campo 'Dni' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Dni"] = Dni;
            }
            if (Domicilio == "")
            {
                msg = msg + "El campo 'Domicilio' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Domicilio"] = Domicilio;
            }
            if (Localidad == "")
            {
                msg = msg + "El campo 'Localidad' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Localidad"] = Localidad;
            }
            if (Telefono == 0)
            {
                msg = msg + "El campo 'Telefono' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Telefono"] = Telefono;
            }
            if (EMail == "")
            {
                msg = msg + "El campo 'E-mail' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["E-Mail"] = EMail;
            }
            if (TelefonoFijo == 0)
            {
                msg = msg + "El campo 'TelfonoFijo' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Fijo"] = TelefonoFijo;
            }
            if (Sexo == "")
            {
                msg = msg + "El campo 'Sexo' esta vacio" + "\r\n";
            }
            else
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Genero"] = Sexo;
            }
            return Valor;
        }
    }
}
