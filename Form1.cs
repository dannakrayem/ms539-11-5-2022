using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_103122
{
    public partial class Form1 : Form
    { int number1;
        Image dog, cat, snake;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I like C#");
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("i hate cats too");
            cat = Image.FromFile("cat.jpg");
            pictureBox1.Image = cat;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("i hate snakes too");
            snake = Image.FromFile("snake.jpg");
            pictureBox1.Image = snake;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out number1))
            { MessageBox.Show("integer is ok"); 
            }   
            else
            {
                MessageBox.Show("invalid int");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("i hate dogs too");
            dog = Image.FromFile("dog.jpg");
            pictureBox1.Image = dog;
        }
    }
}
