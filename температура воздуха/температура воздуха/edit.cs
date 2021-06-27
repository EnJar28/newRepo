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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "номер")
            {
                Form1.nums[Convert.ToInt32(textBox1.Text)-1] = Convert.ToInt32(textBox2.Text);
            }
        }
    }
}
