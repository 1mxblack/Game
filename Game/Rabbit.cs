using System;
using System.Collections.Generic;
using System.Text;

namespace HelloTest

{
    class Rabbit : Animal
    {
        public Rabbit(System.Drawing.Point point) : base(point)
        {

        }
        public override int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = 1;
            }
        }
        public Rabbit Divider()
        {
            Rabbit rabbit = null;
            Random random = new Random();
            if (random.Next(1, 5) == 1)
            {
                Rabbit rabbit1 = new Rabbit(new System.Drawing.Point(random.Next(1, 20), random.Next(1, 20)));
            }
            return rabbit;
        }
    }
}