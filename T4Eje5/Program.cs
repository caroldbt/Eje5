using System;

namespace T4Eje5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*************
             * Ejercicio 5
             * ***********/
            Console.WriteLine("Ingrese el nombre de la semana sin acentos: ");
            string semana = Console.ReadLine().ToLower();
            switch (semana)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;
                default:
                    Console.WriteLine("Dia de la semana no existe");
                    break;

        }
    }
}
