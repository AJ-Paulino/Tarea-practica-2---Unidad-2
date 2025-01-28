# Tarea práctica 2 - Unidad 2

•Una descripción general de la aplicación.
Esta aplicación maneja una lista de datos numéricos que van siendo ingresados por teclado por el usuario 
hasta que el usuario decida cuántos números tendrá la lista. Debe presionar la letra "f" en el teclado
para finalizar la lista y luego decidir qué tipo de operación realizar con los números de la lista
eligiendo entre 5 opciones, sumar, restar, multiplicar, dividir o salir de la aplicación.


•Explicación de los métodos utilizados.
Métodos de Operaciones Matemáticas: Métodos para sumar, restar, multiplicar y dividir utilizando el delegado.
Método RealizarOperacion: Utiliza el delegado para realizar la operación seleccionada sobre los números de la lista.

•Descripción de las excepciones manejadas.
FormatException: Entrada no válida.
DivideByZeroException: No es posible dividir por cero.
InvalidOperationException: Operación no válida.

•Cómo el código utiliza genéricos y delegados.
Clase Genérica ListaNumeros<T>: Maneja una lista de números de tipo genérico y realiza operaciones matemáticas sobre ellos.
Delegado OperacionMatematica<T>: Representa las operaciones matemáticas que se pueden realizar con los números de la lista.