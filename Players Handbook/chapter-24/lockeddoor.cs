using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.chapter_24
{
    internal class lockeddoor
    {



        //status 
        public enum DoorStatus
        {
            Locked,
            Unlocked,
            Open,
            Closed
        }

        public class Door
        {
            public DoorStatus Status { get; set; }
            public Door()
            {
                Status = DoorStatus.Locked;
            }
            public void Unlock()
            {
                if (Status == DoorStatus.Locked)
                {
                    Status = DoorStatus.Unlocked;
                    Console.WriteLine("The door is now unlocked.");
                }
                else
                {
                    Console.WriteLine("The door is already unlocked or open.");
                }
            }
            public void Open()
            {
                if (Status == DoorStatus.Unlocked)
                {
                    Status = DoorStatus.Open;
                    Console.WriteLine("The door is now open.");
                }
                else if (Status == DoorStatus.Locked)
                {
                    Console.WriteLine("The door is locked. You need to unlock it first.");
                }
                else
                {
                    Console.WriteLine("The door is already open.");
                }
            }
            public void Close()
            {
                if (Status == DoorStatus.Open)
                {
                    Status = DoorStatus.Closed;
                    Console.WriteLine("The door is now closed.");
                }
                else
                {
                    Console.WriteLine("The door is not open, so it cannot be closed.");
                }
            }
        }
    }
}
