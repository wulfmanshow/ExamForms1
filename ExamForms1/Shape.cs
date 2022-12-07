using System;
using System.Collections.Generic;
using System.Text;

namespace ExamForms1
{
    class Shape
    {
        public int x;
        public int y;
        public int[,] matrix;

        public Shape(int _x, int _y)
        {
            x = _x;
            y = _y;
            matrix = new int[3, 3]
            {
                {0,1,1 },
                {0,1,1 },
                {0,0,0 }
            };
        }
        public void MooveDown()
        {
            y++;
        }
        public void MooveRight()
        {
            x++;
        }
        public void MooveLeft()
        {
            x--;
        }
    }
}
