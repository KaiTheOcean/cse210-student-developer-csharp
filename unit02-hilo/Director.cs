using System;
using System.Collections.Generic;

namespace unit02_hilo
{

    public class Director 
    {
        bool isPlaying = true;
        int point = 0; 
        int totalPoints = 300;
        string guess = " ";
        public Director()
        {
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                GetOutputs();
            }
        }
        public void GetInputs()
        {   
            Card card1 = new Card();
            Card card2 = new Card(); 
            Console.WriteLine();
            Console.Write($"The card is: {card1.value}. ");
            Console.WriteLine();
            Console.Write("Higher or Lower? [h/l] ");
            guess = Console.ReadLine();
            Console.Write($"The new card is: {card2.value}. ");
            if (guess ==  "h" && card2.value >= card1.value)
            {
                totalPoints += 100;
            }
            else if (guess == "l" && card2.value <= card1.value)
            {
                totalPoints += 100;
            }
            else
            {
                totalPoints -= 75;
            }

        }
        public void GetOutputs()
        {
            Console.WriteLine();
            Console.Write($"The score is: {totalPoints}. ");
            Console.WriteLine();
            Console.Write($"Do you want to play again? [y/n] ");
            string playAgain = Console.ReadLine();
            if (playAgain == "n")
            {
                isPlaying = false;
            }
            if (totalPoints <= 0)
            {
                Console.Write("Game over!!!");
                isPlaying = false;
            }
        }
    }
}