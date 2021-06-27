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
    public partial class answer2 : Form
    {
        public answer2()
        {
            InitializeComponent();
        }

        private void answer2_Load(object sender, EventArgs e)
        {
            int ans = 0;
            for (int i = 0; i < Form1.nums.Length-1; i++)
            {
                if (Form1.nums[i] < 0)
                {
                    int day1 = i;
                    int j = i+1;
                    if (i< Form1.nums.Length)
                    {
                        while (Form1.nums [j]>0)
                        {
                            j++;
                            if (j== Form1.nums.Length)
                            {
                                j = i;
                                break;
                            }
                        }
                        if ((j-i)>ans)
                        {
                            ans = j - i;
                        }
                    }
                }
            }
            if (ans == 0)
            {
                textBox1.Text = "дней с отрицательной температурой <2";
            }
            else
            {
                textBox1.Text = Convert.ToString(ans);
            }
        }
    }
}
