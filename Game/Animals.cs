using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HelloTest
{
    public abstract class Animal
    {
        private int id;
        public abstract int Id
        {
            get;
            set;
        }

        public System.Drawing.Point point;
        public Animal(Point point)
        {
            this.point = point;

        }
        public virtual void Move()
        {
            Random random = new Random();
            point.X = point.X + random.Next(-1, 1);
            point.Y = point.Y + random.Next(-1, 1);

        }
    }

}