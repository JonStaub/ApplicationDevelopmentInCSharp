using System;

namespace Time.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            int minute = 36;

            int minutesElapsed = (hour * 60) + (minute);
            Console.WriteLine($"Number of minutes since midnight: {minutesElapsed}");

            int secondsElapsed = 60*((hour * 60) + (minute));
            Console.WriteLine($"Number of seconds since midnight: {secondsElapsed}");

            int secondsRemaining = 86400 - secondsElapsed;
            Console.WriteLine($"Number of seconds remaining in the day: {secondsRemaining}");

            int dayPerCent = (secondsElapsed * 100) / 86400;
            Console.WriteLine($"Percentage of the day that has passed: {dayPerCent}%");

            //Commas added for clarity but would need to be removed for use in code
            //sbyte sbyte1 = -44;
            //sbyte sbyte2 = 97;
            //sbyte sbyte3 = 112;
            //sbyte sbyte4 = -115;
            //byte byte1 = 224;
            //short short1= 1990;
            //short short2 = -10000;
            //short short3 = 20000;
            //ushort ushort1 = 52130;
            //int int1 = -1,000,000;
            //int int2 = 4,825,932;
            //int int4 = 970,700,000;
            //ulong ulong1 = 123,456,789,123,456,789;

            Num(2011);
            Num(1988);
        }
        public static void Num(int num)
        {
            Console.WriteLine();
            Console.WriteLine($"The four digit number to be analyzed is: {num}");
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;

            int sumOfDigits = a + b + c + d;
            Console.WriteLine($"The sum of the digits is: {sumOfDigits}");
            Console.WriteLine($"The number reversed is: {a}{b}{c}{d}");
            Console.WriteLine($"The number with the last digit first is: {a}{d}{c}{b}");
            Console.WriteLine($"The number with inner digits switched is: {d}{b}{c}{a}");

        }
    }
}
