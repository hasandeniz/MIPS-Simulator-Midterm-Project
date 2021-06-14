using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CORG
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> registerValues = new Dictionary<string, string>();
        public Dictionary<string, int> functions = new Dictionary<string, int>();
        public Dictionary<string, string> gridViewDic = new Dictionary<string, string>();
        public Dictionary<string, int> gridViewDicExt = new Dictionary<string, int>();
        public List<string> logList = new List<string>();
        public List<string> supported = new List<string>() {"add","sub","and","or","slt","jr","mul","slti","beq","bne","muli","lui","lw","sw","sll","srl","j","jal"};
        public List<string> splittedLine = new List<string>();
        public string sp = "10400";
        public string zero = "$zero";
        public string firstWord;
        public string memoryNumber = "10400";
        public int lineNumber = 0;           
        public bool isOver = false;
                       
        
        
        public Form1()
        {

            InitializeComponent();
            MakeDataGridView();
            Initialize();
            registerValues.Add("$sp", sp);
            registerValues.Add("$zero", 0.ToString());
            registerValues.Add("$ra", 0.ToString());// 1 de olabilir
            listBox1.Items.Add("ra" + "\t" + 0);

        }    
        void Initialize()
        {
            string ch = "r";
            int size = 5;
            int tempInt = 0;
            int initializeValue = 2;
            for (int i = 0; i < size; i++)            {                
                registerValues.Add("$" + ch + i, initializeValue.ToString());
                string reg = ch + i + "\t" + registerValues.ElementAt(tempInt).Value;
                listBox1.Items.Add(reg);
                tempInt++;
            }

        }
        private void buton1(object sender, EventArgs e)
        {
            executeButton.Enabled = false;
            functionDetector();
            buttonFunc();
        }
        private void buttonFunc()
        {

            if (codeBox.Lines.Length > lineNumber)
            {

                string line = codeBox.Lines.ElementAt(lineNumber);
                line = line.TrimStart();

                if (line != "")
                {
                    colorBack(codeBox.Lines.ElementAt(lineNumber));

                    firstWord = line.Split(' ').First();

                    foreach (char ch in firstWord)
                    {
                        if (ch == '#')
                        {
                            firstWord = "pass";
                            break;
                        }

                    }
                    if (supported.Contains(firstWord))
                    {
                        line = line.Remove(0, firstWord.Length + 1);
                        splittedLine = line.Split(',').ToList();
                    }
                    if (line.EndsWith(":"))
                    {
                        line = line.Replace(":", String.Empty);
                        if (functions.ContainsKey(line))
                        {
                            firstWord = "function";

                        }
                    }
                    
                    OneForAll();
                }

            }
            else
            {
                isOver = true;
                MakeLog("Successfully compiled! line: ");
                oneStepButton.Enabled = false;

            }

            lineNumber++;

        }
        private void functionDetector()
        {
            int lineNumber = 0;
            while (codeBox.Lines.Length > lineNumber)
            {
                string line = codeBox.Lines.ElementAt(lineNumber);
                line = Regex.Replace(line, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                string opCode = line.Split(' ').First();
              
                if (opCode.EndsWith(':'))
                {
                    opCode = opCode.Replace(":", String.Empty);
                    if (!functions.ContainsKey(opCode))
                    {
                        functions.Add(opCode, lineNumber);
                    }

                }
                
                lineNumber++;

            }

        }
        private void colorBack(string line)
        {
            int counter = 0;
            codeBox.SelectAll();
            codeBox.SelectionBackColor = Color.White;
            codeBox.Lines.Take(lineNumber).ToList().ForEach(i => counter += i.Length + 1);
            Math.Max(0, counter);
            codeBox.Select(counter, line.Length);
            codeBox.SelectionBackColor = Color.GreenYellow;
        }
        private void doJob(string str, string value)
        {
            int temp;
            string reg;
            char ch = str.ElementAt(1);
            string index = str.Substring(2, str.Length - 2);
            switch (ch)
            {
                default:
                    temp = Int32.Parse(index);
                    registerValues[str] = value;
                    reg = ch + index + "\t" + value;
                    listBox1.Items.RemoveAt(temp);
                    listBox1.Items.Insert(temp, reg);
                    break;
           
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            logList.Clear();
            listBox5.Items.Clear();
            listBox5.Update();

        }
        private void executeButton_Click(object sender, EventArgs e)
        {
            while (!isOver)
            {
                functionDetector();
                codeBox.ReadOnly = true;
                buttonFunc();

            }
            executeButton.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("add, sub, and, or, slt, jr, mul, slti, beq, bne, muli, lui, lw, sw, sll, srl, j, jal", "Supported Operations", MessageBoxButtons.OK);
        }
    }

}
