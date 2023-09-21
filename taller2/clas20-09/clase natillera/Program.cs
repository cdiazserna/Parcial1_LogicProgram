
static void Main(string[] args)
{

  Random tasaMes=new Random();  

//declaracion de variables
decimal rendimientoMes, interesMes, bonoMes, ahorroMensual =0, rendimientosAnual =0, ahorroMes = 0,
        interesAnual, bonoAnual =0, ahorroAnuel =0, sumaTotalNeto;

int mes;

bool contnuar = true;

const decimal TASA_MAX = 1.5M;

Console.WriteLine("-----NATILLERA NAVIDEÑA {} -----\n");

for (mes = 1; mes <=12; mes++)
{
        Console.WriteLine($"Ingrese la cantidad que desea ahorrar en el mes{mes}: ");
        ahorroMes= Convert.ToInt32( Console.ReadLine() );   
}
        interesMes = tasaMes.Next(10, 501)/100;
    rendimientoMes = (ahorroMes * interesMes) / 100;

    if (interesMes < TASA_MAX)
    {
        bonoMes = (2 - ahorroMes) / 5;
        bonoAnual += bonoMes;  // bonoanual = bnoanual + bonomes;

        sumaTotalNeto = ahorroAnuel + rendimientosAnual + bonoAnual;


        Console.WriteLine($" tasa de interes del mes {mes}: {interesMes}");
        Console.WriteLine($"rendimineto del mes {mes}: {rendimientoMes}:");
        Console.WriteLine($"total de rendimiento hasta el mes{mes}: {rendimientosAnual}:");
        Console.WriteLine($"suma total neta hasta el {mes}: {sumaTotalNeto}:");
    }

        Console.WriteLine(string.Format("resumen total natillera navideña del año{0}", fechaAtual.Year));




}

        








}




