using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;



namespace VistasRally
{
    class Controller
    {
        List<Persona> Pilotos;
        List<Equipo> Equipos;
        Form1 vistaPilotos;

        public Controller(Form1 vistaPilotos)
        {
            Pilotos = new List<Persona>();
            Equipos = new List<Equipo>();
            this.vistaPilotos = vistaPilotos;
            this.vistaPilotos.OnAgregarPiloto += VistaPilotos_OnAgregarPiloto;
            this.vistaPilotos.OnAgregarNavegante += VistaPilotos_OnAgregarNavegante;
            this.vistaPilotos.OnAgregarEquipo += VistaPilotos_OnAgregarEquipo;
         }

        private void VistaPilotos_OnAgregarPiloto(object sender, AgregarPilotoEventArgs e)
        {
            Persona piloto = new Persona(e.nombre, Rol.Piloto);
            Pilotos.Add(piloto);
            vistaPilotos.ActualizarListadoPilotos(piloto);
            vistaPilotos.ActualizarAsignarPilotos(piloto);
            
        }
        private void VistaPilotos_OnAgregarNavegante(object sender, AgregarNaveganteEventArgs e)
        {
            Persona piloto = new Persona(e.nombre, Rol.Navegante);
            Pilotos.Add(piloto);
            vistaPilotos.ActualizarListadoPilotos(piloto);
            vistaPilotos.ActualizarAsignarNavegantes(piloto);
        }
        private void VistaPilotos_OnAgregarEquipo(object sender, AgregarEquipoEventArgs e)
        {
            Equipo equipo = new Equipo(e.nombre, e.vehiculo,e.piloto,e.navegante );
            Equipos.Add(equipo);
            vistaPilotos.ActualizarListadoEquipos(equipo);
            
        }




    }
}
