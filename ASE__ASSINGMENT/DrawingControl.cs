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

            int counter = 0;

            // Iterate through each command.
            for (int i = 0; i < arrCommand.Count(); i++)
            {
                // Check if the command is not empty.
                if (arrCommand[i].Trim().ToString() != string.Empty)
                {
                    oneCommand = arrCommand[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int j = 0;
                    {
                        if (oneCommand[j].ToString().Trim().Equals("goto"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Invalid number of parameters for goto " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                int x, y;
                                string xParameter = oneCommand[j + 1].Trim();
                                string yParameter = oneCommand[j + 2].Trim();

                                // Check if the coordinates parameters are variable names
                                if (variables.ContainsKey(xParameter) && variables.ContainsKey(yParameter))
                                {
                                    // If they are variables, retrieve their values
                                    if (!int.TryParse(variables[xParameter], out x) || !int.TryParse(variables[yParameter], out y))
                                    {
                                        // If any variable value is not a valid integer, display an error message
                                        errMsg = errMsg + "Invalid value for variable(s) in goto parameters\n";
                                        runFlg = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    // If they are not variables, try parsing them as integers
                                    if (!int.TryParse(xParameter, out x) || !int.TryParse(yParameter, out y))
                                    {
                                        // If parsing fails, display an error message
                                        errMsg = errMsg + "Invalid coordinates value(s) for goto\n";
                                        runFlg = false;
                                        break;
                                    }
                                }

                                // If no errors occurred, proceed to move the cursor
                                if (runFlg)
                                {
                                    // Move the cursor to the specified coordinates
                                    MovePoint(x, y);
                                }
                            }
                        }

                        else if (oneCommand[j].ToString().Trim().Equals("drawline"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Invalid number of parameters for drawline " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                int x2, y2;
                                string x2Parameter = oneCommand[j + 1].Trim();
                                string y2Parameter = oneCommand[j + 2].Trim();

                                // Check if the coordinates parameters are variable names
                                if (variables.ContainsKey(x2Parameter) && variables.ContainsKey(y2Parameter))
                                {
                                    // If they are variables, retrieve their values
                                    if (!int.TryParse(variables[x2Parameter], out x2) || !int.TryParse(variables[y2Parameter], out y2))
                                    {
                                        // If any variable value is not a valid integer, display an error message
                                        errMsg = errMsg + "Invalid value for variable(s) in drawline parameters\n";
                                        runFlg = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    // If they are not variables, try parsing them as integers
                                    if (!int.TryParse(x2Parameter, out x2) || !int.TryParse(y2Parameter, out y2))
                                    {
                                        // If parsing fails, display an error message
                                        errMsg = errMsg + "Invalid coordinates value(s) for drawline\n";
                                        runFlg = false;
                                        break;
                                    }
                                }

                                // If no errors occurred, proceed to draw the line
                                if (runFlg)
                                {
                                    // Draw the line using the provided or variable coordinates
                                    DrawLine(x2, y2);
                                }
                            }
                        }

                        else if (oneCommand[j].ToString().Trim().Equals("designcircle"))
                        {
                            if (oneCommand.Count() != 2)
                            {
                                errMsg = errMsg + "Invalid number of parameters for circle " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                string radiusParameter = oneCommand[j + 1].Trim();
                                int radius;

                                // Check if the radius parameter is a variable name
                                if (variables.ContainsKey(radiusParameter))
                                {
                                    // If it's a variable, retrieve its value
                                    if (!int.TryParse(variables[radiusParameter], out radius))
                                    {
                                        // If the variable value is not a valid integer, display an error message
                                        errMsg = errMsg + "Invalid value for variable " + radiusParameter + "\n";
                                        runFlg = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    // If it's not a variable, try parsing it as an integer
                                    if (!int.TryParse(radiusParameter, out radius))
                                    {
                                        // If parsing fails, display an error message
                                        errMsg = errMsg + "Invalid radius value: " + radiusParameter + "\n";
                                        runFlg = false;
                                        break;
                                    }
                                }

                                // If no errors occurred, proceed to draw the circle
                                if (runFlg)
                                {
                                    // Draw the circle using the provided or variable radius
                                    DrawCircle(radius);
                                }
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
                        else if (oneCommand[0] == "if")
                        {
                            int jump = 0;
                            int left;
                            int right;
                            string condition;
                            if (oneCommand.Length > 4)
                            {
                                MessageBox.Show("need more input", "Error");
                            }
                            else
                            {
                                if (!int.TryParse(oneCommand[1], out left))
                                {
                                    left = variable(oneCommand[1]);
                                }
                                else
                                {
                                    int.TryParse(oneCommand[1], out left);
                                }

                                if (!int.TryParse(oneCommand[3], out right))
                                {
                                    right = variable(oneCommand[3]);
                                }
                                else
                                {
                                    int.TryParse(oneCommand[3], out right);
                                }
                                condition = oneCommand[2];
                                Ifcheck(left, condition, right);
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
                                errMsg = errMsg + "Invalid number of parameters for square " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                int side;
                                string sideParameter = oneCommand[j + 1].Trim();

                                // Check if the side parameter is a variable name
                                if (variables.ContainsKey(sideParameter))
                                {
                                    // If it's a variable, retrieve its value
                                    if (!int.TryParse(variables[sideParameter], out side))
                                    {
                                        // If the variable value is not a valid integer, display an error message
                                        errMsg = errMsg + "Invalid value for variable " + sideParameter + "\n";
                                        runFlg = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    // If it's not a variable, try parsing it as an integer
                                    if (!int.TryParse(sideParameter, out side))
                                    {
                                        // If parsing fails, display an error message
                                        errMsg = errMsg + "Invalid side length value: " + sideParameter + "\n";
                                        runFlg = false;
                                        break;
                                    }
                                }

                                // If no errors occurred, proceed to draw the square
                                if (runFlg)
                                {
                                    // Draw the square using the provided or variable side length
                                    DrawSquare(side);
                                }
                            }
                        }

                        else if (oneCommand[j].ToString().Trim().Equals("var"))
                        {
                            if (oneCommand.Length != 3)
                            {
                                errMsg = errMsg + "Invalid number of arguments at command " + (i + 1).ToString() + "!\n";
                                runFlg = false;
                            }
                            else
                            {
                                VariableCheck(oneCommand[1], oneCommand[2]);
                            }
                        }

                        else if (oneCommand[j].ToString().Trim().Equals("designrect"))
                        {
                            if (oneCommand.Count() != 3)
                            {
                                errMsg = errMsg + "Invalid number of parameters for designrect " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                int width, height;
                                string widthParameter = oneCommand[j + 1].Trim();
                                string heightParameter = oneCommand[j + 2].Trim();

                                // Check if the width and height parameters are variable names
                                if (variables.ContainsKey(widthParameter) && variables.ContainsKey(heightParameter))
                                {
                                    // If they are variables, retrieve their values
                                    if (!int.TryParse(variables[widthParameter], out width) || !int.TryParse(variables[heightParameter], out height))
                                    {
                                        // If any variable value is not a valid integer, display an error message
                                        errMsg = errMsg + "Invalid value for variable(s) in designrect parameters\n";
                                        runFlg = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    // If they are not variables, try parsing them as integers
                                    if (!int.TryParse(widthParameter, out width) || !int.TryParse(heightParameter, out height))
                                    {
                                        // If parsing fails, display an error message
                                        errMsg = errMsg + "Invalid width or height value(s) for designrect\n";
                                        runFlg = false;
                                        break;
                                    }
                                }

                                // If no errors occurred, proceed to draw the rectangle
                                if (runFlg)
                                {
                                    // Draw the rectangle using the provided or variable width and height
                                    DrawRect(width, height);
                                }
                            }
                        }


                        else if (oneCommand[j].ToString().Trim().Equals("designtriangle"))
                        {
                            if (oneCommand.Count() != 4)
                            {
                                errMsg = errMsg + "Invalid number of parameters for triangle " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                int side1, side2, side3;
                                string side1Parameter = oneCommand[j + 1].Trim();
                                string side2Parameter = oneCommand[j + 2].Trim();
                                string side3Parameter = oneCommand[j + 3].Trim();

                                // Check if the side parameters are variable names
                                if (variables.ContainsKey(side1Parameter) && variables.ContainsKey(side2Parameter) && variables.ContainsKey(side3Parameter))
                                {
                                    // If they are variables, retrieve their values
                                    if (!int.TryParse(variables[side1Parameter], out side1) || !int.TryParse(variables[side2Parameter], out side2) || !int.TryParse(variables[side3Parameter], out side3))
                                    {
                                        // If any variable value is not a valid integer, display an error message
                                        errMsg = errMsg + "Invalid value for variable(s) in triangle parameters\n";
                                        runFlg = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    // If they are not variables, try parsing them as integers
                                    if (!int.TryParse(side1Parameter, out side1) || !int.TryParse(side2Parameter, out side2) || !int.TryParse(side3Parameter, out side3))
                                    {
                                        // If parsing fails, display an error message
                                        errMsg = errMsg + "Invalid triangle side length value(s)\n";
                                        runFlg = false;
                                        break;
                                    }
                                }

                                // If no errors occurred, proceed to draw the triangle
                                if (runFlg)
                                {
                                    // Draw the triangle using the provided or variable side lengths
                                    DrawTriangle(side1, side2, side3);
                                }
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
            int[] Split = new int[100];
            string[] parameter = new string[100];
            int i = 0;
            int number = -1;
            while (99 >= i)
            {
                if (parameter[i] == variable)
                {

                    number = Split[i];
                    i = 50;
                }
                else
                {
                    i++;
                }

            }
            if (number == 0)
            {
                MessageBox.Show("not a variable", "error");
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
        private bool Ifcheck(int left, string condition, int right)
        {
            bool ifrslt = false; // Initialize the result variable

            // Use if-else statements to perform the comparison based on the condition
            if (condition == "=")
            {
                ifrslt = (left == right);
            }
            else if (condition == ">")
            {
                ifrslt = (left > right);
            }
            else if (condition == "<")
            {
                ifrslt = (left < right);
            }
            else if (condition == "!")
            {
                ifrslt = (left != right);
            }
            else
            {
                // Display error message for invalid condition
                MessageBox.Show("Condition is not correct, please check", "Error");
            }

            return ifrslt; // Return the result
        }
        static Dictionary<string, string> variables = new Dictionary<string, string>();
        private void VariableCheck(string element1, string element2)
        {
            int[] Split = new int[50];
            string[] parameter = new string[50];
            try
            {
                bool variableExists = false;

                // Check if the variable already exists
                if (variables.ContainsKey(element1))
                {
                    variableExists = true;
                }

                if (variableExists)
                {
                    MessageBox.Show("Variable already declared", "Error");
                }
                else
                {
                    variables[element1] = element2; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

    }
}
