using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_ClockHandsAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Clear();

                    Console.Write("\nEnter the coordinate of the 1st circle's center\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    GetAngle(input);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }

        private static void GetAngle(string input)
        {
            string[] arr = input.Split(':');
            int hHand = int.Parse(arr[0]);
            int mHand = int.Parse(arr[1]);
            if (hHand == 12)
            {
                hHand = 0;
            }
            double angle = mHand * 6 - (hHand * 5 + mHand * 1 / 12.0);
            if (angle > 180)
            {
                angle = 360 - angle;
            }
            Console.WriteLine($"\nThe angle between the hands is {angle} degrees");
        }
    }
}
