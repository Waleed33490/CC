using System.Text.RegularExpressions;

namespace Lab2Task1_RE_for_logical_operators_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var = richTextBox1.Text;
            String[] words = var.Split(' ');

            Regex regex1 = new Regex(@"AND|OR|and|or|XOR|&&|<=|<|>|>=|!=|==|&|OR*|!|[||]{2}|\|");
            for (int i = 0; i < words.Length; i++) {

                Match match = regex1.Match(words[i]);
                if (match.Success) {
                    richTextBox2.Text += words[i];
                }
            }

        }
    }
}