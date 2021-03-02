/*   Think Sharp Exercise 2.3 pages 21-22.

  1) Following the example in Section 2.6, create variables named hour, minute and second, and assign them values that are 
     roughly the current time. Use a 24-hour clock, so that at 2pm the value of hour is 14.
  2) Make the program calculate and print the number of seconds since midnight.
  3) Make the program calculate and print the number of seconds remaining in the day.
  4) Make the program calculate and print the percentage of the day that has passed.
  5) Change the values of hour, minute and second to reflect the current time (I assume that some time has elapsed), and check 
     to make sure that the program works correctly with different values.
 * 
 */

using System;

namespace ThinkSharp_Exercise2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int hour = 10; //Step 1 of Exercise 2.3
            int minute = 36; */

            int hour = 11; //Step 5 of Exercise 2.3
            int minute = 18;

            int minutesElapsed = (hour * 60) + (minute);
            Console.WriteLine($"Number of minutes since midnight: {minutesElapsed}"); 

            int secondsElapsed = 60 * ((hour * 60) + (minute));
            Console.WriteLine($"Number of seconds since midnight: {secondsElapsed}"); //Step 2 of Exercise 2.3

            int secondsRemaining = 86400 - secondsElapsed;
            Console.WriteLine($"Number of seconds remaining in the day: {secondsRemaining}"); //Step 3 of Exercise 2.3

            int dayPerCent = (secondsElapsed * 100) / 86400;
            Console.WriteLine($"Percentage of the day that has passed: {dayPerCent}%"); //Step 4 of Exercise 2.3
        }
    }
}
