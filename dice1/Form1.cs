using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void newGame()
        {
            score1 = 0;
            score2 = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            label1.Text = "player 1 scoure: ";
            label2.Text = "player 2 scoure: ";
            label3.Text = "player ";
            label3.Font = new Font("Arial", 8, FontStyle.Regular);
            label3.ForeColor = Color.Black;
            i = 0;
            j = 0;
            count = 0;
            pictureBox1.Image = myimages[0];
            pictureBox2.Image = myimages[0];




        }
        double scorse1 = 0, scorse2 = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        int[] rools = new int[7];

        private void button3_Click(object sender, EventArgs e)
        {

        }
        Image[] myimages = new Image[7]; 
        private void Form1_Load(object sender, EventArgs e)
        {
            myimages[0] = Properties.Resources._0;
            myimages[1] = Properties.Resources._1;
            myimages[2] = Properties.Resources._2;
            myimages[3] = Properties.Resources._3;
            myimages[4] = Properties.Resources._4;
            myimages[5] = Properties.Resources._5;
            myimages[6] = Properties.Resources._6;

        }
        int i = 0, j = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            j = rnd.Next(2);
            if(j==0)
        }

        Random rnd = new Random();
        private void timer1_tick(object sender, EventArgs e)
        {

        }

        

    }
}
