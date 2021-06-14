using System;
using System.Drawing;
using System.Globalization;

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
        private const string Message7 = "jr da hata";
        public int mCount = 0;
        private void OneForAll()
        {


            for (int i = 0; i < splittedLine.Count; i++)
            {
                splittedLine[i] = string.Join("", splittedLine[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            }

            CultureInfo usCulture = new CultureInfo("en-US");
            NumberFormatInfo dbNumberFormat = usCulture.NumberFormat;
            switch (firstWord)
            {
                case "add":
                    if (registerValues.ContainsKey(splittedLine[0]))
                    {
                        string lastValue = CheckLastThingAndComment();

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {

                            int output;
                            
                            if (splittedLine[0] == "$sp")
                            {
                                int outTemp = int.Parse(registerValues[splittedLine[1]]) + int.Parse(lastValue);

                                if (outTemp < 10100 && outTemp > 10000)
                                {
                                    output = int.Parse(registerValues[splittedLine[1]]) + int.Parse(lastValue) - 10000;
                                    ClearColor();
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
                                output = int.Parse(registerValues[splittedLine[1]]) + int.Parse(lastValue);
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
                case "sub":
                    if (registerValues.ContainsKey(splittedLine[0]))
                    {
                        string temp = CheckLastThingAndComment();

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {

                            int output;
                           
                            if (splittedLine[0] == "$sp")
                            {
                                int outTemp = int.Parse(registerValues[splittedLine[1]]) - int.Parse(temp);
                                if (outTemp < 10100 && outTemp > 10000)
                                {
                                    output = int.Parse(registerValues[splittedLine[1]]) - int.Parse(temp) - 10000;
                                    ClearColor();
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
                case "and":
                    if (registerValues.ContainsKey(splittedLine[0]))
                    {
                        string temp = CheckLastThingAndComment();

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            int output = int.Parse(registerValues[splittedLine[1]]) & int.Parse(temp);
                            doJob(splittedLine[0], output.ToString());
                            
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
                case "or":
                    if (registerValues.ContainsKey(splittedLine[0]))
                    {
                        string temp = CheckLastThingAndComment();

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            int output = int.Parse(registerValues[splittedLine[1]]) | int.Parse(temp);
                            doJob(splittedLine[0], output.ToString());

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
                case "slt":
                    if (registerValues.ContainsKey(splittedLine[0]))
                    {
                        string lastValue = CheckLastThingAndComment();

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            int output;
                            if(int.Parse(registerValues[splittedLine[1]]) < int.Parse(lastValue))
                            {
                                 output = 1;
                            }
                            else
                            {
                                output = 0;
                            }
                           
                            doJob(splittedLine[0], output.ToString());

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
                case "jr":
                    if(int.Parse(registerValues[splittedLine[0]]) <= codeBox.Lines.Length & int.Parse(registerValues[splittedLine[0]]) >= 0)
                    {
                        lineNumber = int.Parse(registerValues[splittedLine[0]]) - 2; //-2 deneme amaçlı eklendi;
                    }
                    else
                    {
                        MakeLog(Message7);
                    }
                    break;
                case "mul":
                    if (registerValues.ContainsKey(splittedLine[0]))
                    {
                        int lastValue = int.Parse(CheckLastThingAndComment());
                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            int output;                           
                            byte first = (byte)(int.Parse(registerValues[splittedLine[1]]) & 0xFF);
                            byte second = (byte)(lastValue & 0xFF);

                            if (splittedLine[0] == "$sp")
                            {
                                
                                int outTemp = first * second;

                                if (outTemp < 10100 && outTemp > 10000)
                                {
                                    output = first + second - 10000;
                                    ClearColor();
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
                                output = first + second;
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
                case "slti":
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

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            int output;
                            if (int.Parse(registerValues[splittedLine[1]]) < x)
                            {
                                output = 1;
                            }
                            else
                            {
                                output = 0;
                            }

                            doJob(splittedLine[0], output.ToString());

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
                case "muli":
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
                        
                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            byte nx = (byte)(x & 0xFF);
                            byte firstValue = (byte)(int.Parse(registerValues[splittedLine[1]]) & 0xFF);
                            int output = firstValue * nx;
                            doJob(splittedLine[0], output.ToString());
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
                case "lui":
                    if (registerValues.ContainsKey(splittedLine[0]))
                    {
                        int x;
                        if (int.TryParse(splittedLine[1], out int dummy))
                        {
                            x = Int32.Parse(splittedLine[1]);
                        }
                        else if (splittedLine[1].Contains('#'))
                        {
                            int pos = splittedLine[1].IndexOf('#');

                            x = Int32.Parse(splittedLine[1].Substring(0, pos));
                        }
                        else
                        {
                            MakeLog(Message3);
                            break;
                        }
                      
                        int output;
                        output = x << 16;
                        doJob(splittedLine[0], output.ToString());
                      
                    }
                    else
                    {
                        MakeLog(Message);
                    }
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
                case "sll":
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

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            int output = int.Parse(registerValues[splittedLine[1]]) << x;
                            doJob(splittedLine[0], output.ToString());
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
                case "srl":
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

                        if (registerValues.ContainsKey(splittedLine[1]))
                        {
                            int output = int.Parse(registerValues[splittedLine[1]]) >> x;
                            doJob(splittedLine[0], output.ToString());
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
                        lineNumber = functions[splittedLine[0]] -1;//-1 deneme amaçlı eklendi
                    }
                    else if(registerValues.ContainsKey(splittedLine[0]))
                    {
                        lineNumber = int.Parse(registerValues[splittedLine[0]]) - 1;
                    }
                    else
                    {
                        MakeLog("Error, line: ");
                    }
                    break;
                case "jal":
                    if (functions.ContainsKey(splittedLine[0]))
                    {
                        int temp = lineNumber + 1;
                        registerValues["$ra"] = temp.ToString();
                        string reg = "ra" + "\t" + temp;
                        listBox1.Items.RemoveAt(5);
                        listBox1.Items.Insert(5, reg);
                        lineNumber = functions[splittedLine[0]] - 1;//-1 deneme amaçlı eklendi
                    }
                    else
                    {
                        MakeLog("There is no label with that name, line: ");
                    }
                    break;
                case "function":
                    break;
                case "pass":
                    MakeLog("Passed Comment on Line ");
                    break;
                default:
                    MakeLog("There is an error with opcode, line: ");
                    break;
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
