using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
        public class Point
        {
            public int x { get; set; }
            public int y { get; set; }

            // Constructor
            public Point() : this(0, 0) { 
            }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
}
