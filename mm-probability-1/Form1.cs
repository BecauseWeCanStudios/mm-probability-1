using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mm_probability_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calculate21();
            CalculatePoints();
        }

        private void Calculate21Btn_Click(object sender, EventArgs e)
        {
            Calculate21Btn.Enabled = false;
            Calculate21();
            Calculate21Btn.Enabled = true;
        }

        private void CalculatePointsBtn_Click(object sender, EventArgs e)
        {
            CalculatePointsBtn.Enabled = false;
            CalculatePoints();
            CalculatePointsBtn.Enabled = true;
        }

        private void Calculate21()
        {
            int n = (int) N21NUD.Value;
            TrueProb21LBL.Text = $@"{308.0 / 7140.0:F10}";
            int[] vals =
            {
                6, 7, 8, 9, 10, 11, 12, 13, 1, 6, 7, 8, 9, 10, 11, 12, 13, 1, 6, 7, 8, 9,
                10, 11, 12, 13, 1, 6, 7, 8, 9, 10, 11, 12, 13, 1
            };
            int c = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Random rnd = new Random();
            for (var i = 0; i < n; ++i)
            {
                if (vals.OrderBy(arg => rnd.Next()).Take(3).Sum() == 21)
                {
                    ++c;
                }
            }
            watch.Stop();
            ProbEst21LBL.Text = $@"{(double) c / n:F10}";
            EstError21LBL.Text = $@"{Math.Abs(308.0 / 7140.0 - (double) c / n):F10}";
            TimeSpent21LBL.Text = $@"{watch.ElapsedMilliseconds}";
        }

        private void CalculatePoints()
        {
            int n = (int)NPointsNUD.Value;
            Double.TryParse(KCoeffTB.Text, out double k);
            k.Clamp(0, 1);
            Double.TryParse(SegmentLengthTB.Text, out double l);
            TrueProbPointsLBL.Text = $@"{(2 - k) * k}";
            int c = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Random rnd = new Random();
            for (var i = 0; i < n; ++i)
            {
                if (Math.Abs(rnd.NextDouble() - rnd.NextDouble()) < k)
                {
                    ++c;
                }
            }
            watch.Stop();
            EstProbPointsLBL.Text = $@"{(double)c / n:F10}";
            ErrorEstPointsLBL.Text = $@"{Math.Abs((2 - k) * k - (double)c / n):F10}";
            TimeSpentPointsLBL.Text = $@"{watch.ElapsedMilliseconds}";
        }
    }

    static class Extensions
    {
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0)
                return min;
            else if (val.CompareTo(max) > 0)
                return max;
            else
                return val;
        }
    }
}