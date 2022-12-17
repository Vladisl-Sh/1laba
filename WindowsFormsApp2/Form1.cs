using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Double Results = 0.0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void standaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 233;
            txtDisplay.Width = 218;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 233;
            txtDisplay.Width = 218;

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 233;
            txtDisplay.Width = 218;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";

            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            Results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(Results) + " " + operation;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (Results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (Results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (Results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (Results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "^":
                    double q;
                    q = (Results);
                    txtDisplay.Text = Math.Pow(q, Double.Parse(txtDisplay.Text)).ToString();
                    break;

            }
        }


        private void button25_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + " ( " + (txtDisplay.Text) + " ) ");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(-1.0 * Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }
    }
}
