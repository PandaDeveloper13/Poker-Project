using System;
using System.Collections.Generic;
using Cards;
using GambleTest2;

namespace GambleTest2
{
    public class Deck
    {
        private List<Card> Cards;
        private List<Card> CardsTaken;
        private static readonly Random rng = new Random();

        public Deck()
        {
            Cards = new List<Card>();
            CardsTaken = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Cardvalue value in Enum.GetValues(typeof(Cardvalue)))
                {
                    Cards.Add(new Card(value, suit));
                }
            }
        }
        public int TotalCardCount()
        {
            return this.Cards.Count + this.CardsTaken.Count;
            
        }

        public int Count()
        {
            return Cards.Count;
        }

        public int TakenCount()
        {
            return CardsTaken.Count;
        }

        public void Shuffle()
        {
            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);

                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }

        public Card TakeCard()
        {
            if (Cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in the deck.");
            }

            Card takenCard = Cards[0];
            Cards.RemoveAt(0);
            CardsTaken.Add(takenCard);

            return takenCard;
        }

        public List<Card> TakeFiveCards()
        {
            if (Cards.Count < 5)
            {
                throw new InvalidOperationException("Not enough cards left to take 5 cards.");
            }

            List<Card> hand = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                hand.Add(TakeCard());
            }

            return hand;
        }

        public void ShowCards(List<Card> hand)
        {
            foreach (Card card in hand)
            {
                Console.WriteLine(card.MakeString());
            }
        }


        public void TakenCards(List<Card> hand)
        {
            foreach (Card card in CardsTaken)
            {
                Console.WriteLine(card.MakeString());
            }
        }
        public void Reset(List<Card> hand) 
        {
            Cards.Clear();
            CardsTaken.Clear();
            hand.Clear();


            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Cardvalue value in Enum.GetValues(typeof(Cardvalue)))
                {
                    Cards.Add(new Card(value, suit));
                }
            }
            
        }
    }
}