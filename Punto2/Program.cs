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

        // Calcular salario bruto
        double salarioBruto = horasTrabajadas * valorHora;

        // Calcular deducciones
        double salud = salarioBruto * 0.04;
        double pension = salarioBruto * 0.04;
        double embargo = salarioBruto / 4;

        // Calcular salario neto
        double salarioNeto = salarioBruto - salud - pension - embargo;

        // Mostrar resultados
        Console.WriteLine("\nInformación del empleado:");
        Console.WriteLine("Nombre: " + nombreEmpleado);
        Console.WriteLine("Cargo: " + cargoEmpleado);
        Console.WriteLine("Salario Neto (antes de deducciones): $" + salarioBruto.ToString("3.90"));
        Console.WriteLine("Salario Final (después de deducciones): $" + salarioNeto.ToString("3.90."));

        Console.ReadLine(); // Esperar a que el usuario presione Enter
    }
}
