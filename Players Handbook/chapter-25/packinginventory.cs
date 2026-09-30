using Players_Handbook.chapter_24;
using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.chapter_25
{
    internal class packinginventory
    {
        public class InventoryItem
        {
            public string Name { get; set; }
            public double Weight { get; set; }
            public double Volume { get; set; }
            public InventoryItem(string name, double weight, double volume)
            {
                Name = name;
                Weight = weight;
                Volume = volume;
            }

            public class Arrow : InventoryItem
            {
                public Arrow() : base("Arrow", 0.1, 0.05)
                {
                }
            }

            public class Bow : InventoryItem
            {
                public Bow() : base("Bow", 1.0, 4.0)
                {
                }
            }

            public class Rope : InventoryItem
            {
                public Rope() : base("Rope", 1.5, 1.0)
                {
                }
            }

           public class Water : InventoryItem
            {
                public Water() : base("Water", 2.0, 1.0)
                {
                }
            }
            public class Food : InventoryItem
            {
                public Food() : base("Food", 1.0, 0.5)
                {
                }
            }
            public class Sword : InventoryItem
            {
                public Sword() : base("Sword", 3.0, 2.0)
                {
                }
            }
            public class Shield : InventoryItem
            {
                public Shield() : base("Shield", 5.0, 3.0)
                {
                }
            }

            public class WaterSkin : InventoryItem
            {
                public WaterSkin() : base("Water Skin", 1.0, 0.5)
                {
                }
            }

            public class Lantern : InventoryItem
            {
                public Lantern() : base("Lantern", 2.0, 1.0)
                {
                }
            }

            //Pack class
            public class Pack
            {
                public List<InventoryItem> Items { get; set; }
                public double MaxWeight { get; set; }
                public double MaxVolume { get; set; }
                public Pack(double maxWeight, double maxVolume)
                {
                    Items = new List<InventoryItem>();
                    MaxWeight = maxWeight;
                    MaxVolume = maxVolume;
                }
                public bool AddItem(InventoryItem item)
                {
                    double currentWeight = 0;
                    double currentVolume = 0;
                    foreach (var i in Items)
                    {
                        currentWeight += i.Weight;
                        currentVolume += i.Volume;
                    }
                    if (currentWeight + item.Weight <= MaxWeight && currentVolume + item.Volume <= MaxVolume)
                    {
                        Items.Add(item);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            } 
        }
    }
}
