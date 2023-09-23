// See https://aka.ms/new-console-template for more information
/*
 Realizar un algoritmo en C# para una Natillera Navideña que determina cuánto ahorrará una persona
en un año 2023, si al final de cada mes deposita cantidades variables de dinero; además, calcular
los rendimientos generados por el ahorro en cada mes, correspondientes a la tasa del momento estipulada
por Banco De La República (Tasas generadas por la clase Random entre 0.1% y 5.0%). Si la tasa del mes es
inferior al 1.5%, entonces la Natillera estará en capacidad de otorgarle un bono a esa persona correspondiente a 
2/5 partes del ahorro de dicho mes.

Se quiere saber cuál fue la tasa estipulada por el Banco de La República, cuánto lleva ahorrado, 
cuánto se otorgó de bono (si aplica) y cuánto lleva de rendimiento en cada mes, además se quiere 
saber el ahorro total, el bono total, los rendimientos totales al cabo de un año, y la suma total 
neta que se le consignará a esa persona.

La aplicación debe tener la funcionalidad de preguntar al usuario si quiere volver 
al inicio para determinar el ahorro y rendimientos del siguiente año. Si no, salirse del programa.
 */


using System.Globalization;

class natillera
{

    static void Main()
    {



        Random tasaMes = new Random();
        DateTime fec = DateTime.Now;
        decimal ahorroMes, rendimientosMes = 0,interesMes,
            bonoMes, ahorroAnual = 0, rendimientoAnual = 0 , bonoAnual = 0, interesAnual = 0, sumaNeta;
        bool Variable = true;

        const decimal TASA_MAX = 1.5M;

        while (Variable)
        {

            for (int i = 1; i <= 12; i++)
            {

                Console.WriteLine($"Por favor dijite la cantidad de dinero para el mes {i}");
                ahorroMes = Convert.ToDecimal(Console.ReadLine());

                interesMes = tasaMes.Next(10, 501) / 100;
                rendimientosMes = (ahorroMes * interesMes)/100;

                if (interesMes <= TASA_MAX)
                {
                    bonoMes = (ahorroMes * 2) / 5;
                    bonoAnual += bonoMes;
                }
                interesAnual += interesMes;
                ahorroAnual += ahorroMes;
                rendimientoAnual += rendimientosMes;


                sumaNeta = rendimientoAnual + ahorroAnual + interesAnual;




                  Console.WriteLine("Rendimientos Mensuales " + rendimientosMes);

            }

            
            Console.WriteLine("Desea contiunuar S/n");
            string validaBoolean = Console.ReadLine().ToLower().Trim();

            if (validaBoolean == "n")
            {
                Variable = false;
            }

            
        }
    }
}





