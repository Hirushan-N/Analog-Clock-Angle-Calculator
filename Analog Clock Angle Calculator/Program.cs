using System;

namespace AnalogClockAngleCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the hour (1-12): ");
            int hour = int.Parse(Console.ReadLine());

            Console.Write("Enter the minute (0-59): ");
            int minute = int.Parse(Console.ReadLine());

            Console.WriteLine(hour % 12);
            Console.WriteLine(minute / 60.0);
            double hourAngle = (hour % 12 + minute / 60.0) * 30;
            double minuteAngle = minute * 6;
            double angle = Math.Abs(hourAngle - minuteAngle);
            if (angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine($"The lesser angle between the hour and minute hands is {angle} degrees.");
        }
    }
}

