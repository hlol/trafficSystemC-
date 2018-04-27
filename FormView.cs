using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObjectMoving
{
    public partial class FormView : Form
    {
       

        private int _x, _x1, _x2, _x3, _x4;
        private int _y, _y1, _y2, _y3, _y4;

        private void timer2_Tick(object sender, EventArgs e)
        {
            product2();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            product4();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            product3();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           product1();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            green1.Visible = false;
            red1.Visible = true;
            yellow1.Visible = false;
            timer1.Enabled = true;
            
          
        }

        private void green1_Click(object sender, EventArgs e)
        {

        }

        private void red2_Click(object sender, EventArgs e)
        {

        }

        private Bitmap b1;
       
       
        public FormView()
        {
            InitializeComponent();

            _x = 200;
            _y = 10;        
            _x2 = 50;
            _y2 = 150;
            _x3 = 900;
            _y3 = 550;
            _x4 = 1200;
            _y4 = 150;

        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            
            Bitmap b1 = new Bitmap("car1.png");
            
             e.Graphics.DrawImage(b1, _x, _y, 40, 64);
           
            e.Graphics.DrawImage(new Bitmap("bus.png"), _x2, _y2, 100, 64);
            e.Graphics.DrawImage(new Bitmap("car3.png"), _x3, _y3, 64, 64);
            e.Graphics.DrawImage(new Bitmap("emergency.png"), _x4, _y4, 128, 64);
          

        }

        
      

      
        private  void product1()
        {
            if ((_x2 !=750 && _y2 == 150))
                _x2 += 5;
            else
            {
                _y2 += 5;
                if (_y2 == 700)
                timer1.Enabled = false;
                green1.Visible = true;
                red1.Visible = false;
                yellow1.Visible = false;
                green2.Visible = false;
                red2.Visible = true;
                yellow2.Visible = false;
                timer2.Enabled = true;
            }



            Invalidate();

        }
        private void product2()
        {
            if ((_x == 550 && _y == 150))
                _x += 5;
            else
            {
                _y += 5;
                if (_y == 550)
                green1.Visible = true;
                red1.Visible = false;
                yellow1.Visible = false;
               
                timer2.Enabled = false;
                timer3.Enabled = true;
            }



            Invalidate();

        }
        private void product3()
        {
           // if ((_x3 != 150 && _y3 == 550))
                _x3 -= 5;
            // else if ((_x3 == 200 && _y3 == 550))
            //  boom.Visible = true;
            if (_x3 == 200 && _y3 == 550)
            {
                timer3.Enabled = false;
                boomBox.Visible = true;
                timer4.Enabled = true;
            }

            Invalidate();

        }

        private void product4()
        {
            if ((_x4 != 200 && _y4 == 150))
                _x4 -= 5;
            else
            {
                _y4 += 5;
                if (_y4 == 450)
                    timer4.Enabled = false;
                   // timer3.Enabled = true;
            }



            Invalidate();

        }
        private void FormView_Load(object sender, EventArgs e)
        {
            this.Size= new Size(1150,732);
          
        }
    }
}
