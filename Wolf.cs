using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace поедалки
{
    class Wolf : Female_wolf
    {
        public double Hp;
        public Wolf(System.Drawing.Point point) : base(2, point)
        {
            this.Hp = 1;
        }
        public override int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = 3;
            }
            public Rabbit Eater(Island island)
        {
            List<Cell> cells = See(island);
            foreach (Cell cell in cells)
            {
                if (cell.en.Id == 0)
                {
                    Hp++;
                    return (Rabbit)cell.en;
                }
            }
            return null;

        }
        public List<Cell> See(Island island)
        {
            List<Cell> cells = new List<Cell>();
            if ((point.X - 1) >= 0)
            {
                if ((point.Y - 1) >= 0)
                    cells.Add(island.field[point.X - 1, point.Y - 1]);
                cells.Add(island.field[point.X - 1, point.Y]);
                if ((point.Y + 1) <= 20)
                    cells.Add(island.field[point.X - 1, point.Y + 1]);


            }

            if ((point.X + 1) <= 20)
            {
                if ((point.Y - 1) >= 0)
                    cells.Add(island.field[point.X + 1, point.Y - 1]);
                cells.Add(island.field[point.X + 1, point.Y]);
                if ((point.Y + 1) <= 20)
                    cells.Add(island.field[point.X + 1, point.Y + 1]);


            }
            if ((point.Y + 1) <= 20)
            {
                cells.Add(island.field[point.X, point.Y + 1]);
            }
            if ((point.Y - 1) >= 0)
            {
                cells.Add(island.field[point.X, point.Y - 1]);
            }
            return cells;
        }
        public void New_Wolf(Island island)
        {
            Random random = new Random();
            List<Cell> cells = See(island);
            foreach (Cell cell in cells)
            {
                if (random.Next(1, 2) == 1)
                {
                    Wolf wolf1 = new Wolf(new System.Drawing.Point(random.Next(1, 20), random.Next(1, 20)));
                }
                else
                {
                    Female_wolf femwolf1 = new Female_wolf(new System.Drawing.Point(random.Next(1, 20), random.Next(1, 20)));
                }
            }
        }
        public override void Move()
        {
            Hp -= 0.1;
            base.Move();

        
        }
    }
}
        }
    }
}