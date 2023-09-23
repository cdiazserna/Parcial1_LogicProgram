class alumnos {
    static void Main()
    {

        /* Realizar un programa en C# que obtenga el promedio de calificaciones de un grupo de N alumnos.*/



        double calificacionAlumnos = 0.0, acumuladorNotas = 0.0;
        int cantidadAlumnos = 0;

        Console.Write("Por favor dijitar la cantidad de estudiantes: ");
        cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= cantidadAlumnos; i++)
        {
            Console.Write($"Por favor, ingresar la calificación del estudiante {i}: ");
            calificacionAlumnos = Convert.ToDouble(Console.ReadLine());
            acumuladorNotas += calificacionAlumnos;



        }


        Console.WriteLine($"Suma de la calificación {acumuladorNotas} y la cantidad de estudiantes es: {cantidadAlumnos} y la division es de {acumuladorNotas/cantidadAlumnos}");
    }
}