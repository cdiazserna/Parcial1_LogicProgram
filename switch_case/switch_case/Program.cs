class Program
{

    static void Main()
    {
        /* Realice un programa que solicite dos
         * números, luego debe pedirse un número que seleccionará
         * alguna operación aritmética desde un menú. Si introduce 1 los números
         * se deben sumar, si introduce 2 los números se deben restar, si es 3 los números
         * se multiplican y si introduce 4 los números se dividen (validar división por cero).
         * Independientemente de la selección, imprima el resultado. Además, el programa debe
         * tener la posibilidad de volver al menú para pedir 2 
         * nuevos números y hacer la elección de la operación aritmética o digitar cero para
         * finalizar el programa.  */


        double num1, num2,operacion;
        bool repetir = false;
        int seleccion;
        String continuar;



        do
        {
            Console.WriteLine("Bienvenido a tu calculadora de confianza");



            Console.WriteLine("Por favor, selecione una opción\n *1 Sumar \n *2 Restar \n *3 Multiplicar \n *4 División");
            seleccion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, dijitar el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor, dijitar el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (seleccion) {

                case 1:
                    operacion = num1 + num2;
                    Console.WriteLine(operacion);
                    break;

                case 2:


                    break;

                case 3:

                    break;

                case 4:

                  
                   break;

                default:
                    Console.WriteLine("Por valide su sorpresa");
                    break;


            }

            

            Console.WriteLine("Desea calcular nuevamente s/n");
            continuar = Console.ReadLine().ToLower();

            if (continuar == "n")
            {
                repetir = false;
            }
            else {
                repetir = true;
            }

        } while (repetir);
    }
}