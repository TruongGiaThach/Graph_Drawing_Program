﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Presentation_Layers
{
    public partial class Time_Control : Control
    {
        public Time_Control()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.AutoSize = true;
            label1.Text = DateTime.Now.ToString("d/M/yyyy HH:mm:ss tt");
        }
    }
}
