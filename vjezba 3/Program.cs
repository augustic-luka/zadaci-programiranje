using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace vjezba_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            do
            {
                Console.WriteLine("1. Zadatak");
                Console.WriteLine("2. Zadatak");
                Console.WriteLine("3. Zadatak");
                Console.WriteLine("4. Zadatak");
                Console.WriteLine("5. Zadatak");
                Console.WriteLine("0 Kraj");

                Console.WriteLine("Unesite broj zadataka: ");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        Zad01();
                        break;
                    case "2":
                        Zad02();
                        break;
                        case "3":
                            Zad03();
                        break;
                        case "4":
                            Zad04();
                        break;
                        case "5":
                            Zad05();
                        break;

                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepoznat izbor");
                        break;
                }
               
            }
            while (izbor != "0");

            Console.ReadKey();
        }
        static int kvadrat(int a)
        {
            return a * a;
        }
        static double OpsegKruga(double r)
        {
            return 2*r*Math.PI;
        }
        static int Razlika(int a, int b)
        {
            return a-b;
        }
        static int Zbroj(int a, int b)
        {
            return a+b;
        }
        static double PovrsinaPravokutnika(double a, double b)
        {
            return a * b;
        }
        static void Zad01()
        {
            Console.WriteLine("-------------Zadatak1---------------");
            Console.WriteLine("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            int rezultat = Zbroj(a, b);
            Console.WriteLine($"Zbroj brojeva je:{rezultat}");


        }
        static void Zad02()
        {
            Console.WriteLine("------------Zadatak 2--------------");
            Console.WriteLine("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("UNei drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            int rezultat= Razlika(a, b);
            Console.WriteLine($"Razlika brojeva je: {rezultat}");

        }
        static void Zad03()
        {
            Console.WriteLine("------------Zadatak 3--------------");
            Console.WriteLine("Unesi Stranicu Pravokutnika A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi Stranicu Pravokutnika B: ");
            double b = double.Parse(Console.ReadLine());    
            double povrsina =PovrsinaPravokutnika(a,b);
            Console.WriteLine($"Povrsina Pravokutnika je: {povrsina}");
            
        }
        static void Zad04()
        {
            Console.WriteLine("---------Zadatak 4------------");
            Console.WriteLine("Unesi r kruga: ");
            double r = double.Parse(Console.ReadLine());

            double Opseg = OpsegKruga(r);
            Console.WriteLine($"Opseg kruga je {Opseg}");
        }
        static void Zad05()
        {
            Console.WriteLine("----------Zadatak 5------------");
            Console.WriteLine("Kvadrati brojeva od 1 do 10");
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine($"Kvadrat broja {i} je: {kvadrat(i)}");
            }
        }


    }
}
