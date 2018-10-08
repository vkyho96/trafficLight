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

  public static int trafficClock(int tracker, ref System.Timers.Timer traffic_clock, ref Brush traffic_light_brush){  
     switch(tracker){
                //cases 0-2 Slow Timer
        case 0: traffic_clock.Interval = (int)4000;
                traffic_light_brush = Brushes.Red;
                break;
        case 1: traffic_clock.Interval = (int)3000;
                traffic_light_brush = Brushes.Green;
                break;
        case 2: traffic_clock.Interval = (int)1000;
                traffic_light_brush = Brushes.Yellow;
                break;
                //cases 3-5 Medium Timer
        case 3: traffic_clock.Interval = (int)2000;
                traffic_light_brush = Brushes.Red;
                break;
        case 4: traffic_clock.Interval = (int)1500;
                traffic_light_brush = Brushes.Green;
                break;
        case 5: traffic_clock.Interval = (int)500;
                traffic_light_brush = Brushes.Yellow;
                break;
                //cases 6-8 Fast Timer
        case 6: traffic_clock.Interval = (int)1000;
                traffic_light_brush = Brushes.Red;
                break;
        case 7: traffic_clock.Interval = (int)750;
                traffic_light_brush = Brushes.Green;
                break;
        case 8: traffic_clock.Interval = (int)250;
                traffic_light_brush = Brushes.Yellow;
                break;

        }
        return (tracker + 1) % 8;
     }
 }//End of class
