using System;

namespace estructura_de_control_semana3
{
    class Program
    {
        static void Main(string[] args)
        {
            principal();

        }

        static void principal()
        {
            int repetir_menu;
            System.Console.WriteLine("Estructuras de control en Visual C#");
            System.Console.WriteLine("1. Menú de opciones");
            System.Console.WriteLine("2. Salir");

            System.Console.WriteLine("Ingrese 1 para mostrar menú o 2 para salir. ");
            repetir_menu = int.Parse(Console.ReadLine());

            while (repetir_menu == 1)
            {
                opciones();
            }

            Environment.Exit(0);
        }


        static void opciones()
        {

            int opcion;

            System.Console.WriteLine("Ejemplos de estructuras de control");
            System.Console.WriteLine("Programa 1 Multiplicacion");
            System.Console.WriteLine("Programa 2 Division");
            System.Console.WriteLine("Programa 3 Resta");
            System.Console.WriteLine("Programa 4 Suma");
            System.Console.WriteLine("Programa 5 Integrantes");

            System.Console.WriteLine("Ingrese la opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    programa1();


                    int num1, num2, multi;

                    Console.Write("\n\tMultiplicacion de Dos Numeros");

                    Console.Write("\nIngrese un numero: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\nIngrese el numero 2: ");
                    num2 = int.Parse(Console.ReadLine());

                    multi = num1 * num2;

                    Console.WriteLine("El Resultado es: " + multi);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();

                    break;
                case 2:
                    programa2();

                    int nume1, nume2, divi;

                    Console.Write("\n\tDivision de Dos Numeros");

                    Console.Write("\nIngrese un numero: ");
                    nume1 = int.Parse(Console.ReadLine());

                    Console.Write("\nIngrese el numero 2: ");
                    nume2 = int.Parse(Console.ReadLine());

                    divi = nume1 / nume2;

                    Console.WriteLine("El Resultado es: " + divi);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();

                    break;
                case 3:
                    programa3();

                    int nu1, nu2, resta;

                    Console.Write("\n\tResta de Dos Numeros");

                    Console.Write("\nIngrese un numero: ");
                    nu1 = int.Parse(Console.ReadLine());

                    Console.Write("\nIngrese el numero 2: ");
                    nu2 = int.Parse(Console.ReadLine());

                    resta = nu1 - nu2;

                    Console.WriteLine("El Resultado es: " + resta);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                    break;
                case 4:
                    programa4();

                    int n1, n2, suma;

                    Console.Write("\n\tSuma de Dos Numeros");

                    Console.Write("\nIngrese un numero: ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.Write("\nIngrese el numero 2: ");
                    n2 = int.Parse(Console.ReadLine());

                    suma = n1 + n2;

                    Console.WriteLine("El Resultado es: " + suma);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                    break;

                case 5:
                    programa5();
                    Console.WriteLine("INTEGRANTES");
                    Console.WriteLine("Katerin Estela Orellana Hernandez USIS035821");
                    Console.WriteLine("Jose Luis Muñoz Padilla USIS043721");
                    Console.WriteLine("Rigoberto Alexander Mejia Sorto USIS034921");
                    Console.WriteLine("Angel Ernesto Aparicio Martinez USIS050021");
                    Console.WriteLine("KERIN FRANCISCO MELENDEZ MEJIA USIS045421");
                    Console.WriteLine("Maria del Carmen Rodriguez Martinez USIS936021");
                    break;



                default:
                    System.Console.WriteLine("Opción equivocada");
                    break;
            }

            principal();

        }

        static void programa1()
        {
            System.Console.WriteLine("Programa 1");


        }

        static void programa2()
        {
            System.Console.WriteLine("Programa 2");

        }

        static void programa3()
        {
            System.Console.WriteLine("Programa 3");

        }

        static void programa4()
        {
            System.Console.WriteLine("Programa 4");
        }
        static void programa5()
        {
            System.Console.WriteLine("Programa 5");

          
        }
    }
       
        
    }


