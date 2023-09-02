using System;

//Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado. 
//Debemos pedir por pantalla el nombre del empleado, el cargo, horas trabajadas y valor de la hora

namespace punto1
{
    public class Punto1
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string nomEmple, cargoEmple;
            
            decimal salud, pension, embargo, salarioBase, salarioFinal, horasTrab, valorHora;

            //solicitar datos de entrada por pantalla

            Console.Write("Por favor ingresar el nombre del empleado: ");
            nomEmple = Convert.ToString(Console.ReadLine());

            Console.Write("Por favor ingresar el cargo del empleado: ");
            cargoEmple = Convert.ToString(Console.ReadLine());

            Console.Write("Por favor ingresar las horas trabajadas del empleado: ");
            horasTrab = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Por favor ingresar las horas trabajadas del empleado: ");
            valorHora  = Convert.ToDecimal(Console.ReadLine());


            //calcular problema

            //calcular salario base

            salarioBase = horasTrab * valorHora;

            //salud
            salud = (salarioBase * 4) / 100;

            //pension
            pension = (salarioBase * 4) / 100;

            embargo = (salarioBase / 4);

            //salario final

            salarioFinal = (salarioBase - salud - pension - embargo);

            Console.Write("El nombre del empleado es: " + nomEmple);
            Console.Write("\n");
            Console.Write("El cargo del empleado es: " + cargoEmple);
            Console.Write("\n");
            Console.Write("El salario base es " + salarioBase);
            Console.Write("\n");
            Console.Write("El salario final es" + salarioFinal);
            Console.Write("\n");



















        }
    }
}
