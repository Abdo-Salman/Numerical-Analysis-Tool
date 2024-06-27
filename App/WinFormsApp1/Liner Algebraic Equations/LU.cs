using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class LU : Form
    {
        public double[,] a = new double[3, 4];
        public double[,] c = new double[3, 1];
        public double x1 = 0, x2 = 0, x3 = 0;
        public LU()
        {
            InitializeComponent();
        }

        public void LuSolve(double m, int r1, int r2)
        {
            for (int i = 0; i <= 2; i++)
            {
                a[r1, i] = a[r1, i] - m * a[r2, i];
            }
            if (a[1, 0] == 0 && a[2, 0] == 0 && a[2, 1] == 0)
            {
                a00.Text = a[0, 0].ToString();
                a01.Text = a[0, 1].ToString();
                a02.Text = a[0, 2].ToString();
                a03.Text = a[0, 3].ToString();

                a10.Text = a[1, 0].ToString();
                a11.Text = a[1, 1].ToString();
                a12.Text = a[1, 2].ToString();
                a13.Text = a[1, 3].ToString();

                a20.Text = a[2, 0].ToString();
                a21.Text = a[2, 1].ToString();
                a22.Text = a[2, 2].ToString();
                a23.Text = a[2, 3].ToString();
            }
        }
        private void Backb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LU_Load(object sender, EventArgs e)
        {

        }

        public void coe_Extract(String eq, int r)
        {
            String expr1 = eq.ToString().Replace(" ", "");
            var results = Regex.Matches(expr1, @"(?<coe>[-]?[0-9]+(\.[0-9]+)?)")
                        .Cast<Match>()
                        .Select(m => m.Groups["coe"].Value)
                        .ToList();

            if (results.Count >= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    double res = double.Parse(results[i]);
                    a[r, i] = res;
                }
            }
            results.Clear();
        }
        private void eqAns_Click(object sender, EventArgs e)
        {

            string eq1 = frstInp.Text;
            string eq2 = SecInp.Text;
            string eq3 = thrdInp.Text;
            coe_Extract(eq1, 0);
            coe_Extract(eq2, 1);
            coe_Extract(eq3, 2);

            double m21 = a[1, 0] / a[0, 0];
            double m31 = a[2, 0] / a[0, 0];
            LuSolve(m21, 1, 0);
            LuSolve(m31, 2, 0);

            double m32 = a[2, 1] / a[1, 1];
            LuSolve(m32, 2, 1);

            double[,] b = { { 1, 0, 0 }, { m21, 1, 0 }, { m31, m32, 1 } };

            c[0, 0] = a[0, 3] / b[0, 0];
            c[1, 0] = (a[1, 3] + (-1 * c[0, 0] * b[1, 0])) / b[1, 1];
            c[2, 0] = (a[2, 3] + (-1 * c[0, 0] * b[2, 0]) + (-1 * c[1, 0] * b[2, 1])) / b[2, 2];

            x3 = c[2, 0] / a[2, 2];
            x2 = (c[1, 0] + (-1 * a[1, 2] * x3)) / a[1, 1];
            x1 = (c[0, 0] + (-1 * a[0, 2] * x3) + (-1 * a[0, 1] * x2)) / a[0, 0];

            foreach (Control control in Controls)
                control.Visible = true;

            c1Out.Text = c[0, 0].ToString();
            c2Out.Text = c[1, 0].ToString();
            c3Out.Text = c[2, 0].ToString();

            x1Out.Text = x1.ToString();
            x2Out.Text = x2.ToString();
            x3Out.Text = x3.ToString();

            m21Out.Text = m21.ToString();
            m31Out.Text = m31.ToString();
            m32Out.Text = m32.ToString();

            eqAns.Enabled = false;
        }

        private void thrdInp_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(frstInp.Text))
            {
                if (!string.IsNullOrEmpty(SecInp.Text))
                {
                    if (!string.IsNullOrEmpty(thrdInp.Text))
                        eqAns.Enabled = true;
                }
            }
            else
                eqAns.Enabled = false;
        }

        private void resbt_Click(object sender, EventArgs e)
        {
            frstInp.Text = "";
            SecInp.Text = "";
            thrdInp.Text = "";

            m21Out.Text = "";
            m31Out.Text = "";
            m32Out.Text = "";

            c1Out.Text = "";
            c2Out.Text = "";
            c3Out.Text = "";

            x1Out.Text = "";
            x2Out.Text = "";
            x3Out.Text = "";

            a00.Text = "";
            a01.Text = "";
            a02.Text = "";

            a10.Text = "";
            a11.Text = "";
            a12.Text = "";

            a20.Text = "";
            a21.Text = "";
            a22.Text = "";

            foreach (Control control in Controls)
                if (control.Name != "label1" && control.Name != "label2" && control.Name != "label3"
                    && control.Name != "resbt" && control.Name != "Backb" && control.Name != "eqAns"
                    && control.Name != "frstInp" && control.Name != "SecInp" && control.Name != "thrdInp")
                    control.Visible = false;
            eqAns.Enabled = false;
        }
    }
}
