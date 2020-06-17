using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ControlBox = false;
            this.Classroom = new System.Windows.Forms.LinkLabel(); this.Classroom.AutoSize = true; this.Classroom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Classroom_LinkClicked);
            this.IMG1 = new System.Windows.Forms.LinkLabel(); this.IMG1.AutoSize = true; this.IMG1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IMG1_LinkClicked);
            this.IMG2 = new System.Windows.Forms.LinkLabel(); this.IMG2.AutoSize = true; this.IMG2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IMG2_LinkClicked);
            this.IMG3 = new System.Windows.Forms.LinkLabel(); this.IMG3.AutoSize = true; this.IMG3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IMG3_LinkClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            Double n1, n2;
            Double R;
            n1 = Convert.ToDouble(Num1.Text); n2 = Convert.ToDouble(Num2.Text);
            R = n1 + n2 ;
            MessageBox.Show("El resultado de la suma es: " + R);
            Num1.Text = ""; Num2.Text = "";;
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Double n1, n2;
            Double R;
            n1 = Convert.ToDouble(Num1.Text); n2 = Convert.ToDouble (Num2.Text);
            R = (n1 * n2);
            MessageBox.Show("El resultado de la suma es: " + R);
            Num1.Text = ""; Num2.Text = "";
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            Double n1, n2;
            Double R;
            n1 = Convert.ToDouble(Num1.Text); n2 = Convert.ToDouble(Num2.Text);
            R = n1 - n2 ;
            MessageBox.Show("El resultado de la suma es: " + R);
            Num1.Text = ""; Num2.Text = "";;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Double n1, n2;
            Double R;
            n1 = Convert.ToDouble(Num1.Text); n2 = Convert.ToDouble(Num2.Text);
            R = n1 / n2;
            MessageBox.Show("El resultado de la suma es: " + R);
            Num1.Text = ""; Num2.Text = "";;
        }

        private void Classroom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Classroom.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.classroom.google.com");
        }

        private void IMG1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Classroom.LinkVisited = true;
            System.Diagnostics.Process.Start("https://imgur.com/a/NoEDYkd");
        }

        private void IMG2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Classroom.LinkVisited = true;
            System.Diagnostics.Process.Start("https://imgur.com/a/4XotFCw");
        }

        private void IMG3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Classroom.LinkVisited = true;
            System.Diagnostics.Process.Start("https://imgur.com/a/cINyoat");
        }
    }
}
