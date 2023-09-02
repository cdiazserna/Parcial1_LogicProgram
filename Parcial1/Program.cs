//Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión
//matemática y me permita encontrar el valor de la variable "𝒙"

namespace Parcial1
{
    class Parcial1
    {
        static void Main()
        {
            Random random = new Random();

            double a, b, c, operacion1, operacion2, operacion3;
            int randomNumber = random.Next(24, 33);

            a = randomNumber;
            b = randomNumber;
            c = randomNumber;
            operacion1 = Math.Pow(Math.Pow((3 * a + 4 * b), 3),2) * c ;
            operacion2 = Math.Pow((2 * c + a), 2);
            operacion3 = Math.Sqrt (operacion1 / operacion2);

                Console.WriteLine($"El valor de  x cuando a es ({ a}),b es ({b}) y c es ({c}) X = {operacion3} ");
                
        

        }
    }
}

