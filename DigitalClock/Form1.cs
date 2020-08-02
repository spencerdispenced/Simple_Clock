using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        Timer T = new Timer();  // Create timer object

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T.Interval = 1000;  // updates at every 1000ms, or every second
            T.Tick += new EventHandler(UpdateLabels); // do this every update
            T.Start(); // start the timer object running
        }

        private void UpdateLabels(object sender, EventArgs args)
        {
            labelClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        
    }
}
