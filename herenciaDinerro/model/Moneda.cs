using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaDinerro.model
{
    class Moneda : Dinero
    {
        private double peso;
        private int lados;

        public Moneda(int miValor, string miValorEnPalabras):base(miValor, miValorEnPalabras)
        {

        }

        public Moneda(int miValor, string miValorEnPalabras, double miPeso, int miLados):base(miValor, miValorEnPalabras)
        {
            this.Lados = miLados;
            this.Peso = miPeso;
           
        }

        public Moneda(int miValor, string miValorEnPalabras, double miPeso, int miLados, string color) : base(miValor, miValorEnPalabras)
        {
            this.Lados = miLados;
            this.Peso = miPeso;
            this.Color = color;
        }

        public double obtenerPeso()
        {
            return this.peso;
        }

        public double Peso 
        { 
            get => peso;
            set => peso = value; 
        }
        public int Lados { get => lados; set => lados = value; }

        public string formaDeMoneda()
        {
            if (Lados == 0)
            {
                return "Círculo";
            }else if (Lados == 1)
            {
                return "Línea(Valor Inválido)";
            }else if (Lados == 2)
            {
                return "2 Líneas (Valor Inválido)";
            }else if (Lados == 3)
            {
                return "Tríangulo";
            }else if(Lados == 4)
            {
                return "Cuadrado";
            }
            else
            {
                return "EL Número de lados es inválido";
            }
        }
    }
}
