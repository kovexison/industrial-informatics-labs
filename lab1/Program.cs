using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex5();
            Console.ReadKey();
            
        }

        static void Fibonacci() //ex 1
        {
            Console.WriteLine("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
            int[] fibo = new int[n];
            fibo[0] = 0;
            fibo[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            Console.WriteLine("Fibonacci series to " + n + " is: ");
            Console.Write(fibo[0]);
            for (int i = 1; i < n; i++)
            {
                Console.Write(", " + fibo[i]);
            }
            } else
             {
                Console.WriteLine("n must be a positive integer");
            }
        }

        static void Ex2()
        {
            Console.WriteLine("number1 = ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number2 = ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Operatii.Afiseaza(Operatii.Adunare(n1, n2));
            Operatii.Afiseaza(Operatii.Scadere(n1, n2));
            Operatii.Afiseaza(Operatii.Inmultire(n1, n2));
            Operatii.Afiseaza(Operatii.Impartire(n1, n2));
        }

        static void Ex3()
        {
            Console.Write("1. - celsius to fahrenheit");
            Console.WriteLine("2. - fahrenheit to celsius");
            Console.Write("Enter your choice: ");
            Temperatura.Ruleaza(int.Parse(Console.ReadLine()));
        }

        static void Ex4()
        {
            Console.Write("Calcul greutate ideala.Introduceti inaltimea in cm: ");
            int inaltime = int.Parse(Console.ReadLine());
            Console.WriteLine("varsta: ");
            int varsta = int.Parse(Console.ReadLine());
            Console.WriteLine("Sex: (introduceti f pentru feminin, b pentru masculin): ");
            char sex = Console.ReadLine()[0];
            GreutateIdeala.Afisare(sex, inaltime, varsta);
        }

        static void Ex5()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] numere = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("numar[" + (i + 1) + "] = ");
                numere[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Media geometrica a numerelor introduse este: " + Medii.MediaGeometrica(n, numere));
            Console.WriteLine("Media aritmetica a numerelor introduse este: " + Medii.MediaAritmetica(n, numere));
        }
    }

    class Medii
    {
        public static float MediaGeometrica(int n, int[] numere)
        {
            float gm = 1;
            for(int i=0; i<n; i++)
            {
                gm = gm * numere[i];
            }
            gm = (float)Math.Pow(gm, (float)1 / n);
            return gm;
        }

        public static float MediaAritmetica(int n, int[] numere)
        {
            float media = 0;
            for(int i = 0; i<n; i++)
            {
                media = media + numere[i];
            }
            media = media / n;
            return media;
        }
    }

    class Operatii
    {
        public static int Adunare(int n1,int n2)
        {
            Console.Write("Adunare  ");
            return n1 + n2;
        }

        public static int Scadere(int n1, int n2)
        {
            Console.Write("Scadere  ");
            return n1 - n2;
        }

        public static int Inmultire(int n1, int n2)
        {
            Console.Write("Inmultire  ");
            return n1 * n2;
        }

        public static int Impartire(int n1, int n2)
        {
            Console.Write("Impartire  ");
            return n1 / n2;
        }

        public static void Afiseaza(int n)
        {
            Console.WriteLine(n);
        }
    }

    class Temperatura
    {
        public static void Ruleaza(int choice)
        {
            if(choice == 1)
            {
                Console.Write("Introduceti valoarea in Celsius: ");
                float celsius = float.Parse(Console.ReadLine());
                Console.WriteLine(celsius + " in fahrenheit este: " + CelsiusToFahrenheit(celsius));
            } else if(choice == 2)
            {
                Console.Write("Introduceti valoarea in Fahrenheit: ");
                float fahrenheit = float.Parse(Console.ReadLine());
                Console.WriteLine(fahrenheit + " in celsius este: " + FahrenheitToCelsius(fahrenheit));
            } else
            {
                Console.WriteLine("Wrong choice");
            }
        }
        static float CelsiusToFahrenheit(float celsius)
        {
            return 9 * celsius / 5 + 32;
        }

        static float FahrenheitToCelsius(float fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    class GreutateIdeala
    {
        static double Femei(int inaltimeCm, int varstaAni)
        {
            return (inaltimeCm - 100 - (inaltimeCm - 150) / 2.5) + (varstaAni - 20) / 4;
        }

        static double Barbati(int inaltimeCm, int varstaAni)
        {
            return (inaltimeCm - 100 - (inaltimeCm - 150) / 2.5) + (varstaAni - 20) / 6;
        }

        public static void Afisare(char sex, int inaltime, int varsta)
        {
            if(sex == 'f' || sex == 'F')
            {
                double greutateIdeala = Femei(inaltime, varsta);
                Console.WriteLine("Greutatea ideala este: " + greutateIdeala);
            } else if(sex == 'b' || sex == 'b')
            {
                double greutateIdeala = Barbati(inaltime, varsta);
                Console.WriteLine("Greutatea ideala este: " + greutateIdeala);
            } else
            {
                Console.WriteLine("f pentru femei si b pentru barbati. reincercati.");
            }
        }
    }
}
