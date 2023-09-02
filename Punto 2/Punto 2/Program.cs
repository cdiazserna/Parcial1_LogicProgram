class Punto_2
{

    static void Main()
    {
        double horasTrabajadas, ValorHora,nominaEmpleado;
        string nombreCompleto, cargoEmpleado;

        Console.WriteLine("*** Calculo de nomina ***");

        Console.WriteLine("Por favor, ingresar el nombre completo");
        nombreCompleto = Console.ReadLine();
        Console.WriteLine("Por favor, ingresar el cargo");
        cargoEmpleado = Console.ReadLine();

        Console.WriteLine("Dijitar cantidad de horas trabajadas");
        horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Dijitar el valor de la hora");
        ValorHora = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*Se va tomar como base que el mes sea de 31 días*");
        Console.WriteLine($"El nombre del empleado es: {nombreCompleto}\nCargo del empleado {cargoEmpleado}.");

        nominaEmpleado = (horasTrabajadas * ValorHora) * 31;

        Console.WriteLine($"Sr {nombreCompleto} su salario mensual es de: {nominaEmpleado}" +
            $"\nNo se tiene encuenta devengando");
        Console.WriteLine();


    }
}