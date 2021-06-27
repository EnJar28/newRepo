using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace температура_воздуха
{
    public partial class answer1 : Form
    {
        public answer1()
        {
            InitializeComponent();
        }

        private void answer1_Load(object sender, EventArgs e)
        {
            if (Form1.nums == null)
            {
                error err = new error();
                err.ShowDialog();
            }
            else
            { 
                float sum = 0;
                for (int i = 0; i < Form1.nums.Length; i++)
                {
                    sum = sum + Form1.nums[i];
                }
                sum = sum / Form1.nums.Length;
                for (int i = 0; i < Form1.nums.Length; i++)
                {
                    if (Form1.nums [i]>sum)
                    {
                        textBox1.Text = textBox1.Text + "("+(i+1) + " "+":"+ Form1.nums[i]+")";
                    }
                }
            }
        }
    }
}
