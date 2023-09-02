//Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado.
//Debemos pedir por pantalla el nombre del empleado,el cargo, horas trabajadas y valor de
//la hora.Se debe descontar de su salario el 4% correspondientes a salud, el 4% correspondientes
//a pensión y¼ parte por un embargo bancarios que recibió dicho empleadoMostrar por pantalla el
//nombre del empleado, su cargo,salario neto (antes de deducciones) y salario final (después de deducciones)




   public class Punto2
{
    static void Main(String[] args)
    {
        Console.WriteLine("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el cargo del empleado: ");
        string cargo = Console.ReadLine();

        Console.WriteLine("Ingrese las horas trabajadas: ");
        int horasTrabajadas = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la hora: ");
        double valorHora = double.Parse(Console.ReadLine());

        double salarioNeto = CalcularSalarioNeto(horasTrabajadas, valorHora);
        double salarioFinal = CalcularSalarioFinal(salarioNeto);

        Console.WriteLine("Nombre del empleado: " + nombre);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salario Neto (antes de deducciones): $" + salarioNeto);
        Console.WriteLine("Salario Final (después de deducciones): $" + salarioFinal);
    }

    static double CalcularSalarioNeto(int horasTrabajadas, double valorHora)
    {
        double salarioBruto = horasTrabajadas * valorHora;
        return salarioBruto;
    }

    static double CalcularSalarioFinal(double salarioNeto)
    {
        double salud = salarioNeto * 0.04;
        double pension = salarioNeto * 0.04;
        double embargo = salarioNeto / 4;

        double salarioFinal = salarioNeto - salud - pension - embargo;
        return salarioFinal;
    }
}