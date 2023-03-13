using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HelloTest
{
    class Female_wolf : Animal
    {
        public double Hp;

        public Female_wolf(int id, System.Drawing.Point point) : base(point)
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
                Id = 2;
            }
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
       

        public override void Move()
        {
            Hp -= 0.1;
            base.Move();

        }
    }
}