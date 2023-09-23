// See https://aka.ms/new-console-template for more information


class Punto_2
{

    static void Main()
    {
        /* Elabora un algoritmo que imprima los números del 1 al 100. 
         * Que calcule la suma de todos los números pares por un lado, y por otro, 
         * la de todos los impares.*/

        int sumaPares = 0, sumaImpare = 0;

        for (int i = 1;i <= 100 ;i++)
        {

            Console.WriteLine(i);

            if (i%2 == 0)
            {
                sumaPares += i;
               // Console.WriteLine("Numero par: "+i);
            }
            else
            {
                sumaImpare += i;
                //Console.WriteLine("Numero impar: "+i);
            }
        }

        Console.WriteLine($"La suma de los valores pares es {sumaPares} y la suma de los valores impares es {sumaImpare}");
    }

}