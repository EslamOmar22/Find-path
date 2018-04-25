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
    public partial class start_up_form : Form
    {
        public start_up_form()
        {
            InitializeComponent();
        }

        private void start_up_form_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            Visible = false;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            Visible = false;
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
