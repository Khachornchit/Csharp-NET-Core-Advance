﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance._07_Events
{
    public class Person
    {
        private string name;
        private ClockTower tower;

        public Person(string name, ClockTower tower)
        {
            this.name = name;
            this.tower = tower;
            tower.Chime += (object sender, ClockTowerEventArgs args) => 
            {
                Console.WriteLine("{0} heard the clock time !", this.name);
                switch (args.Time)
                {
                    case 6: 
                        Console.WriteLine("{0} is waking up.", this.name);
                        break;
                    case 17:
                        Console.WriteLine("{0} is going back home.", this.name);
                        break;
                }
            };
        }
    }
}
