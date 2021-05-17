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
        public List<Card> CardsToUse(List<int> cardNumbers)
        {
            var kingdom = new List<Card>();
            foreach (var number in cardNumbers)
            {
                kingdom.Add(AllCards.allCards[number]);
            }

            return kingdom;
        }

        public List<int> CardRandomizer(int quantity, List<CardType> typesToExclude, List<CardType> typesToInclude)
        {
            var random = new Random();
            var cardIds = new List<int>();
            var containsType = false;
            while (cardIds.Count != quantity)
            {
                var idToAdd = 0;
                idToAdd += random.Next(1, 5);
                if (!cardIds.Contains(idToAdd))
                {
                    if (typesToExclude != null)
                    {
                        if (ChooseCardsByType(typesToExclude, idToAdd)) continue;
                    }

                    if (typesToInclude != null)
                    {
                        if (containsType == false)
                        {
                            if (ChooseCardsByType(typesToInclude, idToAdd))
                            {
                                containsType = true;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                    cardIds.Add(idToAdd);
                }
            }

            return cardIds;
        }

        private static bool ChooseCardsByType(List<CardType> types, int idToAdd)
        {
            return types.Any(param => AllCards.allCards[idToAdd].Type.Contains(param));
        }
    }
}