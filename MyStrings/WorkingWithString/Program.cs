using System;
using System.Diagnostics;
using System.Text;

namespace WorkingWithString
{
    class Program
    {
        private static object timerForBuilder;

        static void Main(string[] args)
        {
            string myString = " Ana are mere! ";
            Console.WriteLine($"index of a:{myString.IndexOf('a')}"); //first index
            Console.WriteLine($"index of a:{myString.LastIndexOf('e')}"); //last index
            string mere = myString.Substring(9, 4); // de la pozitia 9 citesc 4 caractere
            Console.WriteLine(mere);

            string mere2 = myString.Substring(myString.IndexOf('m'), 4);
            Console.WriteLine(mere2);

            string cleanedString = myString.Trim(); //curata spatiul gol
            Console.WriteLine(cleanedString);

            string cleanedStringStart = myString.TrimStart(); //curata spatiul gol de la inceput
            Console.WriteLine(cleanedStringStart);

            string replaceString = myString.Replace(" ", "."); // inlocuieste spatiul cu punct
            Console.WriteLine(replaceString);

            string replaceA = myString.Replace("a", "!", true, new System.Globalization.CultureInfo("en-us")); //inlocuieste toate caracterele "a" cu "!"
            Console.WriteLine(replaceA);

            //split
            var splitted = myString.Trim().Split(new char[] { ' ' });
            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine(splitted[i]);
            }
            Console.WriteLine(myString.ToLower()); //scrie cu litere mici
            Console.WriteLine(myString.ToUpper()); //Scrie cu litere mari

            Console.WriteLine(myString.Remove(9, 4)); //sterge de la /pana la

            //concatenation
            string concatenated = "";

            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10000; i++)
            {
                concatenated = concatenated + i.ToString();

                //version 2
                //concatenated += i.ToString();
            }
            timer.Stop();
          //  Console.WriteLine(concatenated);
            Console.WriteLine(timer.Elapsed);

            //string for builder
            StringBuilder stringBuilder = new StringBuilder();
            Stopwatch timerForBuilder = new Stopwatch();
            timerForBuilder.Start();
            for (int i = 0; i < 10000000; i++)
            {
                stringBuilder.Append(i.ToString());
            }
            timerForBuilder.Stop();
           // Console.WriteLine(stringBuilder);
            Console.WriteLine(timerForBuilder.Elapsed);


            //formatare
            double d = 0.375;
            var s = String.Format("{0,10:F5}", d);
            Console.WriteLine(s);
        }
    }
}
