

namespace Punto1
{
    public class Punto1
    {
        static void Main(string[] args)
        {
            //Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión matemática  
            // y me permita encontrar el valor de la variable "x":
            double a, b, c, x;

            Random random = new Random();

             a = random.Next(3, 12);

             b = random.Next(2, 10);

             c = random.Next(4, 13);

            x = (double)Math.Sqrt((Math.Pow(2, Math.Pow(3, (6 * a) + (7 * b))) * c) / Math.Pow(2, (4 * c) + a));

            Console.WriteLine("Los números para hacer el programa son: " + a + "" + b + "y" + c);
            Console.WriteLine("El valor de la variable x, es: "+x);


            


    
        
     

        }

    }
















}














