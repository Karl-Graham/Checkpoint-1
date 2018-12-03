using System;

namespace Checkpoint01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = GetUserInput();
            Console.WriteLine();
            string[] trianglesArray = CreateArrayofTriangles(input);
            foreach (string i in trianglesArray)
            {
                DrawTriangle(i);                                              
            }
            Console.WriteLine();
        }

        private static string[] CreateArrayofTriangles(string input)
        {
            string[] trianglesArray = input.Split('-');
            return trianglesArray;
                                                       
        }

        //TODO: ändra ordningen på metoderna till att motsvara hur programmet körs, dvs GetUserInput() borde ligga ovanför CreateArrayOfTriangles
        private static string GetUserInput()
        {
            Console.Write("Write command: ");
            string input = Console.ReadLine().ToLower();
            return input;

        }

        private static void DrawTriangle(string l)
        {
                string m = l.Substring(1);
                int t = int.Parse(m);

            for (int i = 1; i <= t; i++)
            {              
                if (l[0] == 'a')
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (l[0] == 'b')
                {
                    for (int j = 0; j <= t-i; j++)
                    {
                        Console.Write("*");
                    }    
                    Console.WriteLine();
                }
            }
        }
    }
}
