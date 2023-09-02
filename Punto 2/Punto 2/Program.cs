class Punto_2
{

    static void Main()
    {
        double horasTrabajadas, ValorHora,salarioEmpleado,descSalud,descPension,embargoBancario,nominaEmpleado;
        string nombreCompleto, cargoEmpleado;
        const double SALUD_EMPLEADO = 0.04;
        const double PENSION_EMPLEADO = 0.04;
        const double EMBARGO_BANCARIO_EMPLEADO = 4;


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

        salarioEmpleado = (horasTrabajadas * ValorHora) * 31;

        Console.WriteLine($"Su salario mensual es de: {salarioEmpleado}");

        Console.WriteLine("** Descuentos de nomina **");

        descSalud = salarioEmpleado * SALUD_EMPLEADO;
        descPension = salarioEmpleado * PENSION_EMPLEADO;
        embargoBancario = salarioEmpleado / EMBARGO_BANCARIO_EMPLEADO;

        Console.WriteLine($"Descuento salud: {descSalud}");
        Console.WriteLine($"Descuento pension: {descPension}");
        Console.WriteLine($"Descuento del embargo: {embargoBancario}");

        nominaEmpleado = salarioEmpleado - descSalud - descPension - embargoBancario;

        Console.WriteLine($"Sr {nombreCompleto} el salario que resivira para este mes es de: {nominaEmpleado}");
    }
}