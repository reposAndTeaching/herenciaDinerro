using System;
using herenciaDinerro.model;

namespace herenciaDinerro
{
    class Program
    {
        static void Main(string[] args)
        {

            //PascalCase
            //camelCase
            //snake_case

            int opcion = -1;

            while(opcion != 0)
            {
                Console.WriteLine("Bienvenida/o");
                Console.WriteLine("ELije una opcion");
                Console.WriteLine("0.- Salir");
                Console.WriteLine("1.- Crear Dinero");
                Console.Write("Ingrese Opción: ");
                //Console.ReadLine: Captura escrito en la consola como "string"
                //Se debe convertir a "int" ya que opcion es de tipo int
                //Esto se hace con Convert.ToInt32
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                switch (opcion) {
                    case 1:
                        {
                            Console.Write("Ingrese valor Dinero: ");
                            int valorDesdeConsola = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            Console.Write("Ingrese Valor en palabras: ");
                            string valorEnPalabrasDesdeConsola = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("Ingrese color: ");
                            string colorDesdeConsola = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Deseo Crear un/a: ");
                            Console.WriteLine("1.-Moneda");
                            Console.WriteLine("2.-Billete");
                            Console.Write("Opción");
                            int opcionDinero = Convert.ToInt32(Console.ReadLine());
                            if (opcionDinero == 1)
                            {
                                CrearMoneda(valorDesdeConsola, valorEnPalabrasDesdeConsola, colorDesdeConsola);
                            }else if (opcionDinero == 2)
                            {
                                CrearBillete(valorDesdeConsola, valorEnPalabrasDesdeConsola, colorDesdeConsola);
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ingrese una opción válida!!!");
                            break;
                        }
                }

            }

            void CrearMoneda(int valor, string valorEnPalabras, string color)
            {
                Console.Write("Ingrese peso: ");
                double pesoPorConsola = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Ingrese Lados: ");
                int ladosPorConsola = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Moneda nuevaMoneda = new Moneda(valor, valorEnPalabras, pesoPorConsola, ladosPorConsola, color);
                Console.WriteLine("Moneda Creada!");
                Console.WriteLine($"Valor: {nuevaMoneda.Valor}");
                Console.WriteLine($"En Palabras: {nuevaMoneda.ValorEnPalabras}");
                Console.WriteLine($"Color: {nuevaMoneda.Color}");
                Console.WriteLine($"Peso: {nuevaMoneda.Peso}");
                Console.WriteLine($"Lados: {nuevaMoneda.Lados}");
                Console.WriteLine($"Forma: {nuevaMoneda.formaDeMoneda()}");
                //Función clase padre
                Console.WriteLine($"{nuevaMoneda.obtenerInfoDinero()}");
                Console.WriteLine("");
            }

            void CrearBillete(int valor, string valorEnPalabras, string color)
            {
                Console.Write("Ingrese largo: ");
                double largoPorConsola = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Ingrese Ancho: ");
                double anchoPorConsola = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Billete nuevoBillete = new Billete(valor, valorEnPalabras, largoPorConsola, anchoPorConsola, color);
                Console.WriteLine("Billete Creado!");
                Console.WriteLine($"Valor: {nuevoBillete.Valor}");
                Console.WriteLine($"En Palabras: {nuevoBillete.ValorEnPalabras}");
                Console.WriteLine($"Color: {nuevoBillete.Color}");
                Console.WriteLine($"Ancho: {nuevoBillete.Ancho}");
                Console.WriteLine($"Largo: {nuevoBillete.Largo}");
                Console.WriteLine($"Perímetro: {nuevoBillete.obtenerPerímetro()}");
                //Podemos usar la función de la clase padre
                Console.WriteLine($"{nuevoBillete.obtenerInfoDinero()}");
                Console.WriteLine("");
            }


        }
    }




}
