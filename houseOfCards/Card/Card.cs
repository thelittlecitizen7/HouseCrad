using houseOfCards.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace houseOfCards.Card
{
    public class Card
    {
        public int CardNumber { get; set; }

        public CardColor CardColor { get; set; }

        public Card(int cardNumber , CardColor color)
        {
            CardNumber = cardNumber;
            CardColor = color;
        } 

        
    }
}
