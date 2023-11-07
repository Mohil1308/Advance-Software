using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE__ASSINGMENT
{
    // Inherit from DrawingPaper, indicating that this class extends its functionality.
    public class DrawingControl : DrawingPaper
    {
        // Method to execute a series of drawing commands.
        public void runCommands(String strtxt)
        {
            // Initialize variables for error messages, command, and a flag.
            string errMsg = string.Empty;
            string strCommand = string.Empty;
            Boolean runFlg = true;
            int cmdX = 0, cmdY = 0, cmdz = 0;
            // Split the input string into individual commands based on the semicolon.
            string[] arrCommand = strtxt.ToLower().Split(new string[] { ";" }, StringSplitOptions.None);
            string[] oneCommand;

            // Iterate through each command.
            for (int i = 0; i < arrCommand.Count(); i++)
            {
                // Check if the command is not empty.
                if (arrCommand[i].Trim().ToString() != string.Empty)
                {
                    oneCommand = arrCommand[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < oneCommand.Count(); j++)
                    {
                        if (oneCommand[j].ToString().Trim().Equals("goto"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Command no. " + (i + 1).ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                {
                                    if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        if (runFlg)
                                        {
                                            MovePoint(cmdX, cmdY);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                j = j + 2;
                            }
                        }
                        else if (oneCommand[j].ToString().Trim().Equals("drawline"))
                        {
                            // Check if "drawline" command has the correct number of parameters.
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Command no " + i.ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                {
                                    if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        if (runFlg)
                                        {
                                            DrawLine(cmdX, cmdY);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + i.ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + i.ToString() + "!\n";
                                    runFlg = false;
                                }
                                j = j + 2;
                            }
                        }
                        else if (oneCommand[j].ToString().Trim().Equals("designcircle"))
                        {
                            if (oneCommand.Count() != 2)
                            {
                                errMsg = errMsg + "invalid number of parameters for circle " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                {
                                    if (runFlg)
                                    {
                                        DrawCircle(cmdX);
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Non numeric parameter " + (i + 1).ToString() + "\n";
                                    runFlg = false;
                                }
                                j = j + 1;
                            }
                        }

                        else if (oneCommand[j].ToString().Trim().Equals("pen"))
                        {
                            if (oneCommand.Count() != 2)
                            {
                                errMsg = errMsg + "invalid number of parameters for circle " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                string val = oneCommand[j + 1].Trim();
                                if (val.Equals("red"))
                                {
                                    DrawingShapes.drawColor = new SolidBrush(Color.Red);
                                    DrawingShapes.pColor = Color.Red;
                                }
                                else if (val.Equals("green"))
                                {
                                    DrawingShapes.drawColor = new SolidBrush(Color.Green);
                                    DrawingShapes.pColor = Color.Green;
                                }
                                else if (val.Equals("blue"))
                                {
                                    DrawingShapes.drawColor = new SolidBrush(Color.Blue);
                                    DrawingShapes.pColor = Color.Blue;
                                }
                                j = j + 1;
                            }
                        }


                        else if (oneCommand[j].ToString().Trim().Equals("designsquare"))
                        {
                            if (oneCommand.Count() != 2)
                            {
                                errMsg = errMsg + "Command no " + (i + 1).ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                {
                                    if (runFlg)
                                    {
                                        DrawSquare(cmdX);
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                j = j + 1;
                            }
                        }
                        else if (oneCommand[j].ToString().Trim().Equals("designrect"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Invalid no of argument at command " + (i + 1).ToString() + "!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                {
                                    if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        if (runFlg)
                                        {
                                            DrawRect(cmdX, cmdY);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                j = j + 2;
                            }
                        }
                        else if (oneCommand[j].ToString().Trim().Equals("designtriangle"))
                        {
                            if (oneCommand.Count() != 4)
                            {
                                errMsg = errMsg + "Command no " + (i + 1).ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCommand[j + 1].Trim(), ref cmdX))
                                {
                                    if (checkNumber(oneCommand[j + 2].Trim(), ref cmdY))
                                    {
                                        if (checkNumber(oneCommand[j + 3].Trim(), ref cmdz))
                                        {
                                            if (runFlg)
                                            {
                                                DrawTriangle(cmdX, cmdY, cmdz);
                                            }
                                        }
                                        else
                                        {
                                            errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                            runFlg = false;
                                        }
                                    }
                                    else
                                    {
                                        errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errMsg = errMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                j = j + 3;
                            }
                        }
                        else
                        {
                            errMsg = errMsg + "Unknown Command at line " + (i + 1).ToString();
                            runFlg = false;
                            break;
                        }

                    }
                }
            }
            // Display error messages if any.
            if (errMsg.Trim() != string.Empty)
            {
                PrintMessage(errMsg);
            }

            // Call CurrPoint method if DrawingShapes.Fill is true.
            if (DrawingShapes.Fill)
            {
                CurrPoint(true);
            }
        }

        private Boolean checkNumber(string no, ref int val)
        {
            Boolean isNumber = false;
            if (int.TryParse(no.Trim(), out val))
                isNumber = true;
            return isNumber;
        }
    }
}
