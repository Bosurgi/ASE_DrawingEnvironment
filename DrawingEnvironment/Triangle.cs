﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingEnvironment
{
    /// <summary>
    /// The triangle class is inherited from the shape class.
    /// It has a length and 4 points from where lines will be drawn.
    /// </summary>
    internal class Triangle : Shape
    {
        private int lenght { get; set; }
        private Point A { get; set; }
        private Point B { get; set; }
        private Point C { get; set; }
        private Point D { get; set; }

        
        /// <summary>
        /// It draws the triangle into a graphic context.
        /// </summary>
        /// <param name="graphics">the graphic context we want to draw into</param>
        public override void Draw(Graphics graphics)
        {
            Point[] vertices = { A, B, C, D }; // Array of points where the lines are going to be
            // Checking if the shape needs to be filled in
            if (!isFill)
            {
                pen = new Pen(colour);
                graphics.DrawLines(pen, vertices); // drawing the lines using the method which takes a pen and an array of points.
                pen.Dispose();
            }
            // If fill flag is on it will fill the shape.
            else
            {
                brush = new SolidBrush(colour);
                graphics.FillPolygon(brush, vertices);
                brush.Dispose();
            }

        }

        /// <summary>
        /// Setter for a triangle. To be used to set X and Y in parameter list 0 - X and 1 - Y.
        /// And lenght of the triangle as parameter list 2.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="parametersList"></param>
        public override void Set(Color color, params int[] parametersList)
        {
            base.Set(color, parametersList[0], parametersList[1]);
            lenght = parametersList[2];
        }

        /// <summary>
        /// Constructor for the class Triangle.
        /// </summary>
        /// <param name="lenght">the length of the sides</param>
        /// <param name="pen">the pen used to draw</param>
        /// <param name="x">the X position of the shape on the canvas based on where the cursor is</param>
        /// <param name="y">the Y position of the shape on the canvas based on where the cursor is</param>
        public Triangle(int lenght, int x, int y) : base(x, y)
        {
            this.lenght = lenght;
            A = new Point(X, Y);
            B = new Point(X, Y + lenght);
            C = new Point(X + lenght, Y + lenght);
            D = new Point(X, Y);
        }
        
        /// <summary>
        /// Empty constructor for the Triangle class
        /// </summary>
        public Triangle() : base()
        {

        }
    }
}
