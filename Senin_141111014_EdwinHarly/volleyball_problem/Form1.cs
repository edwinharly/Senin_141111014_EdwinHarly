using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class l : Form
    {
        public l()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long a, b, m, res = 0;
            m = 1000000007;
            a = Convert.ToInt64(Txt1.Text);
            b = Convert.ToInt64(Txt2.Text);
            if (a < b)
            {
                long temp = a;
                a = b;
                b = temp;
            }

            if (a > 25 && a - b != 2)
            {
                res = 0;
            }
            else if (a - b < 2)
            {
                res = 0;
            }
            else if (a < 25)
            {
                res = 0;
            }
            else
            {
                res = nCk(Math.Min(a + b - 1, 47), Math.Min(a - 1, 24), m);
                res *= fast_exp(2, a - 25, m);
                res %= m;
            }
            TxtHasil.Text = res.ToString();
        }

        static private long factorial(long n, long mod)
        {
            long hasil = 1;
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
                hasil %= mod;
            }
            return hasil;
        }
        static private long nCk(long n, long k, long mod)
        {
            if (n < k) return 0;
            long hasil = 1;
            hasil *= factorial(n, mod);
            hasil %= mod;
            hasil *= modularInverse(factorial(n - k, mod), mod);
            hasil %= mod;
            hasil *= modularInverse(factorial(k, mod), mod);
            hasil %= mod;
            return hasil;
        }

        static private long gcd(long a, long b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        static private long modularInverse(long value, long mod)
        {
            long tmp, x, y, times, modulus;
            x = 0;
            y = 1;
            modulus = mod;
            if (mod <= 1 || gcd(value, mod) != 1) return -1;
            while (value > 1)
            {
                times = value / mod;
                tmp = mod;
                mod = value % mod;
                value = tmp;
                tmp = x;
                x = y - times * x;
                y = tmp;
            }
            return (modulus + y) % modulus;
        }

        static private long fast_exp(long b, long e, long mod)
        {
            long result = 1;
            while (e > 0)
            {
                if (e % 2 == 1)
                {
                    result = (result * b) % mod;
                }
                b = (b * b) % mod;
                e /= 2;
            }
            return result % mod;
        }
    }
}
