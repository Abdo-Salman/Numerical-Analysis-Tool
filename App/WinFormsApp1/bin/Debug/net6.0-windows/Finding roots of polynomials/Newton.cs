using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Newton : Form
    {
        public int iNum = 0;
        public Newton()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "iter";
            dataGridView1.Columns[1].Name = "xi";
            dataGridView1.Columns[2].Name = "f(xi)";
            dataGridView1.Columns[3].Name = "f'(xi)";
            dataGridView1.Columns[4].Name = "error%";

            for (int i = 0; i < 4; i++)
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
        public double Nton(double xo, string eq, string eqdrev, double eps, int count)
        {

            int iter = 0;
            double xi, xiplus1, error = 0;
            do
            {
                xi = xo;
                xiplus1 = Math.Round(xi - (f(xi, eq) / f(xi, eqdrev)), 3);
                dataGridView1.Rows.Add(iter.ToString(), xi.ToString(), f(xi, eq).ToString(), f(xi, eqdrev).ToString(), error.ToString($"F{2}", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.') + "%");
                error = Math.Abs((xiplus1 - xi) / xiplus1) * 100;
                iter++;
                xo = xiplus1;
                if (iter == count)
                    break;
            } while (error > eps);
            xi = xo;
            xiplus1 = Math.Round(xi - (f(xi, eq) / f(xi, eqdrev)), 3);
            dataGridView1.Rows.Add(iter.ToString(), xi.ToString(), f(xiplus1, eq).ToString(), f(xi, eqdrev).ToString(), error.ToString($"F{2}", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.') + "%");
            return xiplus1;

        }

        private void FalsePosition_Load(object sender, EventArgs e)
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
            if (eqInp.Text == "" && xNodeInp.Text == "" && eqDervInp.Text == "")
            {
                MessageBox.Show("Please Complete The Empty Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double error = 0;
                double xo = double.Parse(xNodeInp.Text);
                string eq = eqInp.Text;
                string eqdrev = eqDervInp.Text;
                eq = Regex.Replace(eq, @"(\d+)([a-zA-Z])", "$1*$2");
                eqdrev = Regex.Replace(eqdrev, @"(\d+)([a-zA-Z])", "$1*$2");
                if (truebt.Checked == true)
                    error = double.Parse(errorInp.Text);
                else if (falsebt.Checked == true)
                    iNum = int.Parse(iterInp.Text);
                label9.Text = Nton(xo, eq, eqdrev, error, iNum).ToString();
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
            eqDervInp.Text = "";
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