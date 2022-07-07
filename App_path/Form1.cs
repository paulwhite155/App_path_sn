using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_path
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Application.StartupPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fn;
            fn = Application.StartupPath + "\\calc.exe";
            this.process1.StartInfo.FileName = fn;
         
            if (System.IO.File.Exists(fn) == true)
            {
                this.process1.Start();
            }
            else
            {
                MessageBox.Show("i cant find");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fn;
            fn = Application.StartupPath + "\\data\\pro" + "\\calc.exe";
            this.process1.StartInfo.FileName = fn;
            if (System.IO.File.Exists (fn) == true)
            {
                this.process1.Start();
            }
            else
            {
                MessageBox.Show("i cant find.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fn;
            fn = Application.StartupPath + "\\data\\pictures\\otto+me.JPG";
            this.pictureBox1.Image=Image.FromFile(fn);

            //if (System.IO.File.Exists(fn) == true)
            //{
            //    this.pictureBox1.Image = Image.FromFile(fn);
            //}
            //else
            //{
            //    MessageBox.Show("i cant find that picture.");
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
