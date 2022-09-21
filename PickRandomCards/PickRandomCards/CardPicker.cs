using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    public class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int NumberOfCards)
        {
            string[] pickedCards = new string[NumberOfCards];

            for (int i = 0; i < NumberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        public static string RandomSuit()
        {
            int value = random.Next(1, 5);

            switch (value)
            {
                case (1):
                    return "Пики";
                    
                case (2):
                    return "Черви";
                    
                case (3):
                    return "Крести";
                    
                default:
                    return "Бубны";
            }
        }
       public static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) return "Туз";
            if (value == 11) return "Валет";
            if (value == 12) return "Дама";
            if (value == 13) return "Король";

            return value.ToString( );
        }
    }
}
