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

 File Name: drawCircleFrame.cs
 File Discription: This file builds the graphical interface of the program
 Issue: NONE
 Progress: COMPLETE
 Comment: might remove button hover

 How to run:
 In the terminal, past this command: 'sh build.sh'
 */


using System;
using System.Drawing;
using System.Windows.Forms;

public class trafficFrame : Form
{   
    //application size
    private const int formwidth = 1600;
    private const int formheight = 900;

    
    private Label title = new Label();

    //Colors
    private Color myBlue = Color.FromArgb(0, 191, 255);
    private Color mygreen = Color.FromArgb(153, 204, 51);
    private Color backgroundColor = Color.FromArgb(57, 96, 115);

    private Color backgroundColor_2 = Color.FromArgb(64, 107, 128);

    //utility 
    Pen myPen = new Pen(Color.White, 3);
    Pen outLine = new Pen(Color.FromArgb(198, 226, 255), 1); 
    SolidBrush myBrush = new SolidBrush(Color.Red);
    private Font font_large = new Font("Comic Sans MS", 36, FontStyle.Regular);
    private Font font_medium = new Font("Comic Sans MS", 24, FontStyle.Regular);
    private Font font_small = new Font("Comic Sans MS", 16, FontStyle.Regular);


    //Buttons
    private Button draw_btn = new Button();
    private Button erase_btn = new Button();
    private Button quit_btn = new Button();


    //helpers
    private bool graphicShow = false;
 

    //Locations
    private Point location_of_title = new Point(500, 0);

 
    private Point location_of_draw_button = new Point(950, 700);
    private Point location_of_erase_button = new Point(950, 750);
    private Point location_of_quit_button = new Point(950, 800);

    public void make_btn()
    {
        /* CUSTOMIZATION */

       
        //Action buttons
        draw_btn.Text = "Draw";
        draw_btn.Size = new Size(150, 50);
        draw_btn.Location = location_of_draw_button;
        draw_btn.Font = font_medium;
        draw_btn.BackColor = Color.FromArgb(54, 212, 74); //Green
        draw_btn.ForeColor = Color.White;

        erase_btn.Text = "Erase";
        erase_btn.Size = new Size(150, 50);
        erase_btn.Location = location_of_erase_button;
        erase_btn.Font = font_medium;
        erase_btn.BackColor = Color.FromArgb(7, 179, 222); //blue
        erase_btn.ForeColor = Color.White;

        quit_btn.Text = "Exit";
        quit_btn.Size = new Size(150, 50);
        quit_btn.Location = location_of_quit_button;
        quit_btn.Font = font_medium;
        quit_btn.BackColor = Color.FromArgb(252, 30, 13); //Red
        quit_btn.ForeColor = Color.White;


    }

    public trafficFrame()   //The constructor of this class
    {  //Set the title of this form.
        Text = "Draw circles";
        //Set the initial size of this form
        Size = new Size(formwidth, formheight);
        //Set the background color of this form
        BackColor = backgroundColor;


        title.Text = "Traffic Light by Van Ho";
        title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        title.BackColor = backgroundColor_2;
        title.Font = font_large;
        title.Size = new Size(700, 80);
        title.Location = location_of_title;
    
        make_btn();

       
        // display
        Controls.Add(title);
        Controls.Add(draw_btn);
        Controls.Add(erase_btn);
        Controls.Add(quit_btn);

        //  BUTTON HANGLERS DECLARATION
        draw_btn.Click += new EventHandler(Drawfunction);
        erase_btn.Click += new EventHandler(eraseCircles);
        quit_btn.Click += new EventHandler(exitfromthisprogram);


    }//End of constructor






    protected void Drawfunction(object sender, EventArgs param)
    {
        graphicShow = true;
        Invalidate();
    }



    protected void eraseCircles(Object sender, EventArgs events)
    {
        graphicShow = false;
        Invalidate();
    }

    protected void exitfromthisprogram(Object sender, EventArgs events)
    {
        System.Console.WriteLine("Program ended.");
        Close();
    }


    protected override void OnPaint(PaintEventArgs e)
    {

        Graphics graph = e.Graphics;
        SolidBrush myBrush2 = new SolidBrush(backgroundColor_2);

        graph.FillRectangle(myBrush2, 0, 675, 1600, 225);
        graph.FillRectangle(myBrush2, 0, 0, 1600, 80);

        //outline
        graph.DrawLine(outLine, 0, 675, 1600, 675);
        graph.DrawLine(outLine, 0, 80, 1600, 80);


        if (graphicShow)
        {
            graph.FillEllipse(myBrush, new Rectangle(725, 150, 150, 150));
            graph.FillEllipse(myBrush, new Rectangle(725, 325, 150, 150));
            graph.FillEllipse(myBrush, new Rectangle(725, 500, 150, 150));

            //outline
            graph.DrawEllipse(outLine, new Rectangle(725, 150, 150, 150));
            graph.DrawEllipse(outLine, new Rectangle(725, 325, 150, 150));
            graph.DrawEllipse(outLine, new Rectangle(725, 500, 150, 150));
        }
        base.OnPaint(e);
    }
}//End of class 
