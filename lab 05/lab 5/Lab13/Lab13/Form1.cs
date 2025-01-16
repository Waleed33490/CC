using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab13
{
    public partial class Form1 : Form
    {


        List<List<String>> Symboltable = new List<List<String>>();
        ArrayList LineNumber;
        ArrayList Variables;
        ArrayList KeyWords;
        ArrayList Constants;
        ArrayList finalArray;
        ArrayList tempArray;
        Regex variable_Reg;
        Regex constants_Reg;
        Regex operators_Reg;
        int lexemes_per_line;
        int ST_index;

        public Form1()
        {
            InitializeComponent();
            String[] k_ = { "int", "float", "begin", "end", "print", "if", "else" };
            ArrayList key = new ArrayList(k_);
            LineNumber = new ArrayList();
            Variables = new ArrayList();
            KeyWords = new ArrayList();
            Constants = new ArrayList();
            finalArray = new ArrayList();
            tempArray = new ArrayList();
            variable_Reg = new Regex(@"^[A-Za-z|_][A-Za-z|0-9]*$");
            constants_Reg = new Regex(@"^[0-9]+([.][0-9]+)?([e]([+|-])?[0-9]+)?$");
            operators_Reg = new Regex(@"[+-/*=;>(){}]");
            int L = 1;
            Output.Text = "";
            ST.Text = "";
            Symboltable.Clear();
            if_deleted = false;
            string strinput = Input.Text;
            char[] charinput = strinput.ToCharArray();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
