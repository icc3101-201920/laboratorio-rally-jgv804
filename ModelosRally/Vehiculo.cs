using System;
using System.Collections.Generic;
using System.Text;

namespace ModelosRally
{
    public class Vehiculo
    {
        string marca;
        int cilindrada;

        public Vehiculo(string marca, int cilindrada)
        {
            this.marca = marca;
            this.cilindrada = cilindrada;
        }

        public string getMarca()
        {
            return marca;
        }

        public int getCilindrada()
        {
            return cilindrada;
        }

    }
}
