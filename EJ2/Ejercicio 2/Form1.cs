using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (Double i = 1; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1, n2, n3, n4, C;
            n1 = Convert.ToDouble(comboBox1.Text);
            n2 = Convert.ToDouble(comboBox2.Text);
            n3 = Convert.ToDouble(comboBox3.Text);
            n4 = Convert.ToDouble(comboBox4.Text);
            C = ((n1 + n2 + n3 + n4) / 4);
            C = Math.Round((C), 2);
            Resul.Text = C.ToString() + "%";
            if (C >= 70)
            {
                MessageBox.Show ("Aprobado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Aprobado", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

    }
}
