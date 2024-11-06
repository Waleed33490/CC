using System.Text.RegularExpressions;

namespace Lab3Task2__RE_for_8e4__5e_2___6e9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // take input from a richtextbox/textbox 
         
            String var = richTextBox1.Text;
            // split the input on the basis of space
            String[] words = var.Split(' ');
            // Regular Expression for variables
            // ^[+-]?\d+(\.\d+)?[eE][+-]?\d+$
           
            Regex regex1 = new Regex(@"8e4|5e-2|6e9");

            for (int i = 0; i < words.Length; i++)
            {
                Match match1 = regex1.Match(words[i]);

                if (match1.Success)
                {
                    richTextBox2.Text += words[i] + " ";
                }

                else
                {
                   // MessageBox.Show("invalid " + words[i]);
                }
            }
        }
    }
}