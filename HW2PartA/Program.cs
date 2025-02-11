﻿using System;
using Cards2;

// loop while there's more input

while(Console.ReadLine() != "") {

    // Add your code between this comment
    // and the comment below. You can of
    // course add more space between the
    // comments as needed
    
    
    // declare a deck variables and create a deck object
    // DON'T SHUFFLE THE DECK   

    Deck deck = new();

    // deal 2 cards each to 4 players (deal properly, dealing
    // the first card to each player before dealing the
    // second card to each player)

    List<Card> player1 = [];
    List<Card> player2 = [];
    List<Card> player3 = [];
    List<Card> player4 = [];
    List<List<Card>> players = [player1,player2,player3,player4];

    for(int i = 0; i < 2; i++) {
        foreach(List<Card> p in players) {
            p.Add(deck.TakeTopCard());
        }
    }

    // deal 1 more card to players 2 and 3

    for(int i = 0; i < 2; i++) {
        players[i+1].Add(deck.TakeTopCard());
    }

    // flip all the cards over

    foreach(List<Card> p in players) {
        foreach(Card c in p) {
            c.FlipOver();
        }
    }

    // print the cards for player 1
    // print the cards for player 2
    // print the cards for player 3
    // print the cards for player 4

    for(int i = 0; i < 4; i++) {
        Console.WriteLine($"Player #{i+1}'s cards:");
        foreach(Card c in players[i]) {
            Console.Write(c.Rank + " of " + c.Suit + "; ");
        }
        Console.WriteLine();
    }

}


