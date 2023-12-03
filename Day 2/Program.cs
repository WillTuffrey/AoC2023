using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static string[] ColourValues(string line, int[] ans)
        {
            string[] colours = new string[line.Length];
            for (int i = line.IndexOf(":"); i < line.Length; i++)
            {
                string letter = line[i].ToString();
                if (letter == ";")
                {
                    colours[i] = ";";
                }
                if (Char.IsNumber(line[i]))
                {
                    ans[i] = int.Parse(letter);
                    if (Char.IsNumber(line[i + 1]))
                    {
                        ans[i] = ans[i] * 10;
                        ans[i] += int.Parse(line[i + 1].ToString());
                        colours[i] = line[i + 3].ToString();
                        i++;
                    }
                    else { colours[i] = line[i + 2].ToString(); }
                }
            }
            return colours;
        }

        static List<int> Comparison(string line)
        {
            List<int> red = new List<int>();
            List<int> green = new List<int>();
            List<int> blue = new List<int>();
            red.Add(0);
            green.Add(0);
            blue.Add(0);
            int[] answers = new int[line.Length];
            string[] colours = new string[line.Length];


            colours = ColourValues(line, answers);

            int i = 0;
            int answer_pointer = 0;
            foreach (string colour in colours)
            {
                if (colour == ";")
                {
                    answer_pointer++;
                    red.Add(0);
                    green.Add(0);
                    blue.Add(0);
                }
                if (colour == "r")
                {
                    red[answer_pointer] += answers[i];
                }
                else if (colour == "g")
                {
                    green[answer_pointer] += answers[i];
                }
                else if (colour == "b")
                {
                    blue[answer_pointer] += answers[i];
                }
                i++;
            }
            List<int> minimums = new List<int>();
            minimums.Add(red.Max());
            minimums.Add(green.Max());
            minimums.Add(blue.Max());
            return minimums;

        }
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    inputs.Add(sr.ReadLine());
                }
            }
            int total = 0;
            int i = 0;
            foreach (string line in inputs)
            {
                int power = 1;
                i++;
                List<int> mins = Comparison(line);
                foreach (int num in mins)
                {
                    power *= num;
                }
                total += power;
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}