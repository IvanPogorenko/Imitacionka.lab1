using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;
        double dt;
        double height, angle, speed, S, m;
        double cosa, sina, beta, k;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        double yMax;


        double x, y, t, vx, vy;

        private void btStart_Click(object sender, EventArgs e)
        {
            height = (double)edHeight.Value;
            angle = (double)edAngle.Value;
            speed = (double)edSpeed.Value;
            dt = (double)edStep.Value;
            S = (double)edSize.Value;
            m = (double)edWeight.Value;

            cosa = Math.Cos(angle*Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);

            beta = 0.5 * C * rho * S;
            k = beta / m;

            t = 0;
            x = 0;
            y = height;
            yMax = y;
            vx = speed * cosa;
            vy = speed * sina;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double vx_old = vx;
            double vy_old = vy;
            double root = Math.Sqrt(vx * vx + vy * vy);
            t = t + dt;
            vx = vx_old-k*vx_old*root*dt;
            vy = vy_old - (g + k * vy_old * root) * dt;

            x = x+vx*dt;
            y = y+vy*dt;

            if(y > yMax)
            {
                yMax = y;
            }
            chart1.Series[0].Points.AddXY(x, y);

            if(y<=0)
            {
                dataGridView1.Rows.Add(dt, x, yMax, Math.Abs(vy));
                timer1.Stop();
            }
        }
    }
}
