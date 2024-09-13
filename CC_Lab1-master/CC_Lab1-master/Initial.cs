using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Lab1
{
    public partial class Initial : Form
    {
        public Initial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dynamic_DataGridView dynamic_DataGridView = new Dynamic_DataGridView();
            dynamic_DataGridView.Show();
        }
    }
}
