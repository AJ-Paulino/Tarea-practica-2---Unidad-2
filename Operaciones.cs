using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_práctica_2___Unidad_2
{
    public class Operaciones
    {
        public void Operacion()
        {
            var lista = new ListaDeNumeros<double>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nIngrese un número (Presione la letra f para finalizar la lista.):");
                string input = Console.ReadLine();

                if (input.ToLower() == "f")
                    break;

                try
                {
                    double numero = double.Parse(input);
                    lista.AgregarNumero(numero);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nEntrada no válida. Por favor, ingrese un valor numérico o presione la letra f para finalizar.");
                }
            }

            Console.WriteLine("\nSeleccione una operación: \n1) Suma \n2) Resta \n3) Multiplicación \n4) División \n5) Salir");
            string opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\nResultado de la suma es: " + lista.RealizarOperacion(lista.Sumar));
                        break;
                    case "2":
                        Console.WriteLine("\nResultado de la resta es: " + lista.RealizarOperacion(lista.Restar));
                        break;
                    case "3":
                        Console.WriteLine("\nResultado de la multiplicación es: " + lista.RealizarOperacion(lista.Multiplicar));
                        break;
                    case "4":
                        Console.WriteLine("\nResultado de la división es: " + lista.RealizarOperacion(lista.Dividir));
                        break;
                    case "5":
                        Console.WriteLine("\nSaliendo...");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\nHa ocurrido un error. {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\nHa ocurrido un error. {ex.Message}");
            }
        }
    }
}
