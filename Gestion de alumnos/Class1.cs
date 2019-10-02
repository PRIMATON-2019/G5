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
        public bool AgregarAlumno(String NombreyApellido, DateTime FechaDeNacimiento, int Edad, int Dni, String Domicilio, String Localidad, int Telefono, String EMail, int TelefonoFijo, String Sexo)
        {
            bool Valor = false;
            try
            {
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Nombre"] = NombreyApellido;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Fecha de Nacimiento"] = FechaDeNacimiento;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Edad"] = Edad;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Dni"] = Dni;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Domicilio"] = Domicilio;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Localidad"] = Localidad;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Telefono"] = Telefono;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["E-Mail"] = EMail;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Fijo"] = TelefonoFijo;
                frm.TablaAlumnos.Rows[frm.TablaAlumnos.Rows.Count - 1]["Genero"] = Sexo;
                Valor = true;
            }
            catch (NoNullAllowedException)
            {
                Valor = false;
            }
            return Valor;
        }
    }
}
