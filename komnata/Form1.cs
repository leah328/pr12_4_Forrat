using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace komnata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Komnata[] kom = new Komnata[10];


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = Convert.ToInt32(comboBox2.SelectedIndex); i < kom.Length; i++)
            {
                kom[i] = new Komnata();
                listBox1.Items.Add(kom[i].Ss((int)(numericUpDown1.Value), (int)(numericUpDown2.Value)));
                c++;
                if (c == 1) break;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            for (int i = 1; i <= 10; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = Convert.ToInt32(comboBox2.SelectedIndex); i < kom.Length; i++)
            {
                kom[i] = new Komnata();
                listBox1.Items.Add((kom[i].Info((int)(numericUpDown1.Value), (int)(numericUpDown2.Value), (int)(numericUpDown3.Value), (int)(numericUpDown4.Value), (int)(numericUpDown5.Value), (int)(numericUpDown6.Value))));
                c++;
                if (c == 1) break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = Convert.ToInt32(comboBox2.SelectedIndex); i < kom.Length; i++)
            {
                kom[i] = new Komnata();
                listBox1.Items.Add((kom[i].Vv((int)(numericUpDown1.Value), (int)(numericUpDown2.Value), (int)(numericUpDown3.Value))));
                c++;
                if (c == 1) break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = Convert.ToInt32(comboBox2.SelectedIndex); i < kom.Length; i++)
            {
                kom[i] = new Komnata();
                listBox1.Items.Add((kom[i].Rulon((int)(numericUpDown1.Value), (int)(numericUpDown2.Value), (int)(numericUpDown3.Value), (Convert.ToInt32(comboBox1.SelectedIndex)))));
                c++;
                if (c == 1) break;
            }
        }
    }
}
