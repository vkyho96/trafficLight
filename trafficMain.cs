/*
 Program name: Traffic Light (assignment 2)
 Author: Van Ho
 Email: thefirstgoldenage@csu.fullerton.edu
 Language: C#
 Date of Development: 09-30-2018  -  10-03-2018

 Purpose of program: draw circle with selected radius.
 Features: 3 colors: Red, Green, Blue
           3 radius: 200, 400, 600
           Actions: Draw, Erase, Quit

 File name: drawCircleFrame.cs
 File Description: This file simply calls Drawcircleframe Form class
 Progress: COMPLETE

 How to run:
 In the terminal, past this command: 'sh build.sh'
 */

using System;
using System.Windows.Forms;
public class trafficLight
{
    public static void Main()
    {
        System.Console.WriteLine("The graphics program will begin now.");
        trafficFrame application = new trafficFrame();
        Application.Run(application);
        System.Console.WriteLine("This graphics program has ended.  Bye.");
    }//End of Main function
}//End of class
