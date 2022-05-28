using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    /// <summary>
    /// direct the game
    /// </sumary>
    public class Director
    {
        public Word word = new Word();
        private Jumper jumper = new Jumper();
        private TerminalService terminalService = new TerminalService();
        private List<char> guessed = new List<char>();
        private bool isPLaying = true;
        public char guess;
        /// <summary>
        /// constructs a new instance of director
        /// </summary>
        public Director()
        {
        }
        ///<summary>
        /// start the game
        /// </summary>
        public void StartGame()
        {
            while (isPLaying)
            {
                DoOutputs();
                GetInputs();
                while (guessed.Contains(guess))
                {
                    terminalService.WriteText($"You have already guess this, try a different one.");
                    GetInputs();
                }
                DoUpdates(guess);
            }
        }

        /// <summary>
        /// get the user input
        /// </summary>
        private void GetInputs()
        {
            string userInput = terminalService.ReadText("\nGuess a letter [a-z]: ");
            char[] guessA = userInput.ToCharArray();
            guess = guessA[0];
        }
        /// <summary>
        /// update the jumper
        /// </summary>
        private void DoUpdates(char guess)
        {
            // add the gues to the list of guessed words
            guessed.Add(guess);
            jumper.UpdateJumper(guess, word.answer);
            word.UpdateWord(guess);

            // if the word is done, end the game
            if (word.isWon())
            {
                endGame();
                terminalService.WriteText("\nYou won the game!");
            }

            // otherwise end the game
            else if (jumper.isLost())
            {
                endGame();
                terminalService.WriteText("\nYou lost :(");
            }
        }

        /// <summary>
        /// display the currrent jumper and word
        /// </summmary>
        private void DoOutputs()
        {
            jumper.DisplayJumper();
            word.DisplayWord();
        }

        /// <summary>
        /// end the game
        /// </summmary>
        private void endGame()
        {
            isPLaying = false;
            jumper.DisplayJumper();
            word.DisplayWord();
        }
    }
}