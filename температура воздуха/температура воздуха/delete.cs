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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        static void deleteIndex (ref int[] array,int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index+1; i < array.Length; i++)
            {
                newArray[i-1] = array[i];
            }
            array = newArray;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.nums == null)
            {
                error newError = new error();
                newError.ShowDialog();
            }
            else
            { 
                 if (listBox1.Text == "номер")
                {
                    deleteIndex(ref Form1.nums, Convert.ToInt32(textBox1.Text)-1) ;
                }
            }

        }
    }
}
