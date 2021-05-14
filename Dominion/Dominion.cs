using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Dominion.CardFunction;
using static Dominion.Expansion;

namespace Dominion
{
    class Dominion
    {
        public List<Card> CardsToUse(List<int> cardNumbers, List<CardType> typesToExclude)
        {
            var kingdom = new List<Card>();
            foreach (var number in cardNumbers)
            {
                kingdom.Add(AllCards.allCards[number]);
            }

            if (typesToExclude != null)
            {
                kingdom.RemoveAll(x => x.Type.Contains(typesToExclude[0]));
            }

            return kingdom;
        }
    }
    
}