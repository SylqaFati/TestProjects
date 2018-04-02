using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your words here : ");
            string  text = Console.ReadLine();
            int wordCount = 0, index = 0;
            while(index<text.Length)
            {

                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;
                wordCount++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.ReadLine();
            Console.WriteLine("there are {0} words", wordCount);
            Console.ReadLine();

            int wpm = (wordCount/120)*60;

            Console.WriteLine("text duration is {0} minutes", wpm);
            Console.ReadLine();
        }
    }
}
