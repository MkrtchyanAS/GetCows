﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


                int n = 0;
                if (int.TryParse(textBox1.Text, out n))
                {
                    Class1 obj = new Class1();
                    label1.Text = obj.GetCows(n);
                }
                else
                {
                    label1.Text = string.Empty;
                }
            

        }
    }
}