using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanAkcheurov.NClassify;
using NTextCat;

namespace LanguageAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializimi i libraris per gjuhe 
            var factory = new RankedLanguageIdentifierFactory();
            var identitfier = factory.Load("NTextCat.0.2.1.30\\Core14.profile.xml");

            int i = 1;

            while (i == 1)
            {
                Console.WriteLine("enter your text :");
                var read = Console.ReadLine();

                //leximi i gjuhes ne baz te tekstit hyres
                var languages = identitfier.Identify(read);

                var mostCertainLanguage = languages.FirstOrDefault();

                if (mostCertainLanguage != null)
                {
                    Console.ReadLine();
                    Console.WriteLine("The language of the text is '{0}' \n", mostCertainLanguage.Item1.Iso639_3);
                    
                }
                else
                {
                    Console.ReadLine();
                    Console.WriteLine("the text coudnt be identified");
                }
            }
        }
    }
}
