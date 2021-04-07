using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_C_Sharp_Ch12
{
    abstract class Shapes
    {

        //Fields

        private string color = "";


        //Constructors


        public Shapes()
        {
            color = "";
        }


        //Methods
        public void SetColor(string color)
        {
            this.color = color;
        }

        
            public abstract double GetArea();
        
       
            public abstract double GetPerimeter();
        

        public string GetColor()
        {
            return color;
        }

        
    }
}
