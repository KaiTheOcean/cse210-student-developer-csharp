using System;


namespace unit02_hilo
{
    public class Card
    {
        public int value = 0;
        public Card()
        {
            Random random = new Random();
            value = random.Next(1,14);
        }
    }
}
