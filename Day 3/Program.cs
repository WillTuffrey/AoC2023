using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Program
    {
        // not working
        static bool IsAdjacent(string[] row)
        {
            return true;
        }
        static bool IsNum(char l)
        {
            switch (l)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
                default:
                    return false;
            }
        }
        static bool IsSymbol(char l)
        {
            switch (l)
            {
                case '*':
                case '£':
                case '$':
                case '%':
                case '^':
                case '&':
                case '@':
                case '#':
                case '+':
                case '=':
                case '/':
                case '-':
                    return true;
                default:
                    return false;
            }
        }
        static void Main(string[] args)
        {
            string[] rows = new string[140];
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    int counter = 0;
                    rows[counter] = sr.ReadLine();
                    counter++;
                }
            }
            for (int i = 1; i < rows.Length; i++)
            {
                List<char> chars1 = new List<char>();
                List<char> chars2 = new List<char>();
                string compareRow1 = rows[i - 1];
                string compareRow2 = rows[i];
                    
                foreach (char c in chars1)
                {
                    chars1.Add(c);
                }
                foreach (char c in chars2)
                {
                    chars2.Add(c);
                }

                Console.WriteLine(compareRow1);
                Console.WriteLine(compareRow2);
                Console.ReadKey();

                for (int j = 0; j < chars1.Count; j++)
                {
                    
                }
            }
            Console.ReadKey();
        }
    }
}