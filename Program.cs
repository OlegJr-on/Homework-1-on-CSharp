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
            Console.Write("Input seredniy Salary: ");
            int serednia = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int lopa = 1;
            uint counter = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                   -- FOR 1 GROUP: --");
            for (int m = 0; m < year; m++)
           {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"--------------- For {m+1} year: --------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < digital.Length; i++)
            {
                digital[i] = rar.Next(2300, 2400);
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
                Console.WriteLine("--------------------------");
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
            Console.WriteLine("                                                     -- FOR 2 GROUP: --");
            for (int m = 0; m < year; m++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"--------------- For {m + 1} year: --------------");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < digital.Length; i++)
                {
                    digitalForTwoGroup[i] = rar.Next(2300, 2400);
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
                Console.WriteLine("--------------------------");
                for (int i = 0; i < digitalForTwoGroup.Length; i++)
                {
                    if (digitalForTwoGroup[i] > 0)
                    {
                        Console.WriteLine($"{namesForTwoGroup[i]} - > {digitalForTwoGroup[i]}");
                    }
                }
                Console.WriteLine();
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


            ////
            ///
            //Console.WriteLine();
            //Console.WriteLine("RESULT:");
            //Console.WriteLine("---------------------");
















            //1
            //int lop = 0;
            //string[][,] zalupa = new string[2][,];
            //zalupa[0] = { }
            //var lopa = 1;
            ////int lop = 0;
            //const sbyte count = 0;
            //Random run = new Random();

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int two = 0; two < 5; two++)
            //    {
            //        for (int three = 0; three < 5; three++)
            //        {
            //            zalupa[i][two, three] = "00";

            //        }
            //    }
            //}
            //for (int l = 0; l < 5; l++)
            //{
            //    for (int p = 0; p < 4; p++)
            //    {
            //        lop = run.Next(2100, 2500);
            //        string strforArray = Convert.ToString(lop);
            //        zalupa[count][l, p] = strforArray;


            //    }
            //}

            //for (int l = 0; l < 5; l++)
            //{
            //    for (int p = 0; p < 4; p++)
            //    {
            //        string str = Convert.ToString(lopa);
            //        Name cast = (Name)Enum.Parse(typeof(Name), str, ignoreCase: true);
            //        string vov = Convert.ToString(cast);
            //        zalupa[1][l, p] = vov;
            //        if (lopa < 18)
            //        {
            //            lopa++;
            //        }
            //        else
            //        {
            //            lopa = 1;
            //        }
            //    }
            //}
            //for (int l = 0; l < 5; l++)
            //{
            //    for (int p = 0; p < 4; p++)
            //    {
            //        Console.WriteLine(zalupa[1][l, p]);
            //    }
            //}











            //2
            //Console.WriteLine("Input year: ");
            //uint yearWork = uint.Parse(Console.ReadLine());

            //int workers = 10;
            //var lopa = 1;
            //string[,] hohol = new string[workers, workers];
            //for (int i = 0; i < yearWork; i++)
            //{


            //    for (int i = 0; i < hohol.GetLength(0); i++)
            //        for (int h = 0; h < hohol.GetLength(1); h++)
            //        {

            //            string str = Convert.ToString(lopa);
            //            Name car = (Name)Enum.Parse(typeof(Name), str, ignoreCase: true);
            //            string vov = Convert.ToString(car);
            //            hohol[i, h] = vov;
            //            if (lopa < 18)
            //            {
            //                lopa++;
            //            }
            //            else
            //            {
            //                lopa = 1;
            //            }
            //        }
            //}
            //Console.WriteLine("_______________________");
            //Console.WriteLine("NAMES:   ");
            //Console.WriteLine("_______________________");
            //for (int i = 0; i < hohol.GetLength(0); i++)
            //    for (int h = 0; h < hohol.GetLength(1); h++)
            //    {
            //        Console.WriteLine(hohol[i, h]);
            //        Console.WriteLine("-");
            //    }
            //Console.WriteLine();









            //main
            //    Console.Write("Input year: ");
            //    int yearWork = int.Parse(Console.ReadLine());
            //    Console.Write("Input number of people group 1: ");
            //    uint CountOfWorker1 = uint.Parse(Console.ReadLine());
            //    Console.Write("Input number of people group 2: ");
            //    uint CountOfWorker2 = uint.Parse(Console.ReadLine());

            //    int[,] ArrayOfOneGroup1 = new int[yearWork, CountOfWorker1];
            //    int[,] ArrayOfOneGroup2 = new int[yearWork, CountOfWorker2];

            //    Random ram = new Random();

            //    Console.Write("Input average salary: ");
            //    uint PaySalary = uint.Parse(Console.ReadLine());
            //    Console.WriteLine("---------------------------------- ");
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    int counter = 0;
            //    Console.WriteLine("Input salary of 1 group: ");
            //    for (int i = 0; i < ArrayOfOneGroup1.GetLength(0); i++)
            //    {
            //        Console.WriteLine($"________ {i + 1} - year: __________");
            //        for (int j = 0; j < ArrayOfOneGroup1.GetLength(1); j++)
            //        {

            //            ArrayOfOneGroup1[i, j] = ram.Next(2300, 2400);
            //            Console.WriteLine($"{j + 1}-worker = {ArrayOfOneGroup1[i, j]}");
            //            if (ArrayOfOneGroup1[i, j] > PaySalary)
            //            {
            //                counter++;
            //            }
            //        }

            //    }
            //sbyte numb1 = 1;
            //    Formatting(numb:numb1,arrayposition: ArrayOfOneGroup1, seledniaplata: PaySalary, counterForFunction: counter, year: yearWork);
            //    Console.WriteLine();


            //    sbyte numb2 = 2;
            //    counter = 0;
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Input salary of 2 group: ");
            //    for (int i = 0; i < ArrayOfOneGroup2.GetLength(0); i++)
            //    {
            //        Console.WriteLine($"________{i + 1} - year: __________");
            //        for (int j = 0; j < ArrayOfOneGroup2.GetLength(1); j++)
            //        {
            //            ArrayOfOneGroup2[i, j] = ram.Next(2300, 2400);
            //            Console.WriteLine($"{j + 1}-worker = {ArrayOfOneGroup2[i, j]}");
            //            if (ArrayOfOneGroup2[i, j] > PaySalary)
            //            {
            //                counter++;
            //            }

            //        }
            //    }
            //    Formatting(numb:numb2,arrayposition: ArrayOfOneGroup2, seledniaplata: PaySalary, counterForFunction: counter, year: yearWork);

            //    Console.WriteLine();
            //    Console.WriteLine("Sorting Two Array: ");


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
                Console.WriteLine($"_________________________For {i + 1} year: _____________________________");
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
                Console.WriteLine($"_________________________For {i + 1} year: _____________________________");
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

