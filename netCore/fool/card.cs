using System;
namespace fool{
    public class Card{
        public string stringSuit {get; set;} 
        public string stringValue {get; set;}
        public int Suit {get; set;}
        public int Value {get; set;}
        public Card(int suit, int value){
            Suit = suit;
            Value = value;
            if(suit == 0){
                stringSuit = "hearts";
            }
            else if(suit == 1){
                stringSuit = "diamonds";
            }
            else if(suit == 2){
                stringSuit = "clubs";
            }
            else if(suit == 3){
                stringSuit = "spades";
            }
            if(value > 1 && value < 11){
                stringValue = value.ToString();
            }
            else if(value == 11){
                stringValue = "jack";
            }
            else if(value == 12){
                stringValue = "queen";
            }
            else if(value == 13){
                stringValue = "king";
            }
            else if(value == 14){
                stringValue = "ace";
            }
        }
    }
}