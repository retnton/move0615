using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyu0608
{
    public partial class Form1 : Form
    {
        Point cpos;        
        private static Random rand = new Random();
        int[] vx = new int[10];
        int[] vy = new int[10];
       // int vx1, vy1;     
        //int vx2, vy2;
        //int vx3, vy3;

        Label[] labels = new Label[10];
        public Form1()
        {
            cpos = MousePosition;
            cpos = PointToClient(cpos);
            InitializeComponent();
                        for (int i = 0; i < 10; i++)
            {
              
                           
            
               labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "◇";
                Controls.Add(labels[i]);
                labels[i].Font = labels[i].Font;
                labels[i].ForeColor = labels[i].ForeColor;
                vx[i] = rand.Next(1,10);
                vy[i] = rand.Next(1,10);
            }
        }

        private void timer1_Tick(object sender, EventArgs e){
             
            // 1           
            for (int i = 0; i < 10; i++)
            {


                labels[i].Left += vx[i];
                labels[i].Top += vy[i];


                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (labels[i].Left > ClientSize.Width - labels[i].Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top > ClientSize.Height - labels[i].Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }

        }

    }

}

