using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormClientBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateBMIClient client = new CalculateBMIClient();
            var length = double.Parse(textBox1.Text);
            var weight = double.Parse(textBox2.Text);
            var result = client.CalculateBmi(length, weight).ToString();
            lblResult.Text = result;
        }
    }
}
