using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.chapter_26
{
    // Command pattern
    public abstract class RobotCommand
    {
        public abstract void Run(Robot robot);
    }
    //On Command
    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPoweredOn = true;
        }
    }
    //Off Command
    public class OffCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPoweredOn = false;
        }
    }
    //North Command
    public class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPoweredOn)
                robot.Y++;
        }
    }

    //South Command
    public class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPoweredOn)
                robot.Y--;
        }
    }

    //East Command
    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPoweredOn)
                robot.X++;
        }
    }

    //West Command
    public class WestCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPoweredOn)
                robot.X--;
        }
    }
    
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPoweredOn { get; set; }
        public RobotCommand[] Commands { get; } = new RobotCommand[3];
        public void Run()
        {
            foreach(RobotCommand command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {(IsPoweredOn ? "ON" : "OFF")}]");
            }
        }
    }

}

