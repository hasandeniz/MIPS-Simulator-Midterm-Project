using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CORG
{
    partial class Form1
    {
        private const string Message = "S register has an error,  line: ";
        private const string Message1 = "T register has an error, line: ";
        private const string Message2 = "Stackoverflow, line: ";
        private const string Message3 = "Integer format is invalid, line: ";
        private const string Message4 = "Syntax Error, line: ";
        private const string Message5 = "There is an error before parentheses, line: ";
        private const string Message6 = "There is an error inside parentheses, line: ";
        private const string Message7 = "Already there is a label with that name, line: ";
        public int mCount = 0;
        private void OneForAll()
        {


            for (int i = 0; i < splittedLine.Count; i++)
            {
                splittedLine[i] = string.Join("", splittedLine[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            }
            if (firstWord == ".text")
            {
                isText = true;
                isData = false;
            }
            if (firstWord == ".data")
                isData = true;


            if (isText)
            {
                CultureInfo usCulture = new CultureInfo("en-US");
                NumberFormatInfo dbNumberFormat = usCulture.NumberFormat;
                switch (firstWord)
                {
                    case "div.d":
                        if (tempFP.Contains(splittedLine[0]))
                        {
                            string temp = CheckLastThingAndComment();

                            if (tempFP.Contains(splittedLine[1]) || splittedLine[1] == zero)
                            {

                                double output;
                                int outp;
                                if (splittedLine[1] == zero)
                                {
                                    output = double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }
                                else if (splittedLine[0] == "$sp")
                                {
                                    int outTemp = int.Parse(registerValues[splittedLine[1]]) / int.Parse(temp);

                                    if (outTemp < 10100 && outTemp > 10000)
                                    {
                                        outp = int.Parse(registerValues[splittedLine[1]]) / int.Parse(temp) - 10000;
                                        ClearColor();
                                        tabControl1.SelectedTab = stackTab;
                                        string valueOfSp = dataGridView1.Rows[outp].ToString();
                                        registerValues[splittedLine[1]] = (outp + 10000).ToString();
                                        dataGridView1.Rows[outp].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);

                                    }
                                    else
                                    {
                                        MakeLog(Message2);
                                    }


                                    break;
                                }
                                else
                                {
                                    output = double.Parse(registerValues[splittedLine[1]], dbNumberFormat) / double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }


                            }
                            else
                            {
                                MakeLog(Message1);

                            }

                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;
                    case "mul.d":
                        if (tempFP.Contains(splittedLine[0]))
                        {
                            string temp = CheckLastThingAndComment();

                            if (tempFP.Contains(splittedLine[1]) || splittedLine[1] == zero)
                            {

                                double output;
                                int outp;
                                if (splittedLine[1] == zero)
                                {
                                    output = double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }
                                else if (splittedLine[0] == "$sp")
                                {
                                    int outTemp = int.Parse(registerValues[splittedLine[1]]) * int.Parse(temp);

                                    if (outTemp < 10100 && outTemp > 10000)
                                    {
                                        outp = int.Parse(registerValues[splittedLine[1]]) * int.Parse(temp) - 10000;
                                        ClearColor();
                                        tabControl1.SelectedTab = stackTab;
                                        string valueOfSp = dataGridView1.Rows[outp].ToString();
                                        registerValues[splittedLine[1]] = (outp + 10000).ToString();
                                        dataGridView1.Rows[outp].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);

                                    }
                                    else
                                    {
                                        MakeLog(Message2);
                                    }


                                    break;
                                }
                                else
                                {
                                    output = double.Parse(registerValues[splittedLine[1]], dbNumberFormat) * double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }


                            }
                            else
                            {
                                MakeLog(Message1);

                            }

                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;
                    case "sub.d":
                        if (tempFP.Contains(splittedLine[0]))
                        {
                            string temp = CheckLastThingAndComment();

                            if (tempFP.Contains(splittedLine[1]) || splittedLine[1] == zero)
                            {

                                double output;
                                int outp;
                                if (splittedLine[1] == zero)
                                {
                                    output = double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }
                                else if (splittedLine[0] == "$sp")
                                {
                                    int outTemp = int.Parse(registerValues[splittedLine[1]]) - int.Parse(temp);

                                    if (outTemp < 10100 && outTemp > 10000)
                                    {
                                        outp = int.Parse(registerValues[splittedLine[1]]) - int.Parse(temp) - 10000;
                                        ClearColor();
                                        tabControl1.SelectedTab = stackTab;
                                        string valueOfSp = dataGridView1.Rows[outp].ToString();
                                        registerValues[splittedLine[1]] = (outp + 10000).ToString();
                                        dataGridView1.Rows[outp].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);

                                    }
                                    else
                                    {
                                        MakeLog(Message2);
                                    }


                                    break;
                                }
                                else
                                {
                                    output = double.Parse(registerValues[splittedLine[1]], dbNumberFormat) - double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }


                            }
                            else
                            {
                                MakeLog(Message1);

                            }

                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;
                    case "add.d":
                        if (tempFP.Contains(splittedLine[0]))
                        {
                            string temp = CheckLastThingAndComment();

                            if (tempFP.Contains(splittedLine[1]) || splittedLine[1] == zero)
                            {

                                double output;
                                int outp;
                                if (splittedLine[1] == zero)
                                {
                                    output = double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }
                                else if (splittedLine[0] == "$sp")
                                {
                                    int outTemp = int.Parse(registerValues[splittedLine[1]]) + int.Parse(temp);

                                    if (outTemp < 10100 && outTemp > 10000)
                                    {
                                        outp = int.Parse(registerValues[splittedLine[1]]) + int.Parse(temp) - 10000;
                                        ClearColor();
                                        tabControl1.SelectedTab = stackTab;
                                        string valueOfSp = dataGridView1.Rows[outp].ToString();
                                        registerValues[splittedLine[1]] = (outp + 10000).ToString();
                                        dataGridView1.Rows[outp].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);

                                    }
                                    else
                                    {
                                        MakeLog(Message2);
                                    }


                                    break;
                                }
                                else
                                {
                                    output = double.Parse(registerValues[splittedLine[1]], dbNumberFormat) + double.Parse(temp, dbNumberFormat);
                                    var a = output.ToString().Replace(',', '.');
                                    doJob(splittedLine[0], a);
                                }


                            }
                            else
                            {
                                MakeLog(Message1);

                            }

                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;
                    case "div":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (registerValues.ContainsKey(splittedLine[1]))
                            {
                                int outputLo = int.Parse(registerValues[splittedLine[0]]) / int.Parse(registerValues[splittedLine[1]]);
                                int outHi = int.Parse(registerValues[splittedLine[0]]) % int.Parse(registerValues[splittedLine[1]]);


                                string reg;
                                tabControl.SelectedTab = hiloTab;
                                registerValues["mult"] = outHi.ToString();
                                reg = "$hi" + "\t" + outHi;
                                listBox6.Items.RemoveAt(0);
                                listBox6.Items.Insert(0, reg);



                                registerValues["mult"] = outputLo.ToString();
                                reg = "$lo" + "\t" + outputLo;
                                listBox6.Items.RemoveAt(1);
                                listBox6.Items.Insert(1, reg);

                            }
                            else
                            {
                                MakeLog(Message1);
                            }
                        }
                        else
                        {
                            MakeLog(Message);
                        }
                        break;
                    case "mult":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (registerValues.ContainsKey(splittedLine[1]))
                            {
                                int output = int.Parse(registerValues[splittedLine[0]]) * int.Parse(registerValues[splittedLine[1]]);
                                if (output < int.MaxValue)
                                {
                                    tabControl.SelectedTab = hiloTab;
                                    registerValues["mult"] = output.ToString();
                                    string reg = "$hi" + "\t" + output;
                                    listBox6.Items.RemoveAt(0);
                                    listBox6.Items.Insert(0, reg);
                                }
                                else
                                {
                                    tabControl.SelectedTab = hiloTab;
                                    int newOut = output - int.MaxValue;
                                    registerValues["mult"] = output.ToString();
                                    string reg = "$lo" + "\t" + output;
                                    listBox6.Items.RemoveAt(1);
                                    listBox6.Items.Insert(1, reg);
                                }
                            }
                            else
                            {
                                MakeLog(Message1);
                            }
                        }
                        else
                        {
                            MakeLog(Message);
                        }
                        break;
                    case "blt":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (registerValues.ContainsKey(splittedLine[1]))
                            {
                                if (functions.ContainsKey(splittedLine[2]))
                                {
                                    if (int.Parse(registerValues[splittedLine[0]]) < int.Parse(registerValues[splittedLine[1]]))
                                    {
                                        lineNumber = functions[splittedLine[2]] - 1;
                                    }
                                }
                            }
                            else
                            {
                                MakeLog(Message1);
                            }
                        }
                        else
                        {
                            MakeLog(Message);
                        }
                        break;
                    case "bgt":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (registerValues.ContainsKey(splittedLine[1]))
                            {
                                if (functions.ContainsKey(splittedLine[2]))
                                {
                                    if (int.Parse(registerValues[splittedLine[0]]) > int.Parse(registerValues[splittedLine[1]]))
                                    {
                                        lineNumber = functions[splittedLine[2]] - 1;
                                    }
                                }
                            }
                            else
                            {
                                MakeLog(Message1);
                            }
                        }
                        else
                        {
                            MakeLog(Message);
                        }
                        break;
                    case "bne":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (registerValues.ContainsKey(splittedLine[1]))
                            {
                                if (functions.ContainsKey(splittedLine[2]))
                                {
                                    if (!registerValues[splittedLine[0]].Equals(registerValues[splittedLine[1]]))
                                    {
                                        lineNumber = functions[splittedLine[2]] - 1;
                                    }
                                }
                            }
                            else
                            {
                                MakeLog(Message1);
                            }
                        }
                        else
                        {
                            MakeLog(Message);
                        }
                        break;
                    case "beq":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (registerValues.ContainsKey(splittedLine[1]))
                            {
                                if (functions.ContainsKey(splittedLine[2]))
                                {
                                    if (registerValues[splittedLine[0]].Equals(registerValues[splittedLine[1]]))
                                    {
                                        lineNumber = functions[splittedLine[2]] - 1;
                                    }
                                }
                            }
                            else
                            {
                                MakeLog(Message1);
                            }
                        }
                        else
                        {
                            MakeLog(Message);
                        }
                        break;
                    case "j":
                        if (functions.ContainsKey(splittedLine[0]))
                        {
                            lineNumber = functions[splittedLine[0]];
                        }
                        else
                        {
                            MakeLog("There is no label with that name, line: ");
                        }
                        break;
                    case "function":
                        break;
                    case ".text":
                        isData = false;
                        break;
                    case "pass":
                        MakeLog("Passed Comment on Line ");
                        break;
                    case "lw":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (gridViewDic.ContainsKey(splittedLine[1]))
                            {
                                doJob(splittedLine[0], gridViewDic[splittedLine[1]]);
                                break;
                            }
                            int a = splittedLine[1].IndexOf('(');
                            int b = splittedLine[1].LastIndexOf(')');

                            if (splittedLine[1].Substring(a + 1, b - a - 1) == "$sp")
                            {
                                if (splittedLine[1].Length > b + 1)
                                {
                                    if (splittedLine[1].Substring(b + 1, 1) != "#")
                                    {
                                        MakeLog(Message4);
                                        return;
                                    }
                                }

                                string temp = splittedLine[1].Substring(0, a);
                                if (int.TryParse(temp, out _) == true)
                                {
                                    int c = Int32.Parse(temp);
                                    int spT = int.Parse(registerValues["$sp"]) + c - 10300;
                                    registerValues[splittedLine[0]] = spT.ToString();
                                    doJob(splittedLine[0], dataGridView1.Rows[spT].Cells[1].Value.ToString());

                                }
                                else
                                {
                                    MakeLog(Message5);
                                }

                            }
                            else
                            {
                                MakeLog(Message6);
                            }
                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;
                    case "sw":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            if (gridViewDic.ContainsKey(splittedLine[1]))
                            {
                                int index = gridViewDicExt[splittedLine[1]];
                                dataGridView2.Rows[index].Cells[2].Value = registerValues[splittedLine[0]];
                                gridViewDic[splittedLine[1]] = registerValues[splittedLine[0]];

                                break;
                            }
                            int a = splittedLine[1].IndexOf('(');
                            int b = splittedLine[1].LastIndexOf(')');

                            if (splittedLine[1].Substring(a + 1, b - a - 1) == "$sp")
                            {
                                if (splittedLine[1].Length > b + 1)
                                {
                                    if (splittedLine[1].Substring(b + 1, 1) != "#")
                                    {
                                        MakeLog(Message4);
                                        return;
                                    }
                                }

                                string temp = splittedLine[1].Substring(0, a);
                                if (int.TryParse(temp, out _) == true)
                                {
                                    int c = Int32.Parse(temp);
                                    int spT = int.Parse(registerValues["$sp"]) + c - 10300;
                                    tabControl1.SelectedTab = stackTab;
                                    dataGridView1.Rows[spT].Cells[1].Value = registerValues[splittedLine[0]];
                                    ClearColor();
                                    dataGridView1.Rows[spT].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);
                                }
                                else
                                {
                                    MakeLog(Message5);
                                }

                            }

                            else
                            {
                                MakeLog(Message6);
                            }
                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;
                    case "sub":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            string temp = CheckLastThingAndComment();

                            if (registerValues.ContainsKey(splittedLine[1]) || splittedLine[1] == zero)
                            {

                                int output;
                                if (splittedLine[1] == zero)
                                {
                                    output = int.Parse(temp);
                                    doJob(splittedLine[0], output.ToString());
                                }
                                else if (splittedLine[0] == "$sp")
                                {
                                    int outTemp = int.Parse(registerValues[splittedLine[1]]) - int.Parse(temp);
                                    if (outTemp < 10100 && outTemp > 10000)
                                    {
                                        output = int.Parse(registerValues[splittedLine[1]]) - int.Parse(temp) - 10000;
                                        ClearColor();
                                        tabControl1.SelectedTab = stackTab;
                                        string valueOfSp = dataGridView1.Rows[output].ToString();
                                        registerValues[splittedLine[1]] = (output + 10000).ToString();
                                        dataGridView1.Rows[output].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);

                                    }
                                    else
                                    {
                                        MakeLog(Message2);
                                    }


                                    break;
                                }
                                else
                                {
                                    output = int.Parse(registerValues[splittedLine[1]]) - int.Parse(temp);
                                    doJob(splittedLine[0], output.ToString());
                                }


                            }
                            else
                            {
                                MakeLog(Message1);

                            }

                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;
                    case "add":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            string temp = CheckLastThingAndComment();

                            if (registerValues.ContainsKey(splittedLine[1]) || splittedLine[1] == zero)
                            {

                                int output;
                                if (splittedLine[1] == zero)
                                {
                                    output = Int32.Parse(temp);
                                    doJob(splittedLine[0], output.ToString());
                                }
                                else if (splittedLine[0] == "$sp")
                                {
                                    int outTemp = int.Parse(registerValues[splittedLine[1]]) + int.Parse(temp);

                                    if (outTemp < 10100 && outTemp > 10000)
                                    {
                                        output = int.Parse(registerValues[splittedLine[1]]) + int.Parse(temp) - 10000;
                                        ClearColor();
                                        tabControl1.SelectedTab = stackTab;
                                        string valueOfSp = dataGridView1.Rows[output].ToString();
                                        registerValues[splittedLine[1]] = (output + 10000).ToString();
                                        dataGridView1.Rows[output].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);

                                    }
                                    else
                                    {
                                        MakeLog(Message2);
                                    }


                                    break;
                                }
                                else
                                {
                                    output = int.Parse(registerValues[splittedLine[1]]) + int.Parse(temp);
                                    doJob(splittedLine[0], output.ToString());
                                }


                            }
                            else
                            {
                                MakeLog(Message1);

                            }

                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;

                    case "addi":
                        if (registerValues.ContainsKey(splittedLine[0]))
                        {
                            int x;
                            if (int.TryParse(splittedLine[2], out int dummy))
                            {
                                x = Int32.Parse(splittedLine[2]);
                            }
                            else if (splittedLine[2].Contains('#'))
                            {
                                int pos = splittedLine[2].IndexOf('#');

                                x = Int32.Parse(splittedLine[2].Substring(0, pos));
                            }
                            else
                            {
                                MakeLog(Message3);
                                break;
                            }

                            if (registerValues.ContainsKey(splittedLine[1]) || splittedLine[1] == zero)
                            {
                                int output;
                                if (splittedLine[1] == zero)
                                {
                                    output = x;
                                    doJob(splittedLine[0], output.ToString());
                                }
                                else if (splittedLine[0] == "$sp")
                                {
                                    int outTemp = x + int.Parse(registerValues[splittedLine[1]]);

                                    if (outTemp < 10100 && outTemp > 10000)
                                    {
                                        tabControl1.SelectedTab = stackTab;

                                        output = x + int.Parse(registerValues[splittedLine[1]]) - 10000;
                                        ClearColor();
                                        string valueOfSp = dataGridView1.Rows[output].ToString();
                                        registerValues[splittedLine[1]] = (output + 10000).ToString();
                                        dataGridView1.Rows[output].DefaultCellStyle.BackColor = Color.FromArgb(77, 237, 48);

                                    }
                                    else
                                    {
                                        MakeLog(Message2);
                                    }
                                    break;
                                }
                                else
                                {
                                    output = x + Int32.Parse(registerValues[splittedLine[1]]);
                                    doJob(splittedLine[0], output.ToString());
                                }


                            }
                            else
                            {
                                MakeLog(Message1);

                            }

                        }
                        else
                        {
                            MakeLog(Message);

                        }
                        break;

                    default:

                        MakeLog("There is an error with opcode, line: ");

                        break;

                }
            }
            else if (isData)
            {
                switch (firstWord)
                {
                    case ".data":
                        break;
                    default:

                        if (firstWord.EndsWith(':'))
                        {
                            if (splittedLine[1] == ".word")
                            {
                                tabControl1.SelectedTab = memoryTab;
                                string value = splittedLine[2];
                                int index = firstWord.LastIndexOf(':');
                                string nameOfData = firstWord.Substring(0, index);
                                int lastStr = int.Parse(memoryNumber) + tempIndex;
                                if (dataGridView2.RowCount > 0)
                                {

                                    //var v = dataGridView2.Rows.Cast<DataGridViewRow>().Any(i => i.Cells[0].Value.ToString() != nameOfData);
                                    if (dataGridView2.Rows.Cast<DataGridViewRow>().Any(i => i.Cells[0].Value.ToString() != nameOfData))
                                    {
                                        if (int.TryParse(splittedLine[2], out int dummy))
                                        {
                                            if (splittedLine.Count < 4)
                                            {
                                                value = splittedLine[2];
                                            }
                                            else
                                            {
                                                if (!splittedLine[3].StartsWith("#"))
                                                {
                                                    MakeLog(Message2);
                                                    break;
                                                }
                                            }

                                        }
                                        else if (splittedLine[2].Contains('#'))
                                        {
                                            int pos = splittedLine[2].IndexOf('#');
                                            value = splittedLine[2].Substring(0, pos);
                                        }
                                        else
                                        {
                                            MakeLog(Message3);
                                            break;
                                        }

                                        dataGridView2.Rows.Add(nameOfData, lastStr.ToString(), value);
                                        gridViewDic.Add(nameOfData, value);
                                        gridViewDicExt.Add(nameOfData, mCount);
                                        mCount++;
                                        tempIndex += 4;
                                    }
                                    else
                                    {
                                        MakeLog(Message7);
                                    }

                                }
                                else
                                {
                                    if (int.TryParse(splittedLine[2], out int dummy))
                                    {
                                        if (splittedLine.Count < 4)
                                        {
                                            value = splittedLine[2];
                                        }
                                        else
                                        {
                                            if (!splittedLine[3].StartsWith("#"))
                                            {
                                                MakeLog(Message4);
                                                break;
                                            }
                                        }
                                    }
                                    else if (splittedLine[2].Contains('#'))
                                    {
                                        int pos = splittedLine[2].IndexOf('#');
                                        value = splittedLine[2].Substring(0, pos);
                                    }
                                    else
                                    {
                                        MakeLog(Message3);
                                        break;
                                    }
                                    dataGridView2.Rows.Add(nameOfData, lastStr.ToString(), value);
                                    gridViewDic.Add(nameOfData, value);
                                    gridViewDicExt.Add(nameOfData, mCount);
                                    mCount++;
                                    tempIndex += 4;
                                }
                            }
                            else if (splittedLine[1] == ".float")
                            {
                                tabControl1.SelectedTab = memoryTab;
                                string value = splittedLine[2];
                                int index = firstWord.LastIndexOf(':');
                                string nameOfData = firstWord.Substring(0, index);
                                int lastStr = int.Parse(memoryNumber) + tempIndex;
                                if (dataGridView2.RowCount > 0)
                                {

                                    //var v = dataGridView2.Rows.Cast<DataGridViewRow>().Any(i => i.Cells[0].Value.ToString() != nameOfData);
                                    if (dataGridView2.Rows.Cast<DataGridViewRow>().Any(i => i.Cells[0].Value.ToString() != nameOfData))
                                    {
                                        if (float.TryParse(splittedLine[2], out float dummy))
                                        {
                                            if (splittedLine.Count < 4)
                                            {
                                                value = splittedLine[2];
                                            }
                                            else
                                            {
                                                if (!splittedLine[3].StartsWith("#"))
                                                {
                                                    MakeLog(Message4);
                                                    break;
                                                }
                                            }

                                        }
                                        else if (splittedLine[2].Contains('#'))
                                        {
                                            int pos = splittedLine[2].IndexOf('#');
                                            value = splittedLine[2].Substring(0, pos);
                                        }
                                        else
                                        {
                                            MakeLog(Message3);
                                            break;
                                        }

                                        dataGridView2.Rows.Add(nameOfData, lastStr.ToString(), value);
                                        gridViewDic.Add(nameOfData, value);
                                        gridViewDicExt.Add(nameOfData, mCount);
                                        mCount++;
                                        tempIndex += 8;
                                    }
                                    else
                                    {
                                        MakeLog(Message7);
                                    }

                                }
                                else
                                {
                                    if (float.TryParse(splittedLine[2], out float dummy))
                                    {
                                        if (splittedLine.Count < 4)
                                        {
                                            value = splittedLine[2];
                                        }
                                        else
                                        {
                                            if (!splittedLine[3].StartsWith("#"))
                                            {
                                                MakeLog(Message4);
                                                break;
                                            }
                                        }
                                    }
                                    else if (splittedLine[2].Contains('#'))
                                    {
                                        int pos = splittedLine[2].IndexOf('#');
                                        value = splittedLine[2].Substring(0, pos);
                                    }
                                    else
                                    {
                                        MakeLog(Message3);
                                        break;
                                    }
                                    dataGridView2.Rows.Add(nameOfData, lastStr.ToString(), value);
                                    gridViewDic.Add(nameOfData, value);
                                    gridViewDicExt.Add(nameOfData, mCount);
                                    mCount++;
                                    tempIndex += 8;
                                }
                            }
                            else
                            {
                                MakeLog(".word missing, line: ");
                            }

                        }
                        else
                        {
                            MakeLog("Error, line: ");
                        }
                        break;
                }
            }
            else
            {
                MakeLog(".data or .text missing, line: ");
            }
        }
        private string CheckLastThingAndComment()
        {
            string temp;
            if (registerValues.ContainsKey(splittedLine[2]))
            {
                temp = registerValues[splittedLine[2]];
                return temp;
            }
            else if (splittedLine[2].Contains('#'))
            {
                int pos = splittedLine[2].IndexOf('#');
                temp = registerValues[splittedLine[2].Substring(0, pos)];
                return temp;

            }
            else
            {
                MakeLog("There is an error with last part, line: ");
                return "";

            }
        }
        private void ClearColor()
        {
            for (int i = 0; i < 100; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void MakeDataGridView()
        {

            int a = 10000;

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Name = "Address";
            dataGridView1.Columns[1].Name = "Value";
            for (int i = 0; i < 400; i += 4)
            {
                dataGridView1.Rows.Add(a + i, "0");
            }

            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Address";
            dataGridView2.Columns[2].Name = "Values";


        }
        private void MakeLog(string message)
        {
            string finalMessage = message + lineNumber.ToString();
            logList.Add(finalMessage);
            listBox5.Update();
            tabControl1.SelectedTab = logTab;
            listBox5.Items.Add(finalMessage);
            oneStepButton.Enabled = false;
            isOver = true;
        }
    }

}
