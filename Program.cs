using System;

namespace PAYSCHEDULER
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample mySample = new Sample();
            mySample.Color = "red";
            mySample.Speed = 25; 
            Console.WriteLine(mySample.Color + mySample.Speed);
        }
    }
}
