using System.Collections.Generic;
using System;
namespace deck_of_cards{
    public class deck{
        private List<card> cards;
        public deck(){
            for (int i = 0; i < 4; i++)
            {
                for (int x = 1; x < 14; x++)
                {
                    cards = new List<card>();
                    cards.Add(new card(i, x));
                }
            }
        }
        public card deal(){
            if (cards.Count > 0){
                card temp = cards[0];
                cards.RemoveAt(0);
            } 
            return null;
        }
        public deck reset(){
            cards.Clear();
            new deck();
            return null;
        }
        public deck shuffle(){
            Random rand = new Random();
            for (int i = 0; i < 300; i++)
            {
                int randomcard1 = rand.Next(0,52);
                int randomcard2 = rand.Next(0,52);
                card temp = cards[randomcard1];
                cards[randomcard1] = cards[randomcard2];
                cards[randomcard2] = temp;
            }
            return null;
        }
    }
}