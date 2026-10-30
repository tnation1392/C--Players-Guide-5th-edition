using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.chapter_29
{
    internal class warprep
    {
        public record Sword
            (
            material Material,
            gem Gem,
            int CrossWidth
            );

        Sword sword = new Sword(material.Steel, gem.Diamond, 5);
        Sword sword2 = new Sword(material.Wood, gem.None, 2);
        Sword sword3 = sword2 with 
        {
            Gem = gem.Sapphire
        };

    }

    public enum material
    {
        Wood,
        Stone,
        Iron,
        Steel,
        Binarium
    }

    public enum gem
    {
        None,
        Amber,
        Sapphire,
        Emerald,
        Diamond
    }
}


