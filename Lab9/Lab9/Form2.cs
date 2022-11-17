using lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperationsOnArrays resault = new OperationsOnArrays(Program.GetDoubles(textBox1.Text)) + new OperationsOnArrays(Program.GetDoubles(textBox2.Text));
                label3.Text = $"Сумма массивов:\n{Program.DoubleToString(resault.Array)}";
            }
            catch
            {
                label1.Text = label2.Text = "Массивы введены неверно";
            }      
        }
    }
}
