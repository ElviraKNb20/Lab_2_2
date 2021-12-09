using System;

namespace Lab_2_2
{
    class Search
    {
        public int year { get; set; }
        public string name { get; set; }
        public int diameter { get; set; }
        public int frequency { get; set; }
        static int count { get; set; }
        public Search(int y, string n, int d, int f)
        {
            year = y;
            name = n;
            diameter = d;
            frequency = f;
        }
        public Search[] arr = new Search[10];
        public void Count()
        {
            count = arr.Length;
            Console.WriteLine("Кiлькiсть об’єктiв: " + count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search(0, "", 0, 0);
            for (int i = 0; i < search.arr.Length; i++)
            {
                Console.Write("Рiк: ");
                int year = Convert.ToInt16(Console.ReadLine());
                Console.Write("Науковий керiвник: ");
                string name = Console.ReadLine();
                Console.Write("Дiаметр антени (м): ");
                int diameter = Convert.ToInt16(Console.ReadLine());
                Console.Write("Робоча частота (Мгц): ");
                int frequency = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");
                search.arr[i] = new Search(year, name, diameter, frequency);
            }
            search.Count();
            Console.WriteLine("");
            int a = 0;
            for (int i = 0; i < search.arr.Length; i++)
            {
                if (search.arr[i].year < 2000)
                    a++;
            }
            if (a > 0)
                Console.WriteLine("Кількість позаземних сиглалів до 2000 років: " + a);
            else
                Console.WriteLine("Пошук позаземних сигналiв не вiдбувався до 2000 року");
            Console.WriteLine("");
            if (search.arr.Length < 3)
                Console.WriteLine("Кiлькiсть наявних об'єктiв менше ніж заданих у таблиці");
            else if (search.arr.Length > 3)
                Console.WriteLine("Кiлькiсть наявних об'єктiв перевищує табличні дані");
        }
    }
}
