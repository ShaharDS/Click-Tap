using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace circle_tap
{

    [Serializable]
    class ChangeLocations : Negative_Circle
    {
        protected int index;
        //public PictureBox image;
        


        public ChangeLocations
         (int x,
          int y, int index)
          : base(x, y)
        {
            this.index = index;
            this.image = new PictureBox();
            this.name = "negative";
           
        }

        public   void AllLocationChange()
        { 
                foreach(Dot X in Form1.MainList)
                 {
                  X.image.Visible = false;
    
                 }
            Form1.MainList.Clear();


        }
        public void DrawChangeLocations(Panel panel1, int i)
        {

            //this.image.Width = 40;
            this.image.Image = Properties.Resources.smile22; //<<<<<<

            //this.image.Image = Image.FromFile(@"Resources\smile2.png"); 
               
            this.image.Name = i.ToString();
            this.image.Width = 40;
            this.image.Height = 40;
            this.image.Location = new System.Drawing.Point(getX(), gety());
            this.image.Visible = true;
            this.image.MouseClick += ChangeLocation;

            panel1.Controls.Add(this.image);


            // formInstance.Controls.Remove(pic);
        }

        private void ChangeLocation(object sender, MouseEventArgs e)
        {
            //Negative_Circle n = sender as Negative_Circle; ;

            //  SortedList list = Form1.PC_list;

           this.badpoint();

      
            //Form1.PC_list.Remove(this.index);
            this.image.Visible = false;
            AllLocationChange();
            //  Form1.Controls.Remove(pic);
        }
    }
}
