﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DrawingEnvironment
{
    public class Parser
    {
        List<string> commands = new List<string>();
        /// <summary>
        /// This method takes a string and separates the elements by spacing.
        /// </summary>
        /// <param name="command"> it is the string to split by spacing</param>
        public List<string> spaceParser(string command)
        {
            List<string> commands = new List<string>();
            string[] commandArray = command.ToUpper().Split(' ');
            foreach (var word in commandArray)
            {
                commands.Add(word);
            }
            return commands;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public bool ValidateCommand(string userInput)
        {
            var cmd = userInput.ToUpper().Split(' ');
            
            var validCommand = Enum.GetNames(typeof(Command.Commands));
            var validShape = Enum.GetNames(typeof(Shape.Shapes));
            
            if (cmd.Length > 3 || !validShape.Contains(cmd[0]) || !validCommand.Contains(cmd[0]))
            {
                MessageBox.Show("Enter a valid command");
                return false;
            }
            else { return true; }
        }  

        // Constructor

        public Parser()
        {
            List<string> commands = this.commands;
        }


    }


}
