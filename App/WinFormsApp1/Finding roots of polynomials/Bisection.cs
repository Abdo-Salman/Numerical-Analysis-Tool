using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsApp1
{
    public partial class Bisection : Form
    {
        public int iNum = 0;
        public Bisection()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "iter";
            dataGridView1.Columns[1].Name = "xl";
            dataGridView1.Columns[2].Name = "f(xl)";
            dataGridView1.Columns[3].Name = "xu";
            dataGridView1.Columns[4].Name = "f(xu)";
            dataGridView1.Columns[5].Name = "xr";
            dataGridView1.Columns[6].Name = "f(xr)";
            dataGridView1.Columns[7].Name = "error%";

            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public double f(double x, string eq)
        {
            Expression expression = new Expression(eq);
            expression.Bind("x", x);
            double Fx = expression.Eval<double>();
            Fx = Math.Round(Fx, 3);
            if (Fx == 0)
            {
                Fx = expression.Eval<double>();
                Fx = Math.Round(Fx, 4);
            }
            return Fx;
        }
        public double bisect(double xl, double xu, string eq, double eps, int count)
        {
            int iter = 1;
            double xr = 0, xrold, error = 0;
            do
            {
                xrold = xr;
                xr = (xl + xu) / 2;
                error = Math.Abs((xr - xrold) / xr) * 100;

                if (iter == 1)
                {
                    dataGridView1.Rows.Add(iter.ToString(), xl.ToString(), f(xl, eq).ToString(), xu.ToString(), f(xu, eq), xr.ToString(), f(xr, eq).ToString(), "   ---");
                }
                else
                {
                    xr = Math.Round(xr, 4);
                    xl = Math.Round(xl, 4);
                    xu = Math.Round(xu, 4);
                    dataGridView1.Rows.Add(iter.ToString(), xl.ToString(), f(xl, eq).ToString(), xu.ToString(), f(xu, eq), xr.ToString(), f(xr, eq).ToString(), error.ToString($"F{2}", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.') + "%");
                }

                if (f(xl, eq) * f(xr, eq) > 0)
                {
                    xl = xr;
                }
                else
                {
                    xu = xr;
                }
                iter++;

                if (count == iter)
                {
                    break;
                }

            } while (error > eps);
            return xr;

        }
        private void Bisection_Load(object sender, EventArgs e)
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

        private void eqSolve_Click(object sender, EventArgs e)
        {
            if (eqInp.Text == "" && upXInp.Text == "" && lowXInp.Text == "")
            {
                MessageBox.Show("Please Complete The Empty Data", "error  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double error = 0;
                double xl = double.Parse(lowXInp.Text);
                double xu = double.Parse(upXInp.Text);
                string eq = eqInp.Text;
                eq = Regex.Replace(eq, @"(\d+)([a-zA-Z])", "$1*$2");
                if (truebt.Checked == true)
                    error = double.Parse(errorInp.Text);
                else if (falsebt.Checked == true)
                    iNum = int.Parse(iterInp.Text);
                if (f(xl, eq) * f(xu, eq) > 0)
                {
                    MessageBox.Show("Please Complete The Empty Data", "error  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resbt.PerformClick();
                    eqInp.Focus();
                }
                else
                {
                    label9.Text = bisect(xl, xu, eq, error, iNum).ToString();
                    label8.Visible = true;
                    label9.Visible = true;
                    foreach (Control control in Controls)
                        if (control.Name != "dataGridView1" && control.Name != "resbt"
                            && control.Name != "Backb" && control.Name != "label8" && control.Name != "label9")
                            control.Enabled = false;
                }
            }
        }
        private void iterInp_TextChanged_1(object sender, EventArgs e)
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
            lowXInp.Text = "";
            upXInp.Text = "";
            dataGridView1.Rows.Clear();
            falsebt.Checked = false;
            truebt.Checked = false;
            label8.Visible = false;
            label9.Visible = false;
            foreach (Control control in Controls)
                if (control.Name != "eqAns")
                    control.Enabled = true;
        }
    }
}
