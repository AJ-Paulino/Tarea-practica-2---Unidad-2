using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_práctica_2___Unidad_2
{
    public class ListaDeNumeros<T>
    {
        private List<T> numeros = new List<T>();

        public void AgregarNumero(T numero)
        {
            numeros.Add(numero);
        }

        public T Sumar()
        {
            dynamic suma = 0;
            foreach (var numero in numeros)
            {
                suma += (dynamic)numero;
            }
            return suma;
        }

        public T Restar()
        {
            if (numeros.Count < 2)
                throw new InvalidOperationException("Debe ingresar más de un número para realizar una resta.");

            dynamic resta = (dynamic)numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                resta -= (dynamic)numeros[i];
            }
            return resta;
        }

        public T Multiplicar()
        {
            dynamic producto = 1;
            foreach (var numero in numeros)
            {
                producto *= (dynamic)numero;
            }
            return producto;
        }

        public T Dividir()
        {
            if (numeros.Count < 2)
                throw new InvalidOperationException("Debe ingresar al menos un divisor y un dividendo para realizar la división.");

            dynamic division = (dynamic)numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                if ((dynamic)numeros[i] == 0)
                    throw new DivideByZeroException("No se puede dividir entre cero.");

                division /= (dynamic)numeros[i];
            }
            return division;
        }
    }
}
