using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG
{
    public class Player
    {

        private int health;
        public int Health { get { return health; } set { health = value; } }


        private int hunger;
        public int Hunger { get { return hunger; } set { hunger = value; } }


        private int rest;
        public int Rest { get { return rest; } set { rest = value; } }


        private int temperature;
        public int Temperature { get { return temperature; } set { temperature = value; } }
    }
}
