using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Sorts : Form
    {
        private int N;
        private int ticks;
        private int[] tab;
        private int[] addTab;

        private Pen pen = new Pen(System.Drawing.Color.Red);

        private Pen pen2 = new Pen(System.Drawing.Color.Blue);
        private System.Random x = new Random();

        public Sorts()
        {
            InitializeComponent();
            this.N = this.Height;
            this.ticks = 0;
        }

        private void gener_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graph = this.CreateGraphics();

            for(int i=0; i< N; i++)
            {
                graph.DrawLine(pen, 0, addTab[i], tab[i], addTab[i]);
            }
        }

        private void Sorts_Load(object sender, EventArgs e)
        {
            
            tab = new int[N];
            addTab = new int[N];

            for(int i=0; i< N; i++)
            {
                addTab[i] = i;
                tab[i] = x.Next(1, 400);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            System.Drawing.Graphics graph = this.CreateGraphics();
            graph.DrawLine(pen2, 0, addTab[ticks], tab[ticks], addTab[ticks]);
            ticks++;

            this.btime.Text = ticks.ToString();

            if (this.ticks == this.N)
            {
                timer.Stop();
            }

        }

        private void sort_Click(object sender, EventArgs e)
        {
            if (this.buble.Checked){

                int temp1 = 0;
                int temp2 = 0;

                for(int i=0; i< N; i++)
                {
                    for(int j=0; j<N; j++)
                    {
                        if (tab[j] < tab[i])
                        {
                            temp1 = tab[i];
                            tab[i] = tab[j];
                            tab[j] = temp1;

                            temp2 = addTab[i];
                            addTab[i] = addTab[j];
                            addTab[j] = temp2;

                        }
                    }
                }
                timer.Enabled = true;
                timer.Start();

            }

        }
    }
}
