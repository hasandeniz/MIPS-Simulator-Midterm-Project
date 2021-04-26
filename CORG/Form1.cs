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
        public List<string> tempFP = new List<string>() { "$f0", "$f1", "$f2", "$f3", "$f4", "$f5", "$f6", "$f7", "$f8", "$f9", "$f10", "$f11", "$f12", "$f13", "$f14", "$f15", "$f16", "$f17", "$f18", "$f19", "$f20", "$f21", "$f22", "$f23", "$f24", "$f25", "$f26", "$f27", "$f28", "$f29", "$f30", "$f31", "$sp" };
        public List<string> logList = new List<string>();
        public List<string> supported = new List<string>() { "add", "addi", "sub", "sw", "lw", "j", "beq", "bne", "bgt", "blt", "mult", "div", "add.d", "sub.d", "div.d", "mul.d" };
        public List<string> splittedLine = new List<string>();
        public string sp = "10400";
        public string zero = "$zero";
        public string firstWord;
        public string memoryNumber = "10400";
        public int tempInt = 0;
        public int tempIndex = 0;
        public int lineNumber = 0;
        public bool isData = false;
        public bool isText = false;             
        public bool isOver = false;
                       
        
        
        public Form1()
        {

            InitializeComponent();
            MakeDataGridView();
            RandomInitialize(8, "s", listBox1);
            RandomInitialize(10, "t", listBox2);
            RandomInitialize(4, "a", listBox3);
            RandomInitialize(2, "v", listBox4);
            InitializeFP(32, "f", listBox7);

            registerValues.Add("$sp", sp);
            registerValues.Add("$hi", "0");
            registerValues.Add("$lo", "0");
            string reg;
            reg = "$hi" + "\t" + "0";
            listBox6.Items.Add(reg);
            reg = "$lo" + "\t" + "0";
            listBox6.Items.Add(reg);


        }
        void InitializeFP(int size, string ch, ListBox lb)
        {
            for (int i = 0; i < size; i++)
            {
                registerValues.Add("$" + ch + i, "1.21");
                string reg = ch + i + "\t" + registerValues.ElementAt(tempInt).Value;
                lb.Items.Add(reg);
                tempInt++;
            }
        }
        void RandomInitialize(int size, string ch, ListBox lb)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int randomNumber = random.Next(-500, 500);
                registerValues.Add("$" + ch + i, randomNumber.ToString());
                string reg = ch + i + "\t" + registerValues.ElementAt(tempInt).Value;
                lb.Items.Add(reg);
                tempInt++;
            }

        }
        private void buton1(object sender, EventArgs e)
        {
            executeButton.Enabled = false;
            functionDetector();
            codeBox.ReadOnly = true;
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

                    if (firstWord == ".data" || firstWord == ".text" || isData == true)
                    {
                        line = line.Remove(0, firstWord.Length);
                        splittedLine = line.Split(' ').ToList();
                    }
                    else
                    {
                        if (supported.Contains(firstWord) && isText == true)
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
            bool isTextT = false;
            int lineNumber = 0;
            while (codeBox.Lines.Length > lineNumber)
            {
                string line = codeBox.Lines.ElementAt(lineNumber);
                line = Regex.Replace(line, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
                string opCode = line.Split(' ').First();
                if (opCode == ".text")
                    isTextT = true;
                if (isTextT)
                {
                    if (opCode.EndsWith(':'))
                    {
                        opCode = opCode.Replace(":", String.Empty);
                        if (!functions.ContainsKey(opCode))
                        {
                            functions.Add(opCode, lineNumber);
                        }

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
                case 's':
                    tabControl.SelectedTab = sRegisterTab;
                    temp = Int32.Parse(index);
                    registerValues[str] = value;
                    reg = ch + index + "\t" + value;
                    listBox1.Items.RemoveAt(temp);
                    listBox1.Items.Insert(temp, reg);
                    break;

                case 't':
                    tabControl.SelectedTab = tRegisterTab;
                    temp = Int32.Parse(index);
                    registerValues[str] = value;
                    reg = ch + index + "\t" + value;
                    listBox2.Items.RemoveAt(temp);
                    listBox2.Items.Insert(temp, reg);
                    break;
                case 'a':
                    tabControl.SelectedTab = aRegisterTab;
                    temp = Int32.Parse(index);
                    registerValues[str] = value;
                    reg = ch + index + "\t" + value;
                    listBox3.Items.RemoveAt(temp);
                    listBox3.Items.Insert(temp, reg);
                    break;
                case 'v':
                    tabControl.SelectedTab = vRegisterTab;
                    temp = Int32.Parse(index);
                    registerValues[str] = value;
                    reg = ch + index + "\t" + value;
                    listBox4.Items.RemoveAt(temp);
                    listBox4.Items.Insert(temp, reg);
                    break;
                case 'f':
                    tabControl.SelectedTab = fRegisterTab;
                    registerValues[str] = value;
                    int val = int.Parse(str.Substring(2, str.Length - 2));
                    int realVal = val + 1;
                    string next = "$f" + realVal.ToString();
                    registerValues[next] = value;


                    listBox7.Items.RemoveAt(realVal);
                    listBox7.Items.Insert(realVal, ch + realVal.ToString() + "\t" + value);
                    listBox7.Items.RemoveAt(val);
                    listBox7.Items.Insert(val, ch + val.ToString() + "\t" + value);
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
            MessageBox.Show("add, addi, sub, sw, lw, beq, bne, bgt, blt, mult, div, add.d, sub.d, div.d, mul.d", "Supported Operations", MessageBoxButtons.OK);
        }
    }

}
