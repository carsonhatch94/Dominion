namespace Dominion
{
    public class Card
    {
        public Card(string name, int cost, CardType[] type, CardFunction[] function, Expansion expansion)
        {
            Name = name;
            Cost = cost;
            Type = type;
            Function = function;
            Expansion = expansion;
        }
        public string Name { get; set; }
        public int Cost { get; set; }
        public CardType[] Type { get; set; }
        public CardFunction[] Function { get; set; }
        public Expansion Expansion { get; set; }
    }
    
    public enum CardType 
    {
        Action,
        Attack,
        Reaction,
        Victory
    }

    public enum CardFunction
    {
        Trasher,
        Sifter,
        Immunity,
        TerminalDraw,
        TerminalSilver,
        HandsizeAttack
    }

    public enum Expansion
    {
        Base
    }
}