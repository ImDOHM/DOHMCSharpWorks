using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            for (Double i = 1; i <= 100; i++)
            {
                cmar.Items.Add(i);
                cserr.Items.Add(i);
                cau.Items.Add(i);
                cla.Items.Add(i);
            }

        }


        public void checkBox1_CheckedChanged(object sender, EventArgs e){cmar.Enabled = true;} private void checkBox2_CheckedChanged(object sender, EventArgs e){cserr.Enabled = true;} private void checkBox3_CheckedChanged(object sender, EventArgs e) {cau.Enabled = true;} private void checkBox4_CheckedChanged(object sender, EventArgs e) {cla.Enabled = true;}


        private void cmar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double PM = 75, CM, STM;
            CM = Convert.ToDouble(cmar.Text);
            STM = PM * CM;
            textBox1.Text = STM.ToString();
        }

        private void cserr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double PS = 120, CS, STS;
            CS = Convert.ToDouble(cserr.Text);
            STS = PS * CS;
            textBox2.Text = STS.ToString();
        }

        private void cau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double PA = 125, CA, STA;
            CA = Convert.ToDouble(cau.Text);
            STA = PA * CA;
            textBox3.Text = STA.ToString();
        }

        private void cla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double PL = 150, CL, STL;
            CL = Convert.ToDouble(cla.Text);
            STL = PL * CL;
            textBox4.Text = STL.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double s1, s2, s3, s4, ss;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            s3 = Convert.ToDouble(textBox3.Text);
            s4 = Convert.ToDouble(textBox4.Text);
            ss = Math.Round((s1 + s2 + s3 + s4), 2);
            textBox5.Text = ss.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double STo, T,TS;
            TS = Convert.ToDouble(textBox5.Text);
            if (radioButton1.Checked == true)
            {
                STo = Math.Round((TS * 0),2);
                T = TS - STo;
                textBox6.Text = STo.ToString();
                textBox7.Text = T.ToString();
            }
            if (radioButton2.Checked == true)
            {
                STo = Math.Round((TS * 0.15), 2);
                T = TS - STo;
                textBox6.Text = STo.ToString();
                textBox7.Text = T.ToString();
            }
            if (radioButton3.Checked == true)
            {
                STo = Math.Round((TS * 0.30), 2);
                T = TS - STo;
                textBox6.Text = STo.ToString();
                textBox7.Text = T.ToString();
            }
            if (radioButton4.Checked == true)
            {
                STo = Math.Round((TS * 0.5), 2);
                T = TS - STo;
                textBox6.Text = STo.ToString();
                textBox7.Text = T.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
