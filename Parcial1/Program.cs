//Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión
//matemática y me permita encontrar el valor de la variable "𝒙"

namespace Parcial1
{
    class Parcial1
    {
        static void Main()
        {
            Random random = new Random();

            // Variables

            double randomNumber1 = random.Next(22,30);
            double randomNumber2 = random.Next(22,30);
            double randomNumber3 = random.Next(22,30);
            double a, b, c, operacion1, operacion2, operacion3;
            a = randomNumber1;
            b = randomNumber2;
            c = randomNumber3;
            // Operacion
            operacion1 = Math.Pow(Math.Pow((3 * a + 4 * b), 3),2) * c ;
            operacion2 = Math.Pow((2 * c + a), 2);
            operacion3 = Math.Sqrt (operacion1 / operacion2);
            // Pantalla

                Console.WriteLine($"El valor de  x cuando a es ({ a}),b es ({b}) y c es ({c}) X = {operacion3} ");
                
        

        }
    }
}

