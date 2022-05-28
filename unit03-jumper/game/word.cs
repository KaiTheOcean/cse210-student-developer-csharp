using System;
using System.Collections.Generic;
using System.IO;

namespace unit03_jumper
{
    /// <summary>
    /// In this class, we wil creat a new answer,
    /// display the word, the blank word, and update 
    /// the word based on the user's guess
    /// </summary>
    public class Word
    {
        public List<char> word = new List<char>();
        public string answer;

        /// <summary>
        /// Constructs a new instance of word. 
        /// </summary>
        public Word()
        {
            Random random = new Random();
            // Pick a random word from the list
            List<string> randomWord = new List<string>(File.ReadLines("words.txt"));
            int randomIndex = random.Next(0, randomWord.Count);
            answer = randomWord[randomIndex];

            // initiate the word with blanks 
            foreach(char i in answer)
            {
                word.Add('_');
            }
        }

        /// <summary>
        /// Updates and dispays the progress the word
        /// </summary>
        public void DisplayWord()
        {
            foreach(char i in word)
            {
                Console.Write($"{i}");
            }
        }

        /// <summary>
        /// Check the input is part of the answer or not 
        /// if it is, then update the word.
        /// </summary>
        public void UpdateWord(char guess)
        {
            int i = 0;
            foreach(char a in answer)
            {
                if (a == guess)
                {
                    word[i] = guess;
                }
                i += 1;
            }
        }

        /// <summary>
        /// check to see if the word is finished
        /// </summary>
        public bool isWon()
        {
            foreach(char a in word)
            {
                if (a == '_')
                {
                    return false;
                }
            }
            return true;
        }
    }
}