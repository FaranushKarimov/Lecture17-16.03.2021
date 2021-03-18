using System;
using System.Linq;
namespace Lecture17_16._03._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            {
                string change = "aeiou";
                string input = Console.ReadLine();
                var ans = new string(input.Select((i) => (change.Contains(i) ? ((char)((int)48 + change.IndexOf(i) + 1)) : i)).ToArray());
                Console.WriteLine(ans);
            }

            //2
            {
                string change = "12345";
                string output = "aeiou";
                string input = Console.ReadLine();
                var ans = new string(input.Select((i) => change.Contains(i) ? output.ElementAtOrDefault(change.IndexOf(i)) : i).ToArray());
                Console.WriteLine(ans);
            }

            //3
            {
                string input = "fsfd23sdf*dsf2";
                var operation = (input.Where(i => Char.IsPunctuation(i)).ToArray()[0]);
                var clearText = new string(input.Where(i => Char.IsDigit(i) || char.IsPunctuation(i)).ToArray()).Split(operation);

                double first = double.Parse(clearText[0]);
                double second = double.Parse(clearText[1]);

                if (operation == '+') Console.WriteLine(first + second);
                if (operation == '/') Console.WriteLine(first / second);
                if (operation == '-') Console.WriteLine(first - second);
                if (operation == '*') Console.WriteLine(first * second);

            }
            // 4 
            {
                string input = Console.ReadLine();
                string ans = "";
                var result = input.Select((i) => i.ToString()).Select(((item) => char.IsUpper(char.Parse(item)) ? " " + item : item)).ToArray().Aggregate((i, t) => i + t);
                Console.WriteLine(result);

            }
        }
    }
}
