using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Program
    {
        static void replace(ref string word)
        {
            word = word.Replace("oneight", "18");
            word = word.Replace("twone", "21");
            word = word.Replace("eightwo", "82");
            word = word.Replace("eighthree", "83");
            word = word.Replace("threeight", "38");
            word = word.Replace("fiveight", "58");
            word = word.Replace("sevenine", "79");
            word = word.Replace("one", "1");
            word = word.Replace("two", "2");
            word = word.Replace("three", "3");
            word = word.Replace("four", "4");
            word = word.Replace("five", "5");
            word = word.Replace("six", "6");
            word = word.Replace("seven", "7");
            word = word.Replace("eight", "8");
            word = word.Replace("nine", "9");
            word = word.Replace("zero", "0");
        }
        static void Main(string[] args)
        {
            string line = "";
            char firstNum = ' ';
            char secondNum = ' ';
            string number = "";
            int total = 0;

            List<char> word = new List<char> { };
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    replace(ref line);
                    foreach (char c in line)
                    {
                        word.Add(c);
                    }
                    for (int i = 0; i < word.Count; i++)
                    {
                        char currentLetter = word[i];
                        int currentInt = (int)currentLetter;
                        if (currentInt <= 57 && currentInt >= 48)
                        {
                            firstNum = (char)currentInt;
                            break;
                        }
                    }
                    word.Reverse();
                    for (int i = 0; i < word.Count; i++)
                    {
                        char currentLetter = word[i];
                        int currentInt = (int)currentLetter;
                        if (currentInt <= 57 && currentInt >= 48)
                        {
                            secondNum = (char)currentInt;
                            break;
                        }
                    }
                    number = firstNum.ToString() + secondNum.ToString();
                    total += Int32.Parse(number);
                    word.Clear();
                    line = "";
                }
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
