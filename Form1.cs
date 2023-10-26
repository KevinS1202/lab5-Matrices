using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double[] nums = new double[10];
            nums[0] = Convert.ToDouble(textBox1.Text);
            nums[1] = Convert.ToDouble(textBox2.Text);
            nums[2] = Convert.ToDouble(textBox3.Text);
            nums[3] = Convert.ToDouble(textBox4.Text);
            nums[4] = Convert.ToDouble(textBox5.Text);
            nums[5] = Convert.ToDouble(textBox6.Text);
            nums[6] = Convert.ToDouble(textBox7.Text);
            nums[7] = Convert.ToDouble(textBox8.Text);
            nums[8] = Convert.ToDouble(textBox9.Text);
            nums[9] = Convert.ToDouble(textBox10.Text);

            double min = nums [0];
            double max = nums [0];
            int x = 0;
            int y = 0;
            int k ;

            for (int i = 1; i < 10; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i]; x = i;
                }
                if (max < nums[i])
                {
                    max = nums[i]; y = i;
                }
                if (max == 3.5 || min == 3.5)
                {
                    k = y;
                    nums[y] = nums[x];
                    nums[x] = k;
                }
                else MessageBox.Show("Error");
            }

            textBox11.Text = Convert.ToString (min);
            textBox12.Text = Convert.ToString (max);
        }
    }
}
