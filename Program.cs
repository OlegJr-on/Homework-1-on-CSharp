using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/////////////
// Created 07/09/2021
////////////

enum Name
{ 
    Hugo_Andrii = 1,
     Monxerho_jale,
     Ronaldo_Crish,
     Olaf_Zavgorodsii,
     Joke_Vandersar,
     Rich_Nonasenko,
     Cola_Ivanovna,
     Goga_Tupuria,
     Hose_Gonsales,
     Lola_Sosivna,
     Noni_Yerchenko,
     Vova_Huesosenko,
     Yuri_Gfolsa,
     Coca_Sofina,
     Xosa_Sola,
     Lifo_Ernandes,
     Boba_Bibo,
     Volv_Solka,
     Dopka_Typia,Hjogo_Lopares
}




namespace Homework_1_on_CSharp
{
    class Program
    {
        static void Example3(ref int[] array,int sered,uint counter,int arraylength)
        {
            int[] a = new int[arraylength];
            for (int i = 0; i < a.Length; i++)
            {
                if (array[i]>sered)
                {
                    a[i] = array[i];
                }
                else {
                    a[i] = 0;
                }
            }
            array = a;
        }


        static void Main(string[] args)
        {
            //3
            int[] digital = new int[10];
            string[] names = new string[10];

            int[] digitalForTwoGroup = new int[10];
            string[] namesForTwoGroup = new string[10];


            Random rar = new Random();
            int lenght = digital.Length;
            Console.Write("Input year: ");
            uint year = uint.Parse(Console.ReadLine());
            Console.Write("Input average salary: ");
            int serednia = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int lopa = 1;
            uint counter = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 60) + "-- for 1 group: --".ToUpper());
            for (int m = 0; m < year; m++)
           {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string ('-',20)+$" For {m+1} year: ".ToUpper() + new string('-', 20));
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < digital.Length; i++)
            {
                digital[i] = rar.Next(1500, 4500);
                if (digital[i] > serednia)
                {
                    counter++;
                }
            }
            for (int name = 0; name < digital.Length; name++)
            {
                string str = Convert.ToString(lopa);
                Name car = (Name)Enum.Parse(typeof(Name), str, ignoreCase: true);
                string vov = Convert.ToString(car);
                names[name] = vov;
                if (lopa < 18)
                {
                    lopa++;
                }
                else
                {
                    lopa = 1;
                }

            }

                for (int i = 0; i < digital.Length; i++)
                {
                    Console.WriteLine($"{names[i]} - > {digital[i]}");
                }
                Console.WriteLine();
                Example3(ref digital, serednia, counter, lenght);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"More than {serednia} $ is: ");
                Console.WriteLine(new string('-',25));
                for (int i = 0; i < digital.Length; i++)
                {
                    if (digital[i] > 0)
                    {
                        Console.WriteLine($"{names[i]} - > {digital[i]}");
                    }
                }
                Console.WriteLine();
            }
            counter = 0;
            int yey = 11;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 60) + "-- for 2 group: --".ToUpper());
            for (int m = 0; m < year; m++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string('-', 20) + $" For {m + 1} year: ".ToUpper() + new string('-', 20));
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < digital.Length; i++)
                {
                    digitalForTwoGroup[i] = rar.Next(1500, 4500);
                    if (digitalForTwoGroup[i] > serednia)
                    {
                        counter++;
                    }
                }
                for (int name = 0; name < digitalForTwoGroup.Length; name++)
                {
                    //lopa = 11;
                    string str = Convert.ToString(yey);
                    Name car = (Name)Enum.Parse(typeof(Name), str, ignoreCase: true);
                    string vov = Convert.ToString(car);
                    namesForTwoGroup[name] = vov;
                    if (yey < 20)
                    {
                        yey++;
                    }
                    else
                    {
                        yey = 1;
                    }

                }

                for (int i = 0; i < digitalForTwoGroup.Length; i++)
                {
                    Console.WriteLine($"{namesForTwoGroup[i]} - > {digitalForTwoGroup[i]}");
                }
                Console.WriteLine();
                Example3(ref digitalForTwoGroup, serednia, counter, lenght);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"More than {serednia} $ is: ");
                Console.WriteLine(new string('-', 25));
                for (int i = 0; i < digitalForTwoGroup.Length; i++)
                {
                    if (digitalForTwoGroup[i] > 0)
                    {
                        Console.WriteLine($"{namesForTwoGroup[i]} - > {digitalForTwoGroup[i]}");
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Sort: ");
                Array.Sort(digitalForTwoGroup);
                for (int i = 0; i < digitalForTwoGroup.Length; i++)
                {
                    if (digitalForTwoGroup[i] > 0)
                    {
                        Console.WriteLine($"{i+1} - > {digitalForTwoGroup[i]}"); 
                    }
                }
            }

            Console.ResetColor();

        }

        static void Formatting(int[,] arrayposition, uint seledniaplata, int counterForFunction, int year,int numb)
        {
            int[,] sliv = new int[year, counterForFunction];

            for (int i = 0; i < arrayposition.GetLength(0); i++)
            {
                for (int k = 0; k < arrayposition.GetLength(1); k++)
                {

                    if (arrayposition[i, k] > seledniaplata)
                    {
                        sliv[i, k] = arrayposition[i, k];
                    }


                }
            }

            Console.WriteLine($"Salary more than {seledniaplata} in {numb} group:");

            for (int i = 0; i < sliv.GetLength(0) - 1; i++)
            {
                Console.WriteLine(new string('_', 25) + $" For {i + 1} year : " + new string('_', 25));
                for (int l = 0; l < sliv.GetLength(1); l++)
                {
                    if (sliv[i, l] != 0)
                    {
                        Console.WriteLine($"{l + 1}-worker -> {sliv[i, l]}");
                    }
                }
            }
            for (int i = 1; i < sliv.GetLength(0); i++)
            {
                Console.WriteLine(new string ('_',25)+$" For {i + 1} year : "+ new string('_', 25));
                for (int l = 0; l < sliv.GetLength(1); l++)
                {
                    if (sliv[i, l] != 0)
                    {
                        Console.WriteLine($"{l + 1}-worker -> {sliv[i, l]}");
                    }
                }
            }
            //arrayposition = sliv;


        }


    }
}   

