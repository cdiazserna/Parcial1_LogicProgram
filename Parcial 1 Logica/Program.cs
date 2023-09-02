//Realice un programa en C# donde se tenga la posibilidad de evaluar la siguiente expresión matemática
//y me permita encontrar el valor de la variable "𝒙":


public class parcial1

{

    static void Main(String[] args)

    {

        Random randon = new Random();

        double numeroAleatorio;

        numeroAleatorio = randon.Next(-8, 8);

        // Crear una instancia de la clase Random
        Random random = new Random();

        
        double a = random.NextDouble() * 8; 
        double b = random.NextDouble() * 8; 
        double c = random.NextDouble() * 8; 

        double x = CalcularX(a, b, c);

        Console.WriteLine($"El valor aleatorio de 'a' es: {a}");
        Console.WriteLine($"El valor aleatorio de 'b' es: {b}");
        Console.WriteLine($"El valor aleatorio de 'c' es: {c}");
        Console.WriteLine("El valor de 'x' calculado es: " + x);
    }

    static double CalcularX(double a, double b, double c)
    {
        double numerador = Math.Pow(Math.Pow(3 * a + 4 * b, 3), 2) * c;
        double denominador = Math.Pow(2 * c + a, 2);

        double x = Math.Sqrt(numerador / denominador);

        return x;
    }


}

