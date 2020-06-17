using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ControlBox = false;
            this.DOHM = new System.Windows.Forms.LinkLabel(); this.DOHM.AutoSize = true; this.DOHM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DOHM_LinkClicked);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (Double i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double bt, at, rt;
            bt = Convert.ToDouble(comboBox1.Text);
            at = Convert.ToDouble(comboBox2.Text);
            rt = ((bt * at) / 2);
            rt = Math.Round((rt), 2);
            MessageBox.Show("Área del Triangulo: " + rt.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double l, rc;
            l = Convert.ToDouble(comboBox3.Text);
            rc = (l*l);
            rc = Math.Round((rc), 2);
            MessageBox.Show("Área del Cuadrado: " + rc.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DOHM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DOHM.LinkVisited = true;
            System.Diagnostics.Process.Start("https://t.me/imdohm");
        }
    }
}
