
using System.Collections.Generic;


namespace DEV_5
{
    class ListCar
    {
   
        ListCar()
        {
            List<Cars> people = new List<Cars>();
            people.Add(new Cars() {  });
        }
            class Cars
        {
            public string listtype { get; set; }
            public string listmodel { get; set; }
            public int listcount { get; set; }
            public int listprice { get; set; }
        }
       }
    }

