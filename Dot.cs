using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace circle_tap
{


    [Serializable]
    public abstract class Dot
    {

      protected int x;
      protected int y;
        protected string name;
        public PictureBox image;

        public string getname() { return name; }
       


        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


       public int getX()
        {
            return x;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public int gety()
        {
            return y;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        


    }
}
