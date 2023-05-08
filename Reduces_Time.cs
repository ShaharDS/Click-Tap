using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace circle_tap
{

    [Serializable]
    class Reduces_Time : Negative_Circle
    {
        private int timereduce;
        private int index;
        public Reduces_Time
        (int x,
          int y, int index)
          : base(x, y)
        {
            this.index = index;
            this.image = new PictureBox();
            this.name = "timer-reduce";
            Random rnd = new Random();
            this.timereduce = rnd.Next(5, 10);

        }


        public void DrawReduceTime(Panel panel1, int i)
        {

            //this.image.Width = 40;
            this.image.Image = Properties.Resources.smile21; //<<<<<<

            //this.image.Image = Image.FromFile(@"Resources\smile2.png"); 

            this.image.Name = i.ToString();
            this.image.Width = 40;
            this.image.Height = 40;
            this.image.Location = new System.Drawing.Point(getX(), gety());
            this.image.Visible = true;
            this.image.MouseClick += ReduceTime;

            panel1.Controls.Add(this.image);
        }

        private void ReduceTime(object sender, MouseEventArgs e)
        {
            Form1.MainList.Remove(this);
            Form1.Tick += this.timereduce;;
            this.image.Visible = false;
            this.badpoint();
        }
    }
}
