﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AseProgramingLanguage1
{
    class Turtle
    {
        public string Fill { get; }
        public int X { get; }
        public int Y { get; }

        public Turtle(string fill)
        {
            //Fill.Equals(fill);
            this.Fill=fill ;
            
        }
        public Turtle(int x,int y)
        {
            this.X = x;
            this.Y = y;

        }
    }
}
