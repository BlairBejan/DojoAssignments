using System;
using System.Collections.Generic;
namespace fool{
    public class Player{
        public List<Card> hand {get; set;}
        public Player(){
            hand = new List<Card>();
        }
        public Card Draw(Deck Deck){
            Card drawnCard = Deck.Deal();
            hand.Add(drawnCard);
            return drawnCard;
        }
        public Card Play(int index){
            if (index < hand.Count && index >= 0)
            {
                Card temp = hand[index];
                hand.RemoveAt(index);
                return temp;                  
            }
            return null;
        }
    }
}