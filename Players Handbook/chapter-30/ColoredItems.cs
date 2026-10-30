using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.chapter_30
{
    internal class ColoredItems
    {
        public class Sword { }
        public class Bow { }
        public class Axe { }

        public class ColoredItem<T>
        {
            public T Item { get; set; }
            public string Color { get; set; }
            public ColoredItem(T item, string color)
            {
                Item = item;
                Color = color;
            }
        }

        ColoredItem<Sword> coloredSword = new ColoredItem<Sword>(new Sword(), "Red");
        ColoredItem<Bow> coloredBow = new ColoredItem<Bow>(new Bow(), "Blue");
        ColoredItem<Axe> coloredAxe = new ColoredItem<Axe>(new Axe(), "Green");
    }
}
