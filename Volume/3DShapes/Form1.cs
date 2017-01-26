using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Volume;



namespace _3DShapes
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parallelepiped Parallelepiped1 = new Parallelepiped();
            Parallelepiped1.a = int.Parse(textBox1.Text);
            Parallelepiped1.b = int.Parse(textBox9.Text);
            Parallelepiped1.c = int.Parse(textBox11.Text);
            textBox12.Text = Parallelepiped1.V().ToString();
            textBox13.Text = Parallelepiped1.Area().ToString();

            Elipsoid Elipsoid1 = new Elipsoid();
            Elipsoid1.a = int.Parse(textBox4.Text);
            Elipsoid1.b = int.Parse(textBox10.Text);
            Elipsoid1.c = int.Parse(textBox6.Text);
            textBox14.Text = Elipsoid1.V().ToString();
            textBox15.Text = Elipsoid1.Area().ToString();



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
