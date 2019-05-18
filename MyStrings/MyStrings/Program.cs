using System;

namespace MyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyString = "my awesome string";
            for (int i = 0; i < MyString.Length; i++)

            {
                Console.WriteLine(MyString[i]);
            }

            for (int i = 0; i < MyString.Length; i++)
            {
                Console.Write(MyString[i]);
            }

            string myCoolString = "My awesome string";
            Console.WriteLine(myCoolString.Length);

            string s = string.Empty;
            string b = s;
            Console.WriteLine(s);
            Console.WriteLine($"b: {b}");

            int myInt = 30;
            string myIntAsString = myInt.ToString();
            Console.WriteLine($"myIntAsString: {myIntAsString}");
        }
    }
}
