using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;



namespace circle_tap
{

    [Serializable]
      class Positive_Circle : Dot 
    {
         private  int points;
        private int index;
       // public PictureBox image;
            

        public Positive_Circle
           ( int x,
            int y,int index)
            : base(x, y)
        {
            this.points = 5;
            this.index = index;
            this.image = new PictureBox();
            this.name = "positive";

        }


        public void Draw_PC(Panel panel1, int i)
        {

            //this.image.Width = 40;
               this.image.Image = Properties.Resources.smile2; //<<<<<<
              
            //this.image.Image = Image.FromFile(@"Resources\smile2.png"); 

            this.image.Name = "positive";
            this.image.Width = 40;
            this.image.Height = 40;
            this.image.Location = new System.Drawing.Point(getX(), gety());
            this.image.Visible = true;
            this.image.MouseClick += Pic_MouseClick;
            panel1.Controls.Add(this.image);


            // formInstance.Controls.Remove(pic);

        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
        
          //  SortedList list = Form1.PC_list;

            Form1.points = Form1.points + this.points;
            Form1.score.Text = "Score: " + (Form1.points);
            Form1.MainList.Remove(this);
            this.image.Visible = false;
            
            //  Form1.Controls.Remove(pic);



        }
    }
}
