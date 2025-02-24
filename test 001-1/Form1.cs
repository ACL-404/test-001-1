using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_001_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "what!";
            button2.Text = "what!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "一個bug是bug，但一群bug能work";
        }
    }
}
