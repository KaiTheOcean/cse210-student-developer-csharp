using System;
using System.Collections.Generic;
namespace Unit04.Game.Casting
{
    // TODO: Implement the Artifact class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Actor class.

        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>
    public class Artifact : Actor
    {
        private int points;
    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {
            Random num = new Random();
            points = num.Next(-1, 2);
            while (points != 1 && points != -1)
            {
                points = num.Next(-1 ,2);
            }
        }
    // 3) Create the GetScore() method. Use the following method comment.
        
        /// <summary>
        /// Gets the artifact's score.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public int GetPoints()
        {
            return points;
        }
    }   
}