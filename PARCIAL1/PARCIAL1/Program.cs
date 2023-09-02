using System;

namespace PARCIAL1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir en pantalla
            Console.WriteLine("Ingrese nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Cargo del empleado: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("Horas trabajadas por el empleado: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de la hora: ");
            double valorHora = double.Parse(Console.ReadLine());

            //Calcular deducciones
            double salarioNeto = horasTrabajadas * valorHora;

            double salud = salarioNeto * 0.04;

            double pension = salarioNeto * 0.04;

            double embargo = salarioNeto / 0.04;

            double salarioTotal = salarioNeto - salud - pension - embargo;

            //


        }
    }
}
