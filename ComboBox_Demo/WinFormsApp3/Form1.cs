//Program for combobox control

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create graphics object and pen
            Graphics g = base.CreateGraphics();
            Pen mypen = new Pen(Color.Blue);
            g.Clear(Color.White);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    g.DrawEllipse(mypen, 50, 50, 150, 150);
                    break;
                case 1:
                    g.DrawEllipse(mypen, 50, 75, 120, 150);
                    break;
                case 2:
                    g.DrawRectangle(mypen, 50, 50, 150, 150);
                    break;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Circle");
            comboBox1.Items.Add("Ellipse");
            comboBox1.Items.Add("Square");
        }
    }
}