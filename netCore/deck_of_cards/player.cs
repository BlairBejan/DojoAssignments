using System;
using System.Collections.Generic;
namespace deck_of_cards{
    public class player{
        public string name;
        public List<card> hand;
        public void drawcard(deck currentdeck){
            hand.Add(currentdeck.deal());
        }
        public card discard(int index){
            card temp = hand[index];
            hand.RemoveAt(index);
            return temp;
        }
    }
}