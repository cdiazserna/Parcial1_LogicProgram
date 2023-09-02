// See Realice un programa en C# donde se tenga la posibilidad
// de evaluar la siguiente expresión matemáticay me permita encontrar el valor de la variable "𝒙":

public class taller

{
  static void Main(string[] args)

    {
        //Los valores de "𝒂", "𝒃"y "𝒄"se adquieren aleatoriamentecon el siguiente fragmento de código
        double a, b, c,x;

            Random random = new Random();
            
        a = random.Next(3, 9);

        b = random.Next(8, 16);  

        c = random.Next(2, 4);

        x = (3 * a + 4 * b);
        x = x * x * x;
        x = (x * c);
        x = (x * c);
        x = (2 * c + a);
        x = x * x;



      


      

    }
}