//Punto 2:

public class NominaMensualEmpleado
{
    static void Main(string[] args)
    {
        //Declaración de variables
        string nombreEmpleado, cargoEmpleado;
        int horasTrabajadas;
        decimal valorHorasTrabajadas, nominaSinDeducciones, nominaConDeducciones;

        //Declaración de constantes
        const double porcentajeSalud = 4 / 100;
        const double porcentajePension = 4 / 100;
        const decimal embargo = 1 / 4;

        //Pedir datos de entrada
        Console.Write("Ingrese su nombre completo: ");
        nombreEmpleado = Console.ReadLine();

        Console.Write("Ingrese su cargo: ");
        cargoEmpleado = Console.ReadLine();

        Console.Write("Ingrese sus horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor por hora trabajada: ");
        valorHorasTrabajadas = decimal.Parse(Console.ReadLine());

        //Cálculos 


    }

}


