using System;
// : Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión
//matemática y me permita encontrar el valor de la variable "𝒙":
//Los valores de "𝒂", "𝒃" y "𝒄" se adquieren aleatoriamente con el siguiente fragmento de código:
//. Lo primero es generar una instancia de la clase Random dentro del Main(), así:
// Luego, vas a escribir esta línea de código, donde randomNumber es la variable que
//almacenará ese número aleatorio, el min es la variable del el límite inferior del rango, el
//max es la variable del límite superior del rango y Next() es el método de la clase Random,
//l cual generará un número entero aleatorio entre min y max:

namespace Punto1

    // 1 definir clase y metodo
{
    public class Punto1
    {
        static void Main(string[] args)
        {
            // 2 declaracion de variables

            double a, b, c, x;

            //3 pedir datos, los cuales son aleatorios.

            Random random = new Random();

            a = random.Next(1, 8);
            b = random.Next(9, 17);
            c = random.Next(20, 28);

            // 4 calculos

            x = Math.Sqrt((((3* a+4 * b)* (3 * a + 4*b)*(3 * a + 4*b)) *(3 * a + 4*b) * (3 * a + 4*b)*(3 * a + 4*b))/((2 * c + a) * (2 * c + a)));

            // 5 mostrar resultados en pantalla.

            Console.WriteLine($"El resultado de x es: {x}, con los valores de {a}, {b}, {c}");


        }
    }
}
