using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class arrowfactory
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

            public void SetHead(ArrowHead head)
            {
                _head = head;
            }
            public void SetFletching(Fletching fletching)
            {
                _fletching = fletching;
            }
            public void SetLength(float length)
            {
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

            public static Arrow CreateEliteArrow()
            {
                return new Arrow(ArrowHead.Steel, Fletching.GooseFeathers, 95);
            }

            public static Arrow CreateBeginnerArrow()
            {
                return new Arrow(ArrowHead.Wood, Fletching.GooseFeathers, 75);
            }

            public static Arrow CreateMarksmanArrow()
            {
                return new Arrow(ArrowHead.Steel, Fletching.GooseFeathers, 65);
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