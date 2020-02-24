using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter time:");
    Console.WriteLine("hour:");
    int hour = int.Parse(Console.ReadLine());
    Console.WriteLine("minutes:");
    int minutes = int.Parse(Console.ReadLine());
    Console.WriteLine(GetAngle(hour, minutes));
  }

  static int GetAngle(int hour, int minutes)
  {
    // int minutePosition = minutes / 5;
    int hourPosition = hour * 5;
    int distance = Math.Abs(hourPosition - minutes);
    int angle = distance * 6;
    int result;
    if (angle > 180)
    {
     return result = 360 - angle;
    }
    else
    {
      return result = angle;
    }
  }
}