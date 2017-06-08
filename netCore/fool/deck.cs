using System;
using System.Collections.Generic;
namespace fool{
    public class Deck{
        public List<Card> deck {get; set;}
        public Deck(){
            deck = new List<Card>();
            MakeDeck();
        }
        public void MakeDeck(){
            for (int i = 0; i < 4; i++)
            {
                for (int x = 9; x < 15; x++)
                {
                    deck.Add(new Card(i, x));
                }
            }
        }
        public void Shuffle(){
            Random rand = new Random();
            for (int i = 0; i < deck.Count; i++)
            {
                int index1 = rand.Next(0,deck.Count);
                Card temp = deck[index1];
                deck[index1] = deck[i];
                deck[i] = temp;
            }
        }
        public Card Deal(){
            Card returnCard = deck[0];
            deck.RemoveAt(0);
            return returnCard;
        }
        public void Reset(){
            deck = new List<Card>();
            MakeDeck();
        }
    }
}