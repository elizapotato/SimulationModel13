using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_9
{
    public partial class Form1 : Form
    {
        const int countX = 5;
        const double chiVal = 9.488;
        double P0;
        double[] p = new double[countX];

        public Form1()
        {
            InitializeComponent();            
            chart1.Legends.Clear();
            labAverage.Text = labVariance.Text = labChi.Text = labChiBool.Text = "";
        }               

        private void startB_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            P0 = (double)P0box.Value;

            double sum = 0;
            for (int i = 0; i < countX; i++)
            {
                p[i] = (P0 * Math.Pow((1 - P0), i));
                sum += p[i];
            }

            p[countX - 1] = 1 - sum;
            Random random = new Random();

            int N = (int)NExp.Value;
            double[] n = new double[countX];

            for (int i = 0; i < N; i++)
            {
                int x = (int)(Math.Log(random.NextDouble()) / Math.Log(1 - P0));
                if (x > countX - 1)
                {
                    n[countX - 1]++;
                }
                else
                    n[x]++;
            }


            for (int i = 0; i < countX; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, (float)n[i] / N);
            }

            double Ex = 0, Dx = 0, emEx = 0, emDx = 0, Chi = 0;
            for (int i = 0; i < countX; i++)
            {
                Ex += p[i] * (i + 1);
                emEx += (n[i] / N) * (i + 1);
                Dx += p[i] * (i + 1) * (i + 1);
                emDx += (n[i] / N) * (i + 1) * (i + 1);
                Chi += (n[i] * n[i]) / (N * p[i]);
            }
            Dx -= Ex * Ex;
            emDx -= emEx * emEx;
            Chi -= N;
            double eError = Math.Abs(emEx - Ex) / Math.Abs(Ex);
            double dError = Math.Abs(emDx - Dx) / Math.Abs(Dx);

            labAverage.Text = "Average: "+Math.Round(emEx,3)+" (error = "+Math.Round(eError*100)+"%)";
            labVariance.Text = "Variance: " + Math.Round(emDx, 3) + " (error = " + Math.Round(dError * 100) + "%)";
            labChi.Text = "Chi-squared: "+ Math.Round(Chi,3)+" > 9.488 ";
            if (Chi >= 9.488)
            {
                labChiBool.Text = "True";
                labChiBool.ForeColor = Color.Green;
            }
            else
            {
                labChiBool.Text = "False";
                labChiBool.ForeColor = Color.Red;
            }

        }
    }
}
