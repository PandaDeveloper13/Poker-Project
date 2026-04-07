using System;
using System.Text;
using Cards;

namespace GambleTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Hello World!");
            
            Card test = new Card(Cardvalue.Five, Suit.Hearts);
            test.PrintMe();

            Console.OutputEncoding = Encoding.UTF8;

            Deck deck = new Deck();
            deck.Shuffle();

            Console.WriteLine("Aantal kaarten in deck: " + deck.Count());

            Deck Deck = new Deck();
            Deck.Shuffle();

            List<Card> playerHand = Deck.TakeFiveCards();

            Console.WriteLine("Player took these 5 cards:");
            Deck.ShowCards(playerHand);
            Deck.Shuffle();
            Console.WriteLine("Cards left in deck: " + Deck.Count());
            Console.WriteLine("Aantal genomen kaarten: " + Deck.TakenCount());
            Deck.ShowCards(playerHand);

            Deck deck2 = new Deck();
            deck2.Shuffle();
            List<Card> Hand = deck2.TakeFiveCards();
            deck2.ShowCards(Hand);
            
            Console.WriteLine("Cards left in deck: " + deck2.Count());
            Console.WriteLine("Aantal genomen kaarten: " + deck2.TakenCount());
            deck2.Reset(Hand);
            deck2.ShowCards(Hand);
            Console.WriteLine(deck2.TotalCardCount());
            Console.WriteLine("Cards left in deck: " + deck2.Count());
            Console.WriteLine("Aantal genomen kaarten: " + deck2.TakenCount());
            deck2.Shuffle();
            List<Card> Cheese = deck2.TakeFiveCards();
            deck2.ShowCards(Cheese);
        }
    }
}

            