using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_práctica_2___Unidad_2
{
    public class ListaDeNumeros<T>
    {
        public List<T> numeros = new List<T>();

        public void AgregarNumero(T numero)
        {
            numeros.Add(numero);
        }

        public delegate T OperacionMatematica<T>(T a, T b);
        public T Sumar(T a, T b) => (dynamic)a + (dynamic)b;
        public T Restar(T a, T b) => (dynamic)a - (dynamic)b;
        public T Multiplicar(T a, T b) => (dynamic)a * (dynamic)b;
        public T Dividir(T a, T b)
        {
            if ((dynamic)b == 0)
                throw new DivideByZeroException("No es posible dividir por cero. Intente iniciar nuevamente.");
            return (dynamic)a / (dynamic)b;
        }

        public T RealizarOperacion(OperacionMatematica<T> operacion)
        {
            if (numeros.Count < 2)
                throw new InvalidOperationException("La lista debe contener al menos dos números para realizar la operación.");

            T resultado = numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                resultado = operacion(resultado, numeros[i]);
            }
            return resultado;
        }        
    }
}
