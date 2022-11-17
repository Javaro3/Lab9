using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab9
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public double[] GetDoubles(string str)
        {
            string[] arrStr = str.Replace(".", ",").Split(' ');
            double[] arr = new double[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = Convert.ToDouble(arrStr[i]);
            }
            return arr;
        }

        static public string DoubleToString(double[] arr)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                str.Append(Convert.ToString(arr[i]) + " ");
            }
            return str.ToString();
        }
    }
}
