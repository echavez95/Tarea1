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
                Console.Write("Escriba el numero:");

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
                        MostrarNombre("Eliezer Abraham Chavarria Chavez");
                        break;
                    case 6:
                        Console.Clear();
                        MostrarNombres("Eliezer", "Chavarria");
                        break;
                    case 7:
                        Console.Clear();
                        MostrarIngresos(3500, 5);
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 5.12");
                        Console.Write("Escriba un numero: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Resultado: {0}", Convert.ToString(Incremento(numero)));

                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 5.17");
                        Console.Write("Escriba un numero: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Incremento(ref n);
                        break;
                    case 10:
                        Console.Clear();
                        Ejercicio73();
                        break;
                    case 11:
                        Console.Clear();
                        Ejercicio81();
                        break;
                    case 12:
                        Console.Clear();
                        Ejercicio85();
                        break;
                    case 13:
                        Console.Clear();
                        Ejercicio88();
                        break;
                    case 14:
                        Console.Clear();
                        Ejercicio104();
                        break;
                    case 15:
                        Console.Clear();
                        Ejercicio106();
                        break;
                    case 0:
                        Console.WriteLine("Presione Enter Para Salir");
                        break;
                }

                Console.WriteLine("Presione Una tecla para volver al menu");
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


        }

        public static void Ejercicio47()
        {
            Console.WriteLine("Ejercicio 4.7");
            int tsegundos = 5049;

            int horas = tsegundos / 3600;
            int minutos = (tsegundos - (horas * 3600)) / 60;
            int segundos = tsegundos - (horas * 3600) - (minutos * 60);

            Console.Write("H:{0}", horas);
            Console.Write(" M:{0}", minutos);
            Console.WriteLine(" S:{0}", segundos);


        }

        public static void Ejercicio49()
        {
            Console.WriteLine("Ejercicio 4.9");

            Console.WriteLine("Monto Dado(euros):");
            int montodado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Costo del Articulo(centavos):");
            int costoarticulo = Convert.ToInt32(Console.ReadLine());

            int cambio = (montodado * 100) - costoarticulo;
            Console.WriteLine("Cambio(centavos):{0}", cambio);


            Console.WriteLine("Billetes de 1: {0}", Convert.ToString(cambio / 100));
            int resto = cambio % 100;
            Console.WriteLine("Monedas de 50: {0}", Convert.ToString(resto / 50));
            resto = resto % 50;
            Console.WriteLine("Monedas de 20: {0}", Convert.ToString(resto / 20));
            resto = resto % 20;
            Console.WriteLine("Monedas de 10: {0}", Convert.ToString(resto / 10));
            resto = resto % 10;
            Console.WriteLine("Monedas de 5: {0}", Convert.ToString(resto / 5));
            resto = resto % 5;
            Console.WriteLine("Monedas de 2: {0}", Convert.ToString(resto / 2));
            resto = resto % 2;
            Console.WriteLine("Monedas de 1: {0}", Convert.ToString(resto / 1));


        }

        public static void MostrarNombre(string nombre)
        {
            Console.WriteLine(nombre);

            Console.WriteLine("Presione una Tecla para volver al Menu");
        }

        public static void MostrarNombres(string nombre, string apellido)
        {
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);


        }

        public static void MostrarIngresos(double salario, int numanios)
        {
            Console.WriteLine(Convert.ToString(salario * numanios));


        }

        public static int Incremento(int numero)
        {
            return ++numero;
        }

        public static void Incremento(ref int numero)
        {
            Console.WriteLine("Resultado: {0}", Convert.ToString(++numero));

        }

        public static void Ejercicio73()
        {
            Console.WriteLine("Entradas de Cine");
            Console.Write("Escriba su Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 5)
            {
                Console.Write("La funcion es gratis!");
            } else if (edad <= 12)
            {
                Console.Write("Paga la Mitad!");
            } else if (edad <= 54)
            {
                Console.Write("Tarifa completa");
            }
            else if (edad >= 55)
            {
                Console.Write("La funcion es gratis!");
            }
        }

        public static void Ejercicio81()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);
                Console.WriteLine(" Potencia cubica: {0}", Convert.ToString(Math.Pow(i, 3)));
            }

        }

        public static void Ejercicio85()
        {
            int sumatoria = 0;
            for (int i = 0; i <= 39; i++)
            {
                sumatoria = sumatoria + i;
            }
            Console.WriteLine("La sumatoria es: {0}", sumatoria);
        }

        public static void Ejercicio88()
        {
            Console.WriteLine("Serie de Fibonnaci hasta el numero 20");
            int serie = 0;
            int sumatoria = 1;
            int b;

            for (int i = 1; i <= 20; i++)
            {
                b = serie;
                serie = sumatoria;
                sumatoria = b + serie;
                Console.WriteLine(serie);

            }
        }

        public static void Ejercicio104()
        {

            int a = 1;
            Partida puntaje = new Partida();

            while (a != 0)
            {
                Console.WriteLine("Ejercicio Guardar Puntuacion");
                Console.WriteLine("1 Restablecer Puntaje");
                Console.WriteLine("2 Sumar un Punto");
                Console.WriteLine("3 Quitar un Punto");
                Console.WriteLine("4 Ver Puntuacion");
                Console.WriteLine("0 Salir");
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        puntaje.resetPoints();
                        Console.Clear();
                        break;
                    case 2:
                        puntaje.addPoint();
                        Console.Clear();
                        break;
                    case 3:
                        puntaje.removePoint();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Tiene {0} puntos!", puntaje.getPoints());
                        break;
                    case 0:
                        break;
                }

            }
        }

        public static void Ejercicio106(){
            Console.WriteLine("Ejercicio Numero Aleatorio");
            Console.Write("Escriba un numero para generar otro: ");

            Erandom numAleatorio = new Erandom();
            numAleatorio.generateRandom(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("El numero generado es: {0}",numAleatorio.getRandom());
        }
    }

    public class Partida
    {
        private int puntos;

        public Partida()
        {

        }

        public void resetPoints()
        {
            puntos = 0;
        }

        public void addPoint()
        {
            puntos++;
        }

        public void removePoint()
        {
            puntos--;
        }

        public int getPoints()
        {
            return puntos;
        }

    }

    public class Erandom
    {
        private int SiguienteA;

        public void generateRandom(int AnteriorA)
        {
            SiguienteA= ((AnteriorA * 25173) + 13849) % 65536;
        }

        public int getRandom() {
            return SiguienteA;
        }
    }

}
