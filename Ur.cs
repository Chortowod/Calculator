using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Ur : Form
    {
        public static int Gg(double a, double b, double c, out double x1, out double x2)
        {

            double d = Deskr(a, b, c);

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 1;
            }

            else
            {
                x1 = (-b + Math.Abs(d)) / (2 * a);
                x2 = x1;
                return 0;
            }
        }

        public static double Deskr(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            return d;
        }

        public Ur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dd;
            double x1;
            double x2;
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;
            if (Deskr(a, b, c) >= 0)
            {
                dd = Gg(a, b, c, out x1, out x2);
                label6.Text = ($"Корни уравнения:\n x1= {x1} \n x2= {x2}");
            }
            else
            {
                dd = -1;
                label6.Text = ($"\n Корней нет");
            }
        }
    }
}
