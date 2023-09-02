public class Punto2
{
    static void Main(string[] args)
    {
        double horasTrabajadas, valorPorHora, salarioNeto, salarioFinal;
        string nombreEmpleado, cargoEmpleado;

        Console.Write("Ingrese el nombre del empleado: ");
        nombreEmpleado = Console.ReadLine();
        Console.Write("Ingrese el cargo del empleado: ");
        String cargo = cargoEmpleado = Console.ReadLine();
        Console.Write("Ingrese las horas trabajadas en el mes:");
        horasTrabajadas = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor por hora trabajada: ");
        valorPorHora = Convert.ToDouble(Console.ReadLine());

        salarioNeto = horasTrabajadas * valorPorHora;

        salarioFinal = (salarioNeto - ((((4 * salarioNeto) / 100) + (4 * salarioNeto) / 100) + (salarioNeto/4)));

        Console.Write()
    }




}
