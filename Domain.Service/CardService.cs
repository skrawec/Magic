using Magic.Domain;
using System;
using System.Collections.Generic;

namespace Domain.Service
{
    public class CardService
    {

        public CardService()
        {
            //initiate data source
        }

        public List<Card> GetCards()
        {
            //get cards
            return new List<Card>();
        }

        public List<Card> GetCards(int cardId)
        {
            //get specific card
            return new List<Card>();
        }

        public void RemoveCard(int cardId)
        {
            //remove card
        }

        public void UpdateCard(Card card)
        {
            //update existing card with card
        }

        public void CreateCard(Card card)
        {
            //add new card
        }
    }
}
