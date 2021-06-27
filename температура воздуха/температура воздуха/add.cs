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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        static void Insert (ref int[] array,int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i+1] = array[i];
            }
            array = newArray;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.nums==null)
            {
                error newError = new error();
                newError.ShowDialog();
            }
            else
            {
                if (listBox1.Text == "номер")
                {
                    Insert(ref Form1.nums, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text));
                }
                else
                {
                    if (listBox1.Text == "начало")
                    {
                        Insert(ref Form1.nums, Convert.ToInt32(textBox2.Text), 0);
                    }
                    else
                    {
                            Insert(ref Form1.nums, Convert.ToInt32(textBox2.Text), Form1.nums.Length);
                    }
                }
                
            }
        }
    }
}
