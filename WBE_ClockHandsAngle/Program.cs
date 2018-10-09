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
                    Console.Write("\nEnter the coordinate of the 1st circle's center\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    GetAngle(input);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                Console.Write("\nPress Enter to try again...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        private static void GetAngle(string input)
        {
            double angle = -1;
            string[] arr = input.Split(':');
            int hHand = int.Parse(arr[0]);
            int mHand = int.Parse(arr[1]);
            // ensures that correct angle is going to be calculated even if the input is in 24-hour format
            // also marks the 12 o'clock as starting point for measuring angles 
            hHand = hHand >= 12 ? hHand - 12 : hHand;
            if (!(hHand >= 0 && hHand <= 12) || !(mHand >= 0 && mHand <= 59))
            {
                throw new Exception("\nInvalid Entry!");
            }
            else
            {
                angle = mHand * 6 - (hHand * 30 + mHand * 1 / 2.0);
                // assigns the value of the smaller angle formed by the hands to the variable angle
                angle = angle > 180 ? 360 - angle : angle;
            }
            Console.WriteLine($"\nThe angle between the hands is {angle} degrees");
        }
    }
}
