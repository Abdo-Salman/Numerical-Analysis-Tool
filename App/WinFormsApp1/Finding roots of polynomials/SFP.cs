using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using org.matheval;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace WinFormsApp1
{

    public partial class SFP : Form
    {
        public int iNum = 0;
        public bool isPlaceholderActive = true;
        bool containsSquareRoot = false;
        public SFP()
        {
            InitializeComponent();
            eqInp.Text = "Enter Equation as x = ....";
            eqInp.ForeColor = Color.Gray;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "iter";
            dataGridView1.Columns[1].Name = "xi";
            dataGridView1.Columns[2].Name = "f(xi) = ";
            dataGridView1.Columns[3].Name = "error%";

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        public double g(double x, string eq)
        {
            double Fx = 0;
            if (containsSquareRoot)
            {
                eq = eq.Replace("√", "");
                Expression expression = new Expression(eq);
                expression.Bind("x", x);
                Fx = Math.Sqrt(expression.Eval<double>());
                Fx = Math.Round(Fx, 3);
                if (Fx == 0)
                {
                    Fx = Math.Sqrt(expression.Eval<double>());
                    Fx = Math.Round(Fx, 4);
                }
                eq = "√" + eq;
            }
            else
            {
                Expression expression = new Expression(eq);
                expression.Bind("x", x);
                Fx = expression.Eval<double>();
                Fx = Math.Round(Fx, 3);
                if (Fx == 0)
                {
                    Fx = expression.Eval<double>();
                    Fx = Math.Round(Fx, 4);
                }
            }
            return Fx;

        }
        public double SFPoint(double xo, string eq, double eps, int count)
        {
            int iter = 0;
            double xi, xPlus1, error = 0;
            do
            {
                xi = xo;
                xPlus1 = g(xi, eq);
                dataGridView1.Rows.Add(iter.ToString(), xi.ToString(), g(xi, eq).ToString(), error.ToString($"F{2}", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.') + "%");
                error = Math.Abs((xPlus1 - xi) / xPlus1) * 100;
                iter++;
                xo = xPlus1;
                if (count == iter)
                    break;
            } while (error > eps);
            xi = xo;
            xPlus1 = g(xi, eq);
            dataGridView1.Rows.Add(iter.ToString(), xi.ToString(), g(xi, eq).ToString(), error.ToString($"F{2}", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.') + "%");
            return xPlus1;
        }

        private void SFP_Load(object sender, EventArgs e)
        {

        }
        private void Backb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void truebt_CheckedChanged(object sender, EventArgs e)
        {
            if (truebt.Checked)
            {
                falsebt.Checked = false;
                label5.Visible = true;
                label6.Visible = true;
                errorInp.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                errorInp.Text = "";
                errorInp.Visible = false;
            }
        }

        private void falsebt_CheckedChanged(object sender, EventArgs e)
        {
            if (falsebt.Checked == true)
            {
                truebt.Checked = false;
                label5.Visible = true;
                label7.Visible = true;
                iterInp.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label7.Visible = false;
                iterInp.Text = "";
                iterInp.Visible = false;
            }

        }
        private void eqAns_Click(object sender, EventArgs e)
        {
            if (eqInp.Text == "" && xNodeInp.Text == "")
            {
                MessageBox.Show("Please Complete The Empty Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double error = 0;
                double xo = double.Parse(xNodeInp.Text);
                string eq = eqInp.Text;
                containsSquareRoot = eq.Contains("√");
                eq = Regex.Replace(eq, @"(\d+)([a-zA-Z])", "$1*$2");
                if (truebt.Checked == true)
                    error = double.Parse(errorInp.Text);
                else if (falsebt.Checked == true)
                    iNum = int.Parse(iterInp.Text);
                label9.Text = SFPoint(xo, eq, error, iNum).ToString();
                label8.Visible = true;
                label9.Visible = true;
                foreach (Control control in Controls)
                    if (control.Name != "dataGridView1" && control.Name != "resbt"
                        && control.Name != "Backb" && control.Name != "label8" && control.Name != "label9")
                        control.Enabled = false;
            }
        }
        private void iterInp_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(iterInp.Text))
            {
                eqAns.Enabled = true;
            }
            else
            {
                eqAns.Enabled = false;
            }
        }

        private void errorInp_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errorInp.Text))
            {
                eqAns.Enabled = true;
            }
            else
            {
                eqAns.Enabled = false;
            }
        }


        private void resbt_Click(object sender, EventArgs e)
        {
            eqInp.Text = "";
            xNodeInp.Text = "";
            dataGridView1.Rows.Clear();
            falsebt.Checked = false;
            truebt.Checked = false;
            label8.Visible = false;
            label9.Visible = false;
            foreach (Control control in Controls)
                if (control.Name != "eqAns")
                    control.Enabled = true;
            eqInp.Focus();
        }
    }
}
