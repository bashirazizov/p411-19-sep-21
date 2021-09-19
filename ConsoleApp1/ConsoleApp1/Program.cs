using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1&2
            //Console.Write("Eded daxil et: ");
            //int max = Convert.ToInt32(Console.ReadLine());
            //int result = 0;

            //for (int i = 1; i < max; i += 2)
            //{
            //    result += i;
            //}

            //Console.WriteLine(result);

            //Console.Write("Ededi daxil edin: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Quvveti daxil edin: ");
            //int pow = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //while (pow>=1)
            //{
            //    result *= num;
            //    pow--;

            //}

            //Console.WriteLine(result);
            #endregion
            #region try catch
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num);


            //string[] students = { "samir", "mamed", "sahin", "ali"};

            //Console.Write("necenci telebe lazimdir? ");
            //int num = Convert.ToInt32(Console.ReadLine());


            //try
            //{
            //    Console.WriteLine(students[num]);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("problem");
            //}


            //string[] students = { "samir", "mamed", "sahin", "ali"};
            //int leftAttemps = 3;

            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("necenci telebe lazimdir? ");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine(students[num]);
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        leftAttemps--;
            //        if (leftAttemps==0)
            //        {
            //            break;
            //        }
            //        Console.WriteLine("Problem var."+ leftAttemps +"sansiniz qalib");
            //    }
            ////}

            //int num1;
            //int num2;

            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("1ci ededi daxil edin ");
            //        num1 = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Problem");
            //    }
            //}


            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("2ci ededi daxil edin ");
            //        num2 = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Problem");
            //    }
            //}

            //Console.WriteLine(num1 + num2);
            #endregion
            #region methods
            //int[] numbers = { 10, 12, 14 };
            //int sum = 0;
            //int average;
            //foreach (int num in numbers)
            //{
            //    sum += num;
            //}

            //average = sum / numbers.Length;


            //int[] numbers = { 10, 12, 14 };
            //int[] numbers2 = { 14212, 141242, 52321 };
            //int[] numbers3 = { 14212, 41,123,123,123,123,12,3,123123 };

            //Console.WriteLine(Average(numbers));
            //Console.WriteLine(Average(numbers2));
            //Console.WriteLine(Average(numbers3));


            //PrintInfo("Mamed", "Aliyev");

            //Console.WriteLine( Sum(1,2) );
            //ErrorVar();

            //string[] names = { "Mamed", "Nicat", "Kamran" };

            //Console.WriteLine(CombineStrings(names));

            //Console.WriteLine(CombineStrings("GulMamed", "AyNicat", "BagdaKamran"));
            //int avv = Average(1, 312, 4123, 123);

            //PrintInfo("memed", "aliyev", true);
            #endregion

        }

        static string CombineStrings(params string[] strings)
        {
            string result = "";

            foreach (string item in strings)
            {
                result += item + ", ";
            }

            return result;
        }

        static int Sum(int x, int y)
        {
            return x+y;
        }

        static int Minus(int x, int y)
        {
            return x - y;
        }

        static void PrintInfo(string name, string surname, bool isMarried = false)
        {
            string result = name + " " + surname;
            if (isMarried)
            {
                result += " evlidir";
            }
            else
            {
                result += " subaydir";
            }

            Console.WriteLine(result);
        }



        static void ErrorVar()
        {
            Console.WriteLine("Daxil etdiyiniz melumatlar yanlisdir.");
        }



        static int Average(params int[] arr)
        {
            int sum = 0;
            int average;

            foreach (int num in arr)
            {
                sum += num;
            }

            average = sum / arr.Length;

            return average;
        }
    }
}
