using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentLibrary
{
    public partial class GameTimer: UserControl
    {
        int sec;
        int min;

        public GameTimer()
        {
            InitializeComponent();
        }

        public override string Text => display.Text;

        public void Start()

        {
            sec = 0;
            min = 0;
            timer.Enabled = true;
            display.Text = ("00:00");
            timer.Start();            
        }

        public void Stop()

        {
            timer.Stop();
            timer.Enabled = false;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0; min++; display.Text = ($"0{min}:0{sec}");
            }

            if (min < 10) display.Text = ($"0{min}:");
            else display.Text = ($"{min}:");

            if (sec < 10) display.Text += ($"0{sec}");
            else display.Text += ($"{sec}");
        }

    }
}
