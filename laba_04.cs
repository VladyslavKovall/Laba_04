using System;
using System.Collections.Generic;

class Program
{
    struct Sportsman
    {
        public string lastName;
        public string country;
        public int birthYear;

        public string GetInfo()
        {
            return $"Прізвище: {lastName}, Країна: {country}, Рік: {birthYear}";
        }
    }

    static void Main(string[] args)
    {
        List<Sportsman> sportsmen = new List<Sportsman>();

        Console.WriteLine("Введіть дані для 5 спортсменів:");

        for (int i = 0; i < 5; i++)
        {
            Sportsman s;
            Console.WriteLine($"Спортсмен {i + 1}:");

            Console.Write("Прізвище: ");
            s.lastName = Console.ReadLine();

            Console.Write("Країна: ");
            s.country = Console.ReadLine();

            Console.Write("Рік народження: ");
            s.birthYear = Convert.ToInt32(Console.ReadLine());

            sportsmen.Add(s);
        }

        Console.WriteLine("\nСписок спортсменів:");
        foreach (var sportsman in sportsmen)
        {
            Console.WriteLine(sportsman.GetInfo());
        }

        Console.WriteLine("\nВведіть назву країни для пошуку:");
        string searchCountry = Console.ReadLine();

        int count = 0;
        Sportsman youngestSportsman = new Sportsman { birthYear = int.MaxValue };

        foreach (var sportsman in sportsmen)
        {
            if (sportsman.country == searchCountry)
            {
                count++;
                if (sportsman.birthYear > youngestSportsman.birthYear)
                {
                    youngestSportsman = sportsman;
                }
            }
        }

        Console.WriteLine($"\nКількість спортсменів з країни {searchCountry}: {count}");

        if (count > 0)
        {
            Console.WriteLine($"Наймолодший спортсмен з країни {searchCountry}: {youngestSportsman.GetInfo()}");
        }
        else
        {
            Console.WriteLine($"Спортсменів з країни {searchCountry} не знайдено.");
        }

        Console.ReadKey();
    }
}
