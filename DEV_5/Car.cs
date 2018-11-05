using System;


namespace DEV_5
{
    class Car
    {
        public string type;
        public string model;
        public int count;
        public int price;
        public  Car()
        {
            Console.Write("input type of car: ");
            type = Console.ReadLine();
            Console.Write("input model of car: ");
            model = Console.ReadLine();
            Console.Write("input count: ");
            count = int.Parse(Console.ReadLine());
            Console.Write("input price of car: ");
            price = int.Parse(Console.ReadLine());
        }
    }
}
