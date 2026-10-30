using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class arrow
    {
        public class Arrow
        {
            private ArrowHead _head;
            private Fletching _fletching;
            private float _length;

            public Arrow(ArrowHead head, Fletching fletching, float length)
            {
                _head = head;
                _fletching = fletching;
                _length = length;
            }

            public ArrowHead GetHead()
            {
                return _head;
            }

            public Fletching GetFletching()
            {
                return _fletching;
            }

            public float GetLength()
            {
                return _length;
            }
        }

        public enum ArrowHead
        {
            Steel,
            Wood,
            Obsidian
        }

        public enum Fletching
        {
            Plastic,
            TurkeyFeathers,
            GooseFeathers
        }
    }
}