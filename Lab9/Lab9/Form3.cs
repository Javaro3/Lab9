using lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperationsOnArrays resault = new OperationsOnArrays(Program.GetDoubles(textBox1.Text)) * Convert.ToDouble(textBox2.Text);
                label3.Text = $"Массив умноженный на {textBox2.Text}:\n{Program.DoubleToString(resault.Array)}";
            }
            catch
            {
                label1.Text = label2.Text = "Массивы введены неверно";
            }
        }
    }
}