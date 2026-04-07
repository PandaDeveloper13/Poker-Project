using System;
using GambleTest2;

namespace Cards
{
    public class Card
    {
        public Cardvalue Value;
        public Suit Suit;

        public Card(Cardvalue startValue, Suit startSuit)
        {
            this.Value = startValue;
            this.Suit = startSuit;
        }

        public void PrintMe()
        {
            Console.WriteLine(this.MakeString());
        }

        public string MakeString()
        {
            string valueText;

            switch (this.Value)
            {
                case Cardvalue.J:
                    valueText = "J";
                    break;
                case Cardvalue.Q:
                    valueText = "Q";
                    break;
                case Cardvalue.K:
                    valueText = "K";
                    break;
                case Cardvalue.A:
                    valueText = "A";
                    break;
                default:
                    valueText = ((int)this.Value).ToString();
                    break;
            }

            return valueText + this.Suit.Symbol();
        }
    }
}