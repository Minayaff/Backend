using System;


namespace MesgulluqBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string week =DateTime.Now.DayOfWeek.ToString(); 

            switch (week)
            {
                case "Monday":
                    Console.WriteLine("Bazar ertesi");
                    break;
                case "Thuesday":
                    Console.WriteLine("Cersenbe axsami");
                    break;
            }

            string[] students = { "Qudret", "Mehebbet", "Lale","Minaya","Eli" };

            string word = "Eli";
            Console.WriteLine(word);
            Console.WriteLine(word[0]);
            Console.WriteLine(word[word.Length-1]);


        }
    }
}
