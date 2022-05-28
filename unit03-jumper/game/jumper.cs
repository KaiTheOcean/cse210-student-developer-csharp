using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    /// <summary>
    /// Creat the jumper and change it based on the 
    /// user input
    /// </summary>
    public class Jumper 
    {
        private List<string> jumper = new List<string>();

        public Jumper()
        {
            jumper.Add(@"  ___  ");
            jumper.Add(@" /   \ ");
            jumper.Add(@"/_____\");
            jumper.Add(@"\     /");
            jumper.Add(@" \   / ");
            jumper.Add(@"  \ / ");
            jumper.Add(@"   o   ");
            jumper.Add(@"  /|\  ");
            jumper.Add(@"  / \  ");
        }

    
        /// <summary>
        /// display the current progress with the jumper
        /// </summary>
        public void DisplayJumper()
        {
            string jump = string.Join("\n", jumper);
            Console.WriteLine(jump);
        }
        /// <summary>
        /// update the jumper based on the user input
        /// </summary>
        public void UpdateJumper(char guess, string answer)
        {
            if (answer.Contains(guess))
            {
                return;
            }
            else
            {
                jumper.RemoveAt(0);
            }
        }
        /// <summary>
        /// if not jumper, then end the game.
        /// </summary>
        public bool isLost()
        {
            if (jumper.Count <= 3)
            {
                jumper[0] = "   x";
                return true;
            }
            else{
                return false;
            }
        }
    }
}