using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_Day6
{
    class Fish
    {

        public int timeToReproduce = 8;

        public bool isNew = false;

        public Fish()
        {
            isNew = true;
        }

         public bool TryToReproduce()
        {
            if (this.timeToReproduce == 0)
            {
                this.timeToReproduce = 6;
                this.isNew = true;
                return true;
            }
            else return false;
        }

        public void DecreaseTimeToReproduce()
        {
            this.timeToReproduce--;
        }
    }
}
