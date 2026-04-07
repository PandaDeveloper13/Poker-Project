namespace GambleTest2
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public static class SuitExtensions
    {
        public static string Symbol(this Suit suit)
        {
            return suit switch
            {
                Suit.Clubs => "♣",
                Suit.Diamonds => "♦",
                Suit.Hearts => "♥",
                Suit.Spades => "♠",
                _ => ""
            };
        }
    }
}