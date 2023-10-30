using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Software_first_module
{
    public class DrawControl : Canvass
    {
        public void runCommands(String strtxt)
        {
            string errMsg = string.Empty;
            string strCommand = string.Empty; 
            Boolean runFlg = false;
            int cmdA = 0, cmdB = 0, cmdC = 0;
            string[] arrCommand = strtxt.ToLower().Split(new string[] { ";" }, StringSplitOptions.None);
            string[] oneCommand;
            for(int x = 0; x < arrCommand.Count(); x++)
            {
                if (arrCommand[x].Trim().ToString() != string.Empty)
                {
                    oneCommand = arrCommand[x].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for(int y = 0; y < oneCommand.Count(); y++)
                    {
                        if (oneCommand[y].ToString().Trim().Equals("moveto"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Command no. " + (x + 1).ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[y + 1].Trim(), ref cmdA))
                                {
                                    if (checkNumber(oneCommand[y + 2].Trim(), ref cmdB))
                                    {
                                        if (runFlg)
                                        {
                                            MoPoint(cmdA, cmdB);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                y = y + 2;
                            }

                    }
                        else if (oneCommand[y].ToString().Trim().Equals("drawto"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Command no " + x.ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[y + 1].Trim(), ref cmdA))
                                {
                                    if (checkNumber(oneCommand[y + 2].Trim(), ref cmdB))
                                    {
                                        if (runFlg)
                                        {
                                            DrLine(cmdA, cmdB);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + x.ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + x.ToString() + "!\n";
                                    runFlg = false;
                                }
                                y = y + 2;
                            }
                        }
                        else if (oneCommand[y].ToString().Trim().Equals("circle"))
                        {
                            if (oneCommand.Count() != 2)
                            {
                                errMsg = errMsg + "invalid number of parameters for circle " + (x + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[y + 1].Trim(), ref cmdA))
                                {
                                    if (runFlg)
                                    {
                                        DrCircle(cmdA);
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Non numeric parameter " + (x + 1).ToString() + "\n";
                                    runFlg = false;
                                }
                                y = y + 1;
                            }
                        }
                        else if (oneCommand[y].ToString().Trim().Equals("pen"))
                        {
                            if (oneCommand.Count() != 2)
                            {
                                errMsg = errMsg + "invalid number of parameters for circle " + (x + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                string val = oneCommand[y + 1].Trim();
                                if (val.Equals("red"))
                                {
                                    DrawShape.FillColor = new SolidBrush(Color.Red);
                                    DrawShape.penColor = Color.Red;
                                }
                                else if (val.Equals("green"))
                                {
                                    DrawShape.FillColor = new SolidBrush(Color.Green);
                                    DrawShape.penColor = Color.Green;
                                }
                                else if (val.Equals("blue"))
                                {
                                    DrawShape.FillColor = new SolidBrush(Color.Blue);
                                    DrawShape.penColor = Color.Blue;
                                }
                                y = y + 1;
                            }
                        }
                        else if (oneCommand[y].ToString().Trim().Equals("square"))
                        {
                            if (oneCommand.Count() != 2)
                            {
                                errMsg = errMsg + "Command no " + (x + 1).ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[j + 1].Trim(), ref cmdA))
                                {
                                    if (runFlg)
                                    {
                                        DrSquare(cmdA);
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                y = y + 1;
                            }
                        }
                        else if (oneCommand[j].ToString().Trim().Equals("rect"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Invalid no of argument at command " + (x + 1).ToString() + "!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[y + 1].Trim(), ref cmdA))
                                {
                                    if (checkNumber(oneCommand[y + 2].Trim(), ref cmdB))
                                    {
                                        if (runFlg)
                                        {
                                            DrRect(cmdA, cmdB);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                y = y + 2;
                            }
                        }
                        else if (oneCommand[y].ToString().Trim().Equals("triangle"))
                        {
                            if (oneCommand.Count() != 4)
                            {
                                errMsg = errMsg + "Command no " + (x + 1).ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[y + 1].Trim(), ref cmdA))
                                {
                                    if (checkNumber(oneCommand[y + 2].Trim(), ref cmdB))
                                    {
                                        if (checkNumber(oneCommand[y + 3].Trim(), ref cmdC))
                                        {
                                            if (runFlg)
                                            {
                                                DrTriangle(cmdA, cmdB, cmdC);
                                            }
                                        }
                                        else
                                        {
                                            errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                            runFlg = false;
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (x + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                y = y + 3;
                            }
                        }
                        else
                        {
                            errMsg = errMsg + "Unknown Command at line " + (x + 1).ToString();
                            runFlg = false;
                            break;
                        }
                    }
            }

        }
            if (errMsg.Trim() != string.Empty)
            {
                PrintMessage(errMsg);
            }
            if (DrawShape.isFill)
            {
                LivePoint(true);
            }
        }
       

    }
}

