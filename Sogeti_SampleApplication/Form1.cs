﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sogeti_SampleApplication
{
    public partial class Form1 : Form
    {
        private int clicks;

        public Form1()
        {
            InitializeComponent();
            clicks = 0;
            label2.Text = clicks.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button Click Successful");
            clicks += 1;
            label2.Text = clicks.ToString();
        }
    }
}
