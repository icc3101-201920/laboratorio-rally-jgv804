using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelosRally;

namespace WindowsFormsApp1
{
    public class AgregarEquipoEventArgs : EventArgs
    {
        public string nombre { get; set; }
        public Persona piloto { get; set; }
        public Persona navegante { get; set; }
        public Vehiculo vehiculo { get; set; }
    }
}
