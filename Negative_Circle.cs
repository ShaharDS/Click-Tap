using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;




namespace circle_tap
{

    [Serializable]
    abstract class Negative_Circle : Dot
    {
        protected int points;
        //private int index;
     //  public PictureBox image;

        public Negative_Circle
         (int x,
          int y)
          : base(x, y)
        {
            this.points = -15;
         //   this.index = index;
      //      this.image = new PictureBox();
        }







        //public void Draw_NC(Form form1, int i)
        //{

        //    //this.image.Width = 40;
        //    this.image.Image = Properties.Resources.crying_smile; //<<<<<<

        //    //this.image.Image = Image.FromFile(@"Resources\smile2.png"); 

        //    this.image.Name = i.ToString();
        //    this.image.Width = 40;
        //    this.image.Height = 40;
        //    this.image.Location = new System.Drawing.Point(getX(), gety());
        //    this.image.Visible = true;
        //    this.image.MouseClick += Pic_MouseClick;
        //    form1.Controls.Add(this.image);


        //    // formInstance.Controls.Remove(pic);

        //}

        public void badpoint()
        {

            //  SortedList list = Form1.PC_list;

            Form1.points = Form1.points + this.points;
            Form1.score.Text = "Score: " + (Form1.points);

            //  Form1.Controls.Remove(pic);


            }




    }
}
