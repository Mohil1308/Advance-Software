using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE__ASSINGMENT
{
    /// <summary>
    /// This class extends the functionality of the DrawingPaper class and provides methods
    /// to execute a series of drawing commands based on input text.
    /// </summary>
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
            string[] split;
            int counter = 0;
            int jump = 0;
            int[] sSplit = new int[50];

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
                        else if (split[0] == "if")
                        {
                            int left;
                            int right;
                            string condition;
                            if (split.Length > 4)
                            {
                                MessageBox.Show("need more input", "Error");
                            }
                            else
                            {
                                if (!int.TryParse(split[1], out left))
                                {
                                    left = variable(split[1]);
                                }
                                else
                                {
                                    int.TryParse(split  [1], out left);
                                }

                                if (!int.TryParse(split [3], out right))
                                {
                                    right = variable(split[3]);
                                }
                                else
                                {
                                    int.TryParse(split[3], out right);
                                }
                                condition = split[2];
                                ifcheck(left, condition, right);
                                if (ifrslt == true)
                                {
                                    jump = counter + 2;
                                    break;
                                }
                                else
                                {
                                    counter++;
                                }
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
                        else if (oneCommand[j].ToString().Trim().Equals("var"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Invalid number of parameters for variable definition at command no " + (i + 1).ToString() + "!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                // Extract variable name and value from command parameters
                                string varName = oneCommand[j + 1].Trim();
                                string varValue = oneCommand[j + 2].Trim();

                                // Call a method to handle variable definition
                                object value = DefineVariable(varName, varValue);

                                // Move the index to skip processing of variable definition parameters
                                j = j + 2;
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
        private int variable(string variable)
        {
            int number = -1; // Default value if variable is not found
            for (int i = 0; i < parm.Length; i++)
            {
                if (parm[i] == variable)
                {
                    number = sSplit[i];
                    break; // Exit loop once variable is found
                }
            }

            if (number == -1)
            {
                MessageBox.Show($"Variable '{variable}' not found.", "Error");
            }

            return number;
        }
        private object DefineVariable(string varName, string varValue)
        {
            throw new NotImplementedException();
        }
        private bool ifrslt = false;

        private Boolean checkNumber(string no, ref int val)
        {
            Boolean isNumber = false;
            if (int.TryParse(no.Trim(), out val))
                isNumber = true;
            return isNumber;
        }
    }
}
