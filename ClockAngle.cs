using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    Console.Write("{0,15:N5}","Enter time to get the degreess of the clock face : ");
    Console.WriteLine();

    Console.Write("{0,15:N5}","hour: ");
    int hour = int.Parse(Console.ReadLine());

    if(hour > 12)
    {
      Console.WriteLine("Hour must be less then 12");
      Console.Write("{0,15:N5}","hour: ");
      hour = int.Parse(Console.ReadLine());
    }

    Console.Write("{0,15:N5}","minutes: ");
    int minutes = int.Parse(Console.ReadLine());
    if(minutes > 60)
    {
      Console.WriteLine("Minutes must be less than 60");
      Console.Write("{0,15:N5}","minutes: ");
      minutes = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();

    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("{0,15:N5}", GetAngle(hour, minutes) + " Degrees");
    Console.WriteLine("--------------------------------------------");
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
     return result = (360 - angle);
    }
    else
    {
      return result = angle;
    }
  }
}