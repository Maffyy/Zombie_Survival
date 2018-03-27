using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Survival._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 game = new Form1();
            game.ShowDialog();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            button1.Visible = false;
            button2.Visible = false;
            Exit.Visible = false;
            label1.Visible = false;
            button3.Visible = true;
            popis.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            Exit.Visible = true;
            label1.Visible = true;
            button3.Visible = false;
            popis.Visible = false;
        }
    }
}
