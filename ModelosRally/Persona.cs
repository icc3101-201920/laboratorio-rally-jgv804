using System;
using System.Collections.Generic;
using System.Text;

namespace ModelosRally
{
    public enum Rol { Piloto, Navegante };
    public class Persona
    {
        string nombre;
        Rol rol;

        public Persona(string nombre, Rol rol)
        {
            this.nombre = nombre;
            this.rol = rol;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public Rol GetRol()
        {
            return rol;
        }

        public override string ToString()
        {
            return nombre + " - " + rol;
        }

    }
}
