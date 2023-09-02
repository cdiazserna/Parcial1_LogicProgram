
using System.ComponentModel.DataAnnotations;

public class Punto2
{
    static void Main(string[] args)
    //Peso: 50%Punto 2: Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado. Debemos pedir por pantalla el nombre del empleado,
    //el cargo, horas trabajadas y valor de la hora.Se debe descontar de su salario el 4% correspondientes a salud,
    //el 4% correspondientes a pensión y ¼ parte por un embargo bancarios que recibió dicho empleadoMostrar por pantalla el nombre del empleado, su cargo,
    //salario neto (antes de deducciones) y salario final (después de deducciones).
    {
        string nombreEmpleado, cargo;
        double horasTrabajadas, valorHoras, salarioNeto, descuentoSaludPension, descuentoEmbargo, salarioAPagar;

        
        Console.WriteLine("Ingrese su nombre: ");
        nombreEmpleado = Console.ReadLine();

        Console.WriteLine("Ingrese su cargo: ");
        cargo = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
        horasTrabajadas = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de las horas: ");
        valorHoras = double.Parse(Console.ReadLine());

        salarioNeto = decimal.(valorHoras * horasTrabajadas);
        descuentoSaludPension = decimal(salarioNeto * 0.08);
        descuentoEmbargo = decimal.(salarioNeto / 4);
        salarioAPagar = decimal.(salarioNeto - (descuentoSaludPension + descuentoEmbargo));

        Console.WriteLine("Empleado " + nombreEmpleado + " - " + cargo + "su salario neto es $" + salarioNeto + "y su salario después de deducciones es $" + salarioAPagar);

    }
}


