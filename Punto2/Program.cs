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
        const int porcentajeSalud = 4 / 100;
        const int porcentajePension = 4 / 100;
        const int embargo = 1 / 4;

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
        nominaSinDeducciones = horasTrabajadas * valorHorasTrabajadas;
        nominaConDeducciones = nominaSinDeducciones - ((nominaSinDeducciones * porcentajeSalud) + (nominaSinDeducciones * porcentajePension) + (nominaSinDeducciones * embargo));

        //Datos de salida
        Console.WriteLine("Su nombre es: " + nombreEmpleado);
        Console.WriteLine("Su cargo es: " + cargoEmpleado);
        Console.WriteLine("Su salario sin deducciones es: " + nominaSinDeducciones);
        Console.WriteLine("Su salario con deducciones es: " + nominaConDeducciones);

    }

}


