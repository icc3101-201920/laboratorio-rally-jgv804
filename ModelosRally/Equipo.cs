using System;
using System.Collections.Generic;

namespace ModelosRally
{
    public class Equipo
    {
        string nombre;
        List<Vehiculo> vehiculos;
        List<Persona> tripulacion;

        public Equipo(string nombre, Vehiculo vehiculoInicial, Persona piloto, Persona navegante)
        {
            this.nombre = nombre;

            vehiculos = new List<Vehiculo>();
            vehiculos.Add(vehiculoInicial);

            tripulacion = new List<Persona>();
            tripulacion.Add(piloto);
            tripulacion.Add(navegante);
        }

        public bool AgregarVehiculos(Vehiculo vehiculo)
        {
            //Agregar verificaciones
            vehiculos.Add(vehiculo);
            return true;
        }

        public List<Vehiculo> GetListaVehiculos()
        {
            return vehiculos;
        }

    }
}
