﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AseProgramingLanguage1
{
    public class SynthaxCommand
    {
        public string line { get; }

        public SynthaxCommand(string line)
        {
            this.line = line;
        }

        public void SynthaxCheck(string line)
        {
            //ParseCommand parse = new ParseCommand(line);
            //string line = "circle 40";
            //string linee;
            string[] split;
            string[] parameters;
            line = line.ToLower().Trim();
            split = line.Split(' ');
            string command;
            command = split[0];

            if (command.Equals("clear") || command.Equals("reset") || command.Equals("run"))
            {
                
                
                if (split.Length == 1)
                { command = split[0]; }
                //else throw new ArgumentOutOfRangeException("this command has no parameters");

            }

            else
            if (command.Equals("rectangle"))
            {
                if (split.Length == 2)
                {
                    parameters = split[1].Split(',');
                    if (parameters.Length == 2)
                    {
                        bool res1 = int.TryParse(parameters[0], out int r1);
                        bool res2 = int.TryParse(parameters[1], out int r2);
                        if (res1)
                        {
                            int width = Int32.Parse(parameters[0]);
                            if (res2)
                            {
                                int heigth = Int32.Parse(parameters[1]);
                            }
                            else throw new ArgumentOutOfRangeException("parameter 2 should be number");

                        }
                        else throw new ArgumentOutOfRangeException("parameter 1 should be number");
                    }
                    else throw new ArgumentOutOfRangeException("you need to input a width and a heigth ");

                }
                else throw new ArgumentOutOfRangeException("you need to input a width and a heigth sperated with a comma");
                

               // string param1 = parameters[0];
               // string param2 = parameters[1];
                //bool res;
                //int r;
                
            }
            else if (command.Equals("circle"))
            {
                bool res = int.TryParse(split[1], out int r);
                if (res)
                { int radius = Int32.Parse(split[1]); 
                }
                else throw new ArgumentOutOfRangeException("radius should be a number");

            }
            else if (command.Equals("moveto") || command.Equals("drawto"))
            {
                parameters = split[1].Split(',');
                bool res1 = int.TryParse(parameters[0], out int r1);
                bool res2 = int.TryParse(parameters[1], out int r2);
                if (res1)
                {
                    int x = Int32.Parse(parameters[0]);
                    if (res2)
                    {
                        int y = Int32.Parse(parameters[1]);
                    }
                    else throw new ArgumentOutOfRangeException("parameter 2 should be number");

                }
                else throw new ArgumentOutOfRangeException("parameter 1 should be number");


            }
            else if (command.Equals("triangle"))
            {
                parameters = split[1].Split(',');
                bool res1 = int.TryParse(parameters[0], out int r1);
                bool res2 = int.TryParse(parameters[1], out int r2);
                bool res3 = int.TryParse(parameters[2], out int r3);
                bool res4 = int.TryParse(parameters[3], out int r4);
                if (res1)
                {
                    int x = Int32.Parse(parameters[0]);
                    if (res2)
                    {
                        int y = Int32.Parse(parameters[1]);
                        if (res3)
                        { int z = Int32.Parse(parameters[2]);
                            if (res4)
                            { int w = Int32.Parse(parameters[3]); }
                            else throw new ArgumentOutOfRangeException("parameter 4 should be number");
                        }
                        else throw new ArgumentOutOfRangeException("parameter 3 should be number");
                    }
                    else throw new ArgumentOutOfRangeException("parameter 2 should be number");

                }
                else throw new ArgumentOutOfRangeException("parameter 1 should be number");
              
               
                
            }
            else if (command.Equals("drawcolor") || command.Equals("fillcolor"))
            {
                /* can be used for second part to add other colors
                object[] colors = { "black", "red", "blue", "green" };
                for (int i=0;i<=colors.Length; i++)
                {}
                */
                if (split[1].Equals("black") || split[1].Equals("red") || split[1].Equals("blue") || split[1].Equals("green"))

                {
                    string param5 = split[1];
                }
                else throw new ArgumentOutOfRangeException("Unknown color name");
               
            }
            else if(command.Equals("fill"))
            {
                    if (split[1].Equals("on") || split[1].Equals("off"))
                    {
                        string param5 = split[1];
                    }
                    else throw new ArgumentOutOfRangeException("Unknown fill setting");
            }
            else  throw new ArgumentOutOfRangeException("Unknown command");

        }
    }
}