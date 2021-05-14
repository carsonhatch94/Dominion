using System.Collections.Generic;

namespace Dominion
{
    public class AllCards
    {
        public static IDictionary<int, Card> allCards = new Dictionary<int, Card>
        {
            {1, new Card("Chapel", 2, new [] {CardType.Action}, new [] {CardFunction.Trasher}, Expansion.Base)},
            {2, new Card("Cellar", 2, new [] {CardType.Action}, new [] {CardFunction.Sifter}, Expansion.Base)},
            {3, new Card("Moat", 2, new [] {CardType.Action, CardType.Reaction}, new [] {CardFunction.Immunity, CardFunction.TerminalDraw}, Expansion.Base)},
            {4, new Card("Militia", 4, new [] {CardType.Action, CardType.Attack}, new [] {CardFunction.HandsizeAttack, CardFunction.TerminalSilver}, Expansion.Base)},
        };
    }
}