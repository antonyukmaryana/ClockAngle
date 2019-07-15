using System;
using System.Collections.Generic;
class Clock
{
  static int Angle (int hour, int minutes)
  {
    int degree = 0;
    if (minutes == 0 && hour == 12){
      return degree;
      }
      else {
        if (hour >= 6){
          int num = 12 - hour;
          degree = num*30;
          return degree;

        }
        else {
          int num = 12 -hour;
          num = 12 -num;
          degree = num*30;
          return degree;
        }
      }
    }

  static void Main ()
  {

    Console.WriteLine ("Enter hour");
    string Hour = Console.ReadLine();
    int inputtedHour=int.Parse(Hour);
    Console.WriteLine ("Enter minutes");
    string Minutes = Console.ReadLine();
    int inputtedMinutes=int.Parse(Minutes);
    int degree= Angle(inputtedHour, inputtedMinutes);
    Console.WriteLine ("Degree is:" + degree);
  }

}
