// SeeDesarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado. Debemos pedir
// pantalla el nombre del empleado, el cargo, horas trabajadas y valor de la hora.



using System.ComponentModel.DataAnnotations.Schema;

class taller2

{
    static void Main(string[] args)

    {//declaracion de variables
        string cargo, nombreEmpleado;
        double horaTrabajo, valorHoras, salarioNeto, salarioFianal, embargo= 1/4, salud = 0.4, pension = 0.4;

       
        Console.WriteLine("Ingrese nombre empleado");
        nombreEmpleado = Console.ReadLine();

        Console.WriteLine("Ingrese cargo");
        cargo = Console.ReadLine(); 

        Console.WriteLine("Ingrese horas");
        horaTrabajo = double.Parse(Console.ReadLine());

        Console.WriteLine("ingrese valor");
        salarioNeto = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese valor");
        valorHoras = double.Parse(Console.ReadLine());


        Console.WriteLine("el salario neto " + nombreEmpleado + "el cargo" + cargo + "valor neto" + salarioNeto);
        Console.WriteLine();

        //final proce

        salarioFianal = horaTrabajo * valorHoras;
        salarioFianal = salarioFianal * embargo;

     
    }
}