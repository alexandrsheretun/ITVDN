using System;

namespace ConAppTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word in Russian : ");
            string weather = Console.ReadLine();
            string result = null;

            switch (weather)
            {
                case "пасмурно":
                    {
                        result = "Mainly cloudy";
                        break;
                    }
                case "солнечно":
                    {
                        result = "sunny";
                        break;
                    }
                case "дождливо":
                    {
                        result = "rainy";
                        break;
                    }
                case "ветренно":
                    {
                        result = "windy";
                        break;
                    }
                case "тумано":
                    {
                        result = "foggy";
                        break;
                    }
                case "облачно":
                    {
                        result = "cloudy";
                        break;
                    }
                case "снежно":
                    {
                        result = "snowy";
                        break;
                    }
                case "засуха":
                    {
                        result = "drought";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("В переводчике нету слова для перевода. Попробуйте ввести другое слово!");
                        break;
                    }

            }
            Console.WriteLine("Translate : {0}", result);
            Console.ReadKey();
        }
    }
}
