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
        public bool VerificarVacios(string Nombre, DateTime FechaDeNacimiento, Int32 Edad, Int32 Dni, string Domicilio, string Localidad, Int32 Telefono, String EMail, Int32 TelefonoFijo, string Genero)
        {
            bool Verificar = false;
            int Valor = 0;
            if (Nombre == "")
            {
                Valor++;
            }
            if (FechaDeNacimiento < Convert.ToDateTime("1/1/1900") | FechaDeNacimiento > Convert.ToDateTime("1/1/2020"))
            {
                Valor++;
            }
            if (Edad == 0)
            {
                Valor++;
            }
            if (Dni == 0)
            {
                Valor++;
            }
            if (Domicilio == "")
            {
                Valor++;
            }
            if (Localidad == "")
            {
                Valor++;
            }
            if (Telefono == 0)
            {
                Valor++;
            }
            if (EMail == "")
            {
                Valor++;
            }
            if (Genero == "")
            {
                Valor++;
            }
            if (Valor == 0)
            {
                Verificar = true;
            }
            return Verificar;
        }
    }
}
