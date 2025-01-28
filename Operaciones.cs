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
                Console.WriteLine("Ingrese un número (Presione la letra f para finalizar la lista.):");
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
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un valor numérico o presione la letra f para finalizar.");
                }
            }

            Console.WriteLine("Seleccione una operación: 1) Suma 2) Resta 3) Multiplicación 4) División 5) Salir");
            string opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Resultado de la suma: " + lista.Sumar());
                        break;
                    case "2":
                        Console.WriteLine("Resultado de la resta: " + lista.Restar());
                        break;
                    case "3":
                        Console.WriteLine("Resultado de la multiplicación: " + lista.Multiplicar());
                        break;
                    case "4":
                        Console.WriteLine("Resultado de la división: " + lista.Dividir());
                        break;
                    case "5":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
