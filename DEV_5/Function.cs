using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_5
{
    class Function
    {
        public void carf()
        {
            string stop = null;
            string type = null;
            string exit = null;
            int totalcount = 0;
            int count = 0;
            int totalprice = 0;
            int totalpriceb = 0;
            int price = 0;
            int totalcountb = 0;
            int ii = 0;
            int gg = 0;

            List<Cars> people = new List<Cars>();
            List<string> marks = new List<string>();
            List<Type> uniqType = new List<Type>();

            while (true)
            {

                do
                {
                    ii++;
                    Console.Write("input type of car: ");
                    type = Console.ReadLine();
                    Console.Write("input model of car: ");
                    string model = Console.ReadLine();
                    Console.Write("input count: ");
                    count = int.Parse(Console.ReadLine());
                    Console.Write("input price of car: ");
                    price = int.Parse(Console.ReadLine());
                    people.Add(new Cars() { listtype = type, listmodel = model, listcount = count, listprice = price });
                    marks.Add(type);
                    Console.Write("press any key to continue or '1' for stop: ");
                    stop = Console.ReadLine();
                    marks = marks.Distinct().ToList();
                    if (type.Equals(type))
                    {
                        uniqType.Add(new Type() { listtypeb = type, listcountb = count, listpriceb = price });
                    }
                }

                while (stop != "1");

                foreach (Cars p in people)
                {
                    Console.WriteLine("type-" + p.listtype + " model-" + p.listmodel + " count-" + p.listcount + " price-" + p.listprice);
                    totalcount = totalcount + p.listcount;
                    totalprice = totalprice + p.listprice;
                }

                foreach (Type w in uniqType)
                {
                    gg++;
                    totalcountb = totalcountb + w.listcountb;
                    totalpriceb = totalpriceb + w.listpriceb;
                }
                Console.WriteLine("Input one of the commands: 'count types', 'count all', 'average price' or input exit");
                while (true)
                {
                    string command = Console.ReadLine(); //+ (commandtype= Console.ReadLine());

                    if (command.Equals("count types"))
                    {
                        Console.WriteLine("count of brands :" + marks.Count);
                    }
                    if (command.Equals("count all"))
                    {
                        Console.WriteLine("total count :" + totalcount);
                    }
                    if (command.Equals("average price"))
                    {
                        Console.WriteLine("average price :" + totalprice / ii);
                    }
                    string command4 = "average price" + " " + type;
                    if (command.Equals(command4))
                    {
                        Console.WriteLine("average price 123:" + totalpriceb / gg);
                    }
                    if (!command.Equals("count types") && !command.Equals("count all") && !command.Equals("average price") && !command.Equals(command4))
                    {
                        Console.WriteLine("command is incorrect");
                    }
                    if (command.Equals("exit"))
                    {
                        break;
                    }
                }

                Console.Write("if u want to continue press any key else input 'exit': ");
                exit = Console.ReadLine();
                if (exit.Equals("exit"))
                {
                    break;
                }
            }
        }
        class Cars
        {
            public string listtype { get; set; }
            public string listmodel { get; set; }
            public int listcount { get; set; }
            public int listprice { get; set; }

        }
        class Pers
        {
            public string listtype { get; set; }
        }

        class Type
        {
            public string listtypeb { get; set; }
            public int listcountb { get; set; }
            public int listpriceb { get; set; }
        }
    }
}
