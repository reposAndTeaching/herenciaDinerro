using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaDinerro.model
{
    class Billete : Dinero
    {
        private double largo;
        private double ancho;

        public Billete(int miValor, string miValorEnPalabras, double largo, double ancho, string color):base(miValor, miValorEnPalabras)
        {
            this.Largo = largo;
            this.Ancho = ancho;
            this.Color = color;
        }

        public double Largo { get => largo; set => largo = value; }
        public double Ancho { get => ancho; set => ancho = value; }

        public double obtenerPerímetro()
        {
            return (Largo * 2) + (Ancho * 2);
        }
    }
}
