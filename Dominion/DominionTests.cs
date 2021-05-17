using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Dominion
{
    public class DominionTests
    {
        private Dominion kingdomCards;

        [SetUp]
        public void Setup()
        {
            kingdomCards = new Dominion();
        }

        [Test]
        public void Can_return_single_card()
        {
            var result = kingdomCards.CardsToUse(new List<int>{1});
            
            Assert.That(result.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void Can_return_two_cards()
        {
            var result = kingdomCards.CardsToUse(new List<int>{1,2});
            
            Assert.That(result.Count, Is.EqualTo(2));
        }
        
        [Test]
        public void Can_return_all_card_parts()
        {
            var result = kingdomCards.CardsToUse(new List<int>{1});
            
            Assert.That(result[0].Name, Is.EqualTo("Chapel"));
            Assert.That(result[0].Cost, Is.EqualTo(2));
            Assert.That(result[0].Type, Is.EqualTo(new[] {CardType.Action}));
            Assert.That(result[0].Function, Is.EqualTo(new[] {CardFunction.Trasher}));
            Assert.That(result[0].Expansion, Is.EqualTo(Expansion.Base));
        }
        
        [Test]
        public void Can_exclude_a_single_card_type()
        {
            var kingdomParameters = kingdomCards.CardRandomizer(3, new List<CardType> {CardType.Attack}, null);
            var result = kingdomCards.CardsToUse(kingdomParameters);
            var cardToExcludeIsPresent = false;
            foreach (var card in result)
            {
                if (card.Type.Contains(CardType.Attack))
                {
                    cardToExcludeIsPresent = true;
                }
            }

            Assert.That(cardToExcludeIsPresent, Is.False);
        }
        
        [Test]
        public void Can_guarantee_a_single_card_type()
        {
            var kingdomParameters = kingdomCards.CardRandomizer(3, null, new List<CardType> {CardType.Attack});
            var result = kingdomCards.CardsToUse(kingdomParameters);
            var cardToIncludeIsPresent = false;
            foreach (var card in result)
            {
                if (card.Type.Contains(CardType.Attack))
                {
                    cardToIncludeIsPresent = true;
                }
            }

            Assert.That(cardToIncludeIsPresent, Is.True);
        }
    }
}