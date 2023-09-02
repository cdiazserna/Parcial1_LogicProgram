using System;

class Program
{
    static void Main()
    {
        // Solicitar información del empleado
        Console.WriteLine("Calculadora de Nómina Mensual");
        Console.Write("Nombre del empleado: ");
        string nombreEmpleado = Console.ReadLine();
        Console.Write("Cargo del empleado: ");
        string cargoEmpleado = Console.ReadLine();
        Console.Write("Horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
        Console.Write("Valor de la hora: ");
        double valorHora = Convert.ToDouble(Console.ReadLine());

