using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 1;

            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("Menu Principal Tarea 1");
                Console.WriteLine("1. Ejercicio 4.3");
                Console.WriteLine("2. Ejercicio 4.6");
                Console.WriteLine("3. Ejercicio 4.7");
                Console.WriteLine("4. Ejercicio 4.9");
                Console.WriteLine("5. Ejercicio 5.1");
                Console.WriteLine("6. Ejercicio 5.2");
                Console.WriteLine("7. Ejercicio 5.3");
                Console.WriteLine("8. Ejercicio 5.12");
                Console.WriteLine("9. Ejercicio 5.17");
                Console.WriteLine("10. Ejercicio 7.3");
                Console.WriteLine("11. Ejercicio 8.1");
                Console.WriteLine("12. Ejercicio 8.5");
                Console.WriteLine("13. Ejercicio 8.8");
                Console.WriteLine("14. Ejercicio 10.4");
                Console.WriteLine("15. Ejercicio 10.6");
                Console.WriteLine("0 para salir");
                Console.WriteLine("-----------------------");
                Console.Write("Escriba su opcion:");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio43();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio46();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio47();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio49();
                        break;
                    case 5:
                        Console.Clear();

                        break;
                    case 6:
                        Console.Clear();

                        break;
                    case 7:
                        Console.Clear();

                        break;
                    case 8:
                        Console.Clear();

                        break;
                    case 9:
                        Console.Clear();

                        break;
                    case 10:
                        Console.Clear();

                        break;
                    case 11:
                        Console.Clear();

                        break;
                    case 12:
                        Console.Clear();

                        break;
                    case 13:
                        Console.Clear();

                        break;
                    case 14:
                        Console.Clear();

                        break;
                    case 15:
                        Console.Clear();

                        break;
                    case 0:
                        Console.WriteLine("Presione Enter Para Salir");
                        break;
                }


                Console.ReadKey();
            } 
        }

        public static void Ejercicio43()
        {
            Console.WriteLine("Ejercicio 4.3");

            int calificacion1 = 44;
            int calificacion2 = 51;

            int promedio = (calificacion1 + calificacion2) / 2;

            Console.WriteLine("El promedio es: {0}", promedio);

            Console.WriteLine("Presione una Tecla para volver al Menu");
        }

        public static void Ejercicio46()
        {
            Console.WriteLine("Ejercicio 4.6");
            int celcius;
            int farhenheit;

            Console.WriteLine("Escriba la temperatura en Grados Farhenheit");

            farhenheit = Convert.ToInt32(Console.ReadLine());

            celcius = (farhenheit - 32) * 5 / 9;

            Console.WriteLine("La temperatura en Celcius es: {0}", celcius);

            Console.WriteLine("Presione una Tecla para volver al Menu");
        }

        public static void Ejercicio47()
        {
            Console.WriteLine("Ejercicio 4.7");
            int tsegundos=5049;

            int horas = tsegundos / 3600;
            int minutos = (tsegundos - (horas * 3600)) / 60;
            int segundos = tsegundos - (horas * 3600) - (minutos * 60);

            Console.Write("H:{0}",horas);
            Console.Write(" M:{0}", minutos);
            Console.WriteLine(" S:{0}", segundos);
            
            Console.WriteLine("Presione una Tecla para volver al Menu");
        }

        public static void Ejercicio49()
        {
            Console.WriteLine("Ejercicio 4.9");

            Console.WriteLine("Monto Dado(monedas):");
            int montodado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Costo del Articulo(monedas):");
            int costoarticulo = Convert.ToInt32(Console.ReadLine());

            int cambio = costoarticulo % montodado;
            
            Console.WriteLine(Convert.ToString(cambio));


            Console.WriteLine("Presione una Tecla para volver al Menu");
        }

    }
}
