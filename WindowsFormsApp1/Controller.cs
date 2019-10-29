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
        Form1 vistaPilotos;

        public Controller(Form1 vistaPilotos)
        {
            Pilotos = new List<Persona>();
            this.vistaPilotos = vistaPilotos;
            this.vistaPilotos.OnAgregarPiloto += VistaPilotos_OnAgregarPiloto;
            this.vistaPilotos.OnAgregarNavegante += VistaPilotos_OnAgregarNavegante;
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




    }
}
