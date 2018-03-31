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
            //    int numberofCharacters = Console.ReadLine().ToCharArray().Count();

            //string word = "this task is for testing only";
            Console.WriteLine("enter your words");

            string word = Console.ReadLine();





            int numberOfCharacters = word.ToCharArray().Count();

         

            //foreach (var item in word)
            //{
            //    numberOfCharacters++;

            //}

            //int averageWpm = (130 / 60)*60;
            
          


            Console.ReadLine();
            Console.WriteLine("there are {0} words in this sentence", numberOfCharacters);
            int tmp = numberOfCharacters;
            Console.ReadLine();



          


            int wpm = (tmp / 60) * 60
                ;
            Console.WriteLine("your text duration is : {0}  minutes", wpm);
            Console.ReadLine();

           
        }
    }
}
