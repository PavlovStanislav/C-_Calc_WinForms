using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
    public partial class Form2 : Calculator.Calc
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        public bool ShowButton1
        {
            get
            {
                return button1.Visible;
            }
            set
            {
                button1.Visible = value;
            }
        }
        public bool ShowButton2
        {
            get
            {
                return button2.Visible;
            }
            set
            {
                button2.Visible = value;
            }
        }
        public bool ShowButton3
        {
            get
            {
                return button3.Visible;
            }
            set
            {
                button3.Visible = value;
            }
        }
        public bool ShowButton4
        {
            get
            {
                return button4.Visible;
            }
            set
            {
                button4.Visible = value;
            }
        }
    }
}


