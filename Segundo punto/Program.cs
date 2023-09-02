/* Punto 2: Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado.
Debemos pedir por pantalla el nombre del empleado, el cargo, horas trabajadas y valor de la hora.
Se debe descontar de su salario el 4% correspondientes a salud, el 4% correspondientes a pensión y
¼ parte por un embargo bancarios que recibió dicho empleado
Mostrar por pantalla el nombre del empleado, su cargo, salario neto (antes de deducciones) y salario
final (después de deducciones) */


class Program
{
    static void Main()
    {
        // Solicitar información del empleado
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombreEmpleado = Console.ReadLine();

        Console.WriteLine("Ingrese el cargo del empleado:");
        string cargoEmpleado = Console.ReadLine();

        Console.WriteLine("Ingrese las horas trabajadas:");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la hora:");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        // Calcular salario neto (antes de deducciones)
        double salarioNeto = horasTrabajadas * valorHora;

        // Calcular deducciones
        double salud = salarioNeto * 0.04;
        double pension = salarioNeto * 0.04;
        double embargo = salarioNeto / 4;

        // Calcular salario final (después de deducciones)
        double salarioFinal = salarioNeto - salud - pension - embargo;

        // Mostrar resultados
        Console.WriteLine("\nResumen de la nómina del empleado:");
        Console.WriteLine("Nombre del empleado: " + nombreEmpleado );
        Console.WriteLine("Cargo: " + cargoEmpleado);
        Console.WriteLine("Salario Neto (antes de deducciones): $" + ((decimal)salarioNeto));
        Console.WriteLine("Deducciones:");
        Console.WriteLine("   - Salud: $" + (decimal)salud );
        Console.WriteLine("   - Pensión: $" + (decimal)pension);
        Console.WriteLine("   - Embargo bancario: $" + (decimal)embargo);
        Console.WriteLine("Salario Final (después de deducciones): $" + (decimal)salarioFinal);

    }
}