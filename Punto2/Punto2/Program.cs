public class Parcial2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el cargo del empleado:");
        string cargo = Console.ReadLine();

        Console.WriteLine("Ingrese las horas trabajadas:");
        int horasTrabajadas = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la hora:");
        double valorHora = double.Parse(Console.ReadLine());

        // Cálculo del salario bruto
        double salarioBruto = horasTrabajadas * valorHora;

        // Cálculo de deducciones
        double salud = salarioBruto * 0.04;
        double pension = salarioBruto * 0.04;
        double embargo = salarioBruto / 4;

        // Cálculo del salario neto
        double salarioNeto = salarioBruto - (salud + pension + embargo);

        // Impresión de resultados
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salario Neto (antes de deducciones): $" + salarioBruto);
        Console.WriteLine("Deducciones:");
        Console.WriteLine("Salud: $" + salud);
        Console.WriteLine("Pensión: $" + pension);
        Console.WriteLine("Embargo: $" + embargo);
        Console.WriteLine("Salario Final (después de deducciones): $" + salarioNeto);
    }
}

