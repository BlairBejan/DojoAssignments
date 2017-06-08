using System;
using System.Collections.Generic;
namespace fool{
    class Game{
        public Deck gamedeck {get; set;}
        public Player player1 {get; set;}
        public Player player2 {get; set;}
        public List<Card> pile1 {get; set;}
        public List<Card> pile2 {get; set;}
        public List<Card> pile3 {get; set;}
        public List<Card> pile4 {get; set;}
        public List<Card> pile5 {get; set;}
        public List<Card> pile6 {get; set;}
        public Card trumpcard {get; set;}
        public bool turn {get; set;} //true for player1 false for player2
        public Game(){
            gamedeck = new Deck();
            gamedeck.Shuffle();
            player1 = new Player(); 
            player2 = new Player();
            turn = true;
            for (int i = 0; i < 6; i++)
            {
                player1.Draw(gamedeck);
                player2.Draw(gamedeck);
            }
            trumpcard = gamedeck.Deal();
            System.Console.WriteLine("new game created!");
            System.Console.WriteLine("Player1 it is your turn");
            System.Console.WriteLine("Your cards are:");
            for (int i = 0; i < player1.hand.Count; i++)
            {
                System.Console.WriteLine(player1.hand[i].stringValue + " of " + player1.hand[i].stringSuit + " press " + i + " to play");
            }
        }
        public void Turn(Player Player){
            System.Console.WriteLine(Player);
            System.Console.WriteLine("Your cards are:");
            for (int i = 0; i < Player.hand.Count; i++)
            {
                System.Console.WriteLine(Player.hand[i].stringValue + " of " + Player.hand[i].stringSuit + " press " + i + " to play");
            }
            System.Console.WriteLine("press 6 to take, press 7 to discard");

            // make players able to select cards with readline
            // make players able to select what pile they want their played cards to go to

            // validation for wether the played card was valid
            // when card is played in a pile:
            // player.hand.RemoveAtIndex(i) and add card to selected pile {pile x .Add(card)}
            // at end of turn:
            // if turn == True
                // turn = False
            // if turn == False
                // turn = True
            
            // if player entered 6 or 7
                // if 6:
                    // add all cards from all piles to the players hand whose turn it was
                // if 7:
                    // remove all cards from all piles
                // both players draw cards until they have 6 in their hands
        }
    }
}