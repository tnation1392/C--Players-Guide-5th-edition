using Players_Handbook.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    public class thecolor
    {
        public int red { get; set; }

        public int green { get; set; }

        public int blue { get; set; }

        //orange color
        public thecolor orange
        {
            get
            {
                return new thecolor(255, 165, 0);
            }
        }

        //white color
        public thecolor white
        {
            get
            {
                return new thecolor(255, 255, 255);
            }
        }

        //green color
        public thecolor cgreen
        {
            get
            {
                return new thecolor(0, 255, 0);
            }
        }

        //red color
        public thecolor cred
        {
            get
            {
                return new thecolor(255, 0, 0);
            }
        }

        //blue color
        public thecolor cblue
        {
            get
            {
                return new thecolor(0, 0, 255);
            }
        }


        //constructor
        public thecolor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }


        static void Main(string[] args)
        {
            thecolor color1 = new thecolor(100, 50, 200);
            

            Console.WriteLine(color1);
            
        }

        public static void Run()
        {
        }

    }


}

