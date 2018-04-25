using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OOP.Project
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            pictureBox1.Image = Properties.Resources.roll;
            pictureBox2.Image = Properties.Resources.start;
            pictureBox3.Image = Properties.Resources._long;
            pictureBox4.Image = Properties.Resources.roll;
            pictureBox5.Image = Properties.Resources._long;
            pictureBox6.Image = Properties.Resources.start_ta7t;
            pictureBox7.Image = Properties.Resources.roll;
            pictureBox8.Image = Properties.Resources.left_up_curv;
            pictureBox9.Image = Properties.Resources.roll;
            pictureBox10.Image = Properties.Resources._long;
            pictureBox11.Image = Properties.Resources.sapce;
            pictureBox12.Image = Properties.Resources.right_down_cur;
            pictureBox13.Image = Properties.Resources.roll;
            pictureBox14.Image = Properties.Resources.right_up_curv;
            pictureBox15.Image = Properties.Resources.left_down_curv;
            pictureBox16.Image = Properties.Resources.goal;
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.Gray)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Peru;
                pictureBox1.Image = Properties.Resources.sapce;
                pictureBox1.BackColor = Color.Gray;
            }

            if (pictureBox5.BackColor == Color.Gray)
            {
                pictureBox5.Image = pictureBox1.Image;
                pictureBox5.BackColor = Color.Peru;
                pictureBox1.Image = Properties.Resources.sapce;
                pictureBox1.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox11.BackColor == Color.Gray)
            {
                pictureBox11.Image = pictureBox10.Image;
                pictureBox11.BackColor = Color.Peru;
                pictureBox10.Image = Properties.Resources.sapce;
                pictureBox10.BackColor = Color.Gray;
            }

            else if (pictureBox9.BackColor == Color.Gray)
            {
                pictureBox9.Image = pictureBox10.Image;
                pictureBox9.BackColor = Color.Peru;
                pictureBox10.Image = Properties.Resources.sapce;
                pictureBox10.BackColor = Color.Gray;
            }

            else if (pictureBox14.BackColor == Color.Gray)
            {
                pictureBox14.Image = pictureBox10.Image;
                pictureBox14.BackColor = Color.Peru;
                pictureBox10.Image = Properties.Resources.sapce;
                pictureBox10.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (pictureBox4.BackColor == Color.Gray)
            {
                pictureBox4.Image = pictureBox3.Image;
                pictureBox4.BackColor = Color.Peru;
                pictureBox3.Image = Properties.Resources.sapce;
                pictureBox3.BackColor = Color.Gray;
            }

            if (pictureBox2.BackColor == Color.Gray)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox2.BackColor = Color.Peru;
                pictureBox1.Image = Properties.Resources.sapce;
                pictureBox1.BackColor = Color.Gray;
            }

            if (pictureBox7.BackColor == Color.Gray)
            {
                pictureBox7.Image = pictureBox3.Image;
                pictureBox7.BackColor = Color.Peru;
                pictureBox3.Image = Properties.Resources.sapce;
                pictureBox3.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (pictureBox8.BackColor == Color.Gray)
            {
                pictureBox8.Image = pictureBox4.Image;
                pictureBox8.BackColor = Color.Peru;
                pictureBox4.Image = Properties.Resources.sapce;
                pictureBox4.BackColor = Color.Gray;
            }

            if (pictureBox3.BackColor == Color.Gray)
            {
                pictureBox3.Image = pictureBox4.Image;
                pictureBox3.BackColor = Color.Peru;
                pictureBox4.Image = Properties.Resources.sapce;
                pictureBox4.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (pictureBox1.BackColor == Color.Gray)
            {
                pictureBox1.Image = pictureBox5.Image;
                pictureBox1.BackColor = Color.Peru;
                pictureBox5.Image = Properties.Resources.sapce;
                pictureBox5.BackColor = Color.Gray;
            }

            if (pictureBox9.BackColor == Color.Gray)
            {
                pictureBox9.Image = pictureBox5.Image;
                pictureBox9.BackColor = Color.Peru;
                pictureBox5.Image = Properties.Resources.sapce;
                pictureBox5.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (pictureBox8.BackColor == Color.Gray)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox8.BackColor = Color.Peru;
                pictureBox7.Image = Properties.Resources.sapce;
                pictureBox7.BackColor = Color.Gray;

            }

            if (pictureBox11.BackColor == Color.Gray)
            {
                pictureBox11.Image = pictureBox7.Image;
                pictureBox11.BackColor = Color.Peru;
                pictureBox7.Image = Properties.Resources.sapce;
                pictureBox7.BackColor = Color.Gray;
            }

            if (pictureBox3.BackColor == Color.Gray)
            {
                pictureBox3.Image = pictureBox7.Image;
                pictureBox3.BackColor = Color.Peru;
                pictureBox7.Image = Properties.Resources.sapce;
                pictureBox7.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (pictureBox4.BackColor == Color.Gray)
            {
                pictureBox4.Image = pictureBox8.Image;
                pictureBox4.BackColor = Color.Peru;
                pictureBox8.Image = Properties.Resources.sapce;
                pictureBox8.BackColor = Color.Gray;
            }

            if (pictureBox7.BackColor == Color.Gray)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox7.BackColor = Color.Peru;
                pictureBox8.Image = Properties.Resources.sapce;
                pictureBox8.BackColor = Color.Gray;
            }

            if (pictureBox12.BackColor == Color.Gray)
            {
                pictureBox12.Image = pictureBox8.Image;
                pictureBox12.BackColor = Color.Peru;
                pictureBox8.Image = Properties.Resources.sapce;
                pictureBox8.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (pictureBox5.BackColor == Color.Gray)
            {
                pictureBox5.Image = pictureBox9.Image;
                pictureBox5.BackColor = Color.Peru;
                pictureBox9.Image = Properties.Resources.sapce;
                pictureBox9.BackColor = Color.Gray;
            }

            if (pictureBox10.BackColor == Color.Gray)
            {
                pictureBox10.Image = pictureBox9.Image;
                pictureBox10.BackColor = Color.Peru;
                pictureBox9.Image = Properties.Resources.sapce;
                pictureBox9.BackColor = Color.Gray;
            }

            if (pictureBox13.BackColor == Color.Gray)
            {
                pictureBox13.Image = pictureBox9.Image;
                pictureBox13.BackColor = Color.Peru;
                pictureBox9.Image = Properties.Resources.sapce;
                pictureBox9.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            if (pictureBox8.BackColor == Color.Gray)
            {
                pictureBox8.Image = pictureBox12.Image;
                pictureBox8.BackColor = Color.Peru;
                pictureBox12.Image = Properties.Resources.sapce;
                pictureBox12.BackColor = Color.Gray;
            }

            if (pictureBox11.BackColor == Color.Gray)
            {
                pictureBox11.Image = pictureBox12.Image;
                pictureBox11.BackColor = Color.Peru;
                pictureBox12.Image = Properties.Resources.sapce;
                pictureBox12.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            if (pictureBox14.BackColor == Color.Gray)
            {
                pictureBox14.Image = pictureBox13.Image;
                pictureBox14.BackColor = Color.Peru;
                pictureBox13.Image = Properties.Resources.sapce;
                pictureBox13.BackColor = Color.Gray;
            }

            if (pictureBox9.BackColor == Color.Gray)
            {
                pictureBox9.Image = pictureBox13.Image;
                pictureBox9.BackColor = Color.Peru;
                pictureBox13.Image = Properties.Resources.sapce;
                pictureBox13.BackColor = Color.Gray;

            }
            check_win();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            if (pictureBox15.BackColor == Color.Gray)
            {
                pictureBox15.Image = pictureBox14.Image;
                pictureBox15.BackColor = Color.Peru;
                pictureBox14.Image = Properties.Resources.sapce;
                pictureBox14.BackColor = Color.Gray;
            }

            if (pictureBox13.BackColor == Color.Gray)
            {
                pictureBox13.Image = pictureBox14.Image;
                pictureBox13.BackColor = Color.Peru;
                pictureBox14.Image = Properties.Resources.sapce;
                pictureBox14.BackColor = Color.Gray;
            }

            if (pictureBox10.BackColor == Color.Gray)
            {
                pictureBox10.Image = pictureBox14.Image;
                pictureBox10.BackColor = Color.Peru;
                pictureBox14.Image = Properties.Resources.sapce;
                pictureBox14.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

            if (pictureBox14.BackColor == Color.Gray)
            {
                pictureBox14.Image = pictureBox15.Image;
                pictureBox14.BackColor = Color.Peru;
                pictureBox15.Image = Properties.Resources.sapce;
                pictureBox15.BackColor = Color.Gray;
            }

            if (pictureBox11.BackColor == Color.Gray)
            {
                pictureBox11.Image = pictureBox15.Image;
                pictureBox11.BackColor = Color.Peru;
                pictureBox15.Image = Properties.Resources.sapce;
                pictureBox15.BackColor = Color.Gray;
            }
            check_win();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            if (pictureBox10.BackColor == Color.Gray)
            {
                pictureBox10.Image = pictureBox11.Image;
                pictureBox10.BackColor = Color.Peru;
                pictureBox11.Image = Properties.Resources.sapce;
                pictureBox11.BackColor = Color.Gray;
            }

            if (pictureBox7.BackColor == Color.Gray)
            {
                pictureBox7.Image = pictureBox11.Image;
                pictureBox7.BackColor = Color.Peru;
                pictureBox11.Image = Properties.Resources.sapce;
                pictureBox11.BackColor = Color.Gray;
            }
            if (pictureBox15.BackColor == Color.Gray)
            {
                pictureBox15.Image = pictureBox11.Image;
                pictureBox15.BackColor = Color.Peru;
                pictureBox11.Image = Properties.Resources.sapce;
                pictureBox11.BackColor = Color.Gray;
            }

            if (pictureBox12.BackColor == Color.Gray)
            {
                pictureBox12.Image = pictureBox11.Image;
                pictureBox12.BackColor = Color.Peru;
                pictureBox11.Image = Properties.Resources.sapce;
                pictureBox11.BackColor = Color.Gray;
            }

            check_win();
        }

        int durarion = 30;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            durarion--;
            textBox1.Text = durarion.ToString();
            if (durarion == 0)
            {
                timer1.Stop();
                MessageBox.Show("TIME IS UP ! \n Hard luck next time ");

                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void check_win()
        {
            if ((pictureBox7.Image == Properties.Resources.left_up_curv) && (pictureBox11.Image == Properties.Resources._long) && (pictureBox15.Image == Properties.Resources.left_down_curv))
            {
                timer1.Stop();
                MessageBox.Show("Congratulations you passed this Level ");
            }

        }

    }
}
