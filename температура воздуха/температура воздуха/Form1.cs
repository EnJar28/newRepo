using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace температура_воздуха
{
    public partial class Form1 : Form
    {
        public static int[] nums;
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openfile.FileName);
            }
            if (richTextBox1.Text.Length == 0)
            {
                error newError = new error();
                newError.ShowDialog();
            }
            else
            {
               nums = richTextBox1.Text.Split(' ').Select(int.Parse).ToArray();//???
            }
        }

        public void удалениеОбъектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete del = new delete();
            del.ShowDialog();
        }

        public void добавлениеОбъектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.ShowDialog();
        }

        public void редактированиеОбъектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit edit = new edit();
            edit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            for (int i = 0; i < nums.Length; i++)
            {
                richTextBox1.Text = richTextBox1.Text + Convert.ToString(nums[i]) + ' ';
            }
        }

        private void теплыеДниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            answer1 answer = new answer1();
            answer.ShowDialog();
        }

        private void периодОтрицательнойТемпературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            answer2 answer = new answer2();
            answer.ShowDialog();
        }
    }
}
