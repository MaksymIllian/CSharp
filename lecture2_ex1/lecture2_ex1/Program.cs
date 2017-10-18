using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture2_ex1
{
    class Program
    {
        static void dotWithFor()
        {
            Console.WriteLine("\n   |    1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
            Console.Write("--------------------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                if (i == 10)
                {
                    Console.Write(i + " |  ");
                }
                else
                {
                    Console.Write(i + "  |  ");
                }
                for (int j = 1; j <= 10; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("\t" + i * j);
                    Console.ResetColor();
                }

                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        static void dotWithDoWhile()
        {
            Console.WriteLine("\n   |    1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
            Console.Write("--------------------------------------------------------------------------------------");
            Console.WriteLine();
            int i = 1;
            int j = 1;
            do
            {
                j = 1;
                if (i == 10)
                {
                    Console.Write(i + " |  ");
                }
                else
                {
                    Console.Write(i + "  |  ");
                }
                do 
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("\t" + i * j);
                    Console.ResetColor();
                    j++;
                }
                while (j <= 10);
                Console.WriteLine("");
                Console.WriteLine("");
                i++;
            }
            while (i <= 10);
        }

        static void dotWithWhile()
        {
            Console.WriteLine("\n   |    1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
            Console.Write("--------------------------------------------------------------------------------------");
            Console.WriteLine();
            int i =1, j = 1;

            while (i <= 10)
            {
                j = 1;
                if (i == 10)
                {
                    Console.Write(i + " |  ");
                }
                else
                {
                    Console.Write(i + "  |  ");
                }
                while (j <= 10)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("\t" + i * j);
                    Console.ResetColor();
                    j++;
                }

                Console.WriteLine("");
                Console.WriteLine("");
                i++;
            }
          
        }
        static void dotWithForecach()
        {
            Console.WriteLine("\n   |    1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
            Console.Write("--------------------------------------------------------------------------------------");
            Console.WriteLine();
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                if (i == 10)
                {
                    Console.Write(i + " |  ");
                }
                else
                {
                    Console.Write(i + "  |  ");
                }
                foreach (int j in numbers)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("\t" + i * j);
                    Console.ResetColor();
                }

                Console.WriteLine("");
                Console.WriteLine("");
            }

        }
        static void Main()
        {
            Console.BufferWidth = 400;
            Console.WriteLine("Выберите цикс, с помощью которого будет построена таблица:\n 1 - for, 2 - do..while, 3 - while, 4 - foreach");
            int res = Convert.ToInt32(Console.ReadLine());
            if (res == 1)
            {
                dotWithFor();
            }
            else if (res == 2)
            {
                dotWithDoWhile();
            }
            else if (res == 3)
            {
                dotWithWhile();
            }
            else if (res == 4)
            {
                dotWithForecach();
            }
            Console.ReadLine();
        }
    }
}
