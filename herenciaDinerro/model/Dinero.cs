using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaDinerro.model
{
    //CLASE: Mayúscula/Singular
    class Dinero
    {
        //ATRIBUTOS
        private int valor;
        private string valorEnPalabras;
        protected string color;

        public int Valor { get => valor; set => valor = value; }
        public string ValorEnPalabras { get => valorEnPalabras; set => valorEnPalabras = value; }
        public string Color { get => color; set => color = value; }

        //CONSTRUCTOR
        public Dinero(int miValor, string miValorEnPalabras)
        {
            this.Valor = miValor;
            this.ValorEnPalabras = miValorEnPalabras;
        }

        //MÉTODOS o FUNCIONES
        public string obtenerInfoDinero()
        {
            return $"Tengo un valor de {Valor}, en palabras se lee {ValorEnPalabras} y soy de color {Color}";
        }

        public void setColor(string miColor)
        {
            this.Color = miColor;
        }

    }
}
