using System;
using System.Collections.Generic;
using System.Text;

namespace HelloTest
{
    class Island
    {
        private const byte width = 20;
        private const byte height = 20;

        public Cell[,] field = new Cell[width, height];
    }
}