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
                for(int i = 0;i < _cards.Count && c is null; i++)
                {
                    if (_cards[i].Color == color && _cards[i].Value == value) c = _cards[i];
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
