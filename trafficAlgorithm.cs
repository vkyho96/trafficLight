/*
 Program name: Draw Circle (assignment 1)
 Author: Van Ho
 Email: thefirstgoldenage@csu.fullerton.edu
 Language: C#
 Date of Development: 09-10-2018  -  09-30-2018

 Purpose of program: draw circle with selected radius.
 Features: 3 colors: Red, Green, Blue
           3 radius: 200, 400, 600
           Actions: Draw, Erase, Quit

 File name: circlealgorithm.cs
 File Discription: this file provide imformation to draw the circles.
 Issue: NONE
 Progress: COMPLETE

 How to run:
 In the terminal, past this command: 'sh build.sh'
 */




 using System;
 using System.Drawing;
 using System.Timers;

 public class Clock_algorithms{

  public static int slowClock(int message_counter, ref System.Timers.Timer traffic_clock, ref Brush painting_tool){
    //traffic_clock.Start();
     switch(message_counter){
        case 0: traffic_clock.Interval = (int)4000;
                 break;
         case 4000: traffic_clock.Interval = (int)3000;
                 painting_tool = Brushes.Green;
                 break;
         case 7000: traffic_clock.Interval = (int)1000;
                 painting_tool = Brushes.Yellow;
                 break;

        }//End of switch

    //  traffic_clock.Stop();
     }//End of method s

 }//End of class
