using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Indexeurs
{
    public class Deck
    {
        private List<Card> _cards;

        public Card this[int index]
        {
            get
            {
                return _cards[index];
            }
        }

        public Card this[CardColor color, CardValues value]
        {
            get
            {
                Card c = null;
                foreach(Card card in _cards)
                {
                    if (card.Color == color && card.Value == value) c = card;
                }
                _cards.Remove(c);
                return c;
            }
        }

        public int NbCards
        {
            get
            {
                return (_cards is null)?0:_cards.Count;
            }
        }

        public void InitCards()
        {
            _cards = new List<Card>();
            for (int i = 0; i < 52;i++)
            {
                _cards.Add(new Card() { Value = (CardValues)((i % 13)+2), Color = (CardColor)(i % 4) });
            }
        }
    }
}
