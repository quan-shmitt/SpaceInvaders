using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        PictureBox invader = new PictureBox();
        PictureBox tank = new PictureBox();
        PictureBox bullet = new PictureBox();
        int invaderSpeed = 20;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            this.Width = 1080;
            this.Height = 700;
            invader.Image = Image.FromFile("invader.png");
            invader.Width = 50;
            invader.Height = 50;
            invader.Location = new Point(200, 100);
            invader.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(invader);

            tank.Image = Image.FromFile("tank.png");
            tank.Width = 50;
            tank.Height = 50;
            tank.Location = new Point(400, 400);
            tank.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(tank);
            timer1.Start();
            for(int i = 0; i < 10; i++)
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             if( e.KeyCode == Keys.A)
             {
                tank.Location = new Point(tank.Location.X - 4, tank.Location.Y);
             }
             if(e.KeyCode == Keys.D)
             {
                tank.Location = new Point(tank.Location.X + 4, tank.Location.Y);
             }
             if(e.KeyCode == Keys.Space)
             {

             }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            invader.Location = new Point(invader.Location.X + invaderSpeed, invader.Location.Y);

            if(invader.Location.X == this.Width)
            {
                invaderSpeed = -20;
            }
            else if(invader.Location.X == 0)
            {
                invaderSpeed = 20;
            }
        }

    }
}
