using Poker.Model;
using System;
using System.Collections.Generic;

public class Player
{
    public Player(int id, string name, List<Card> hand, List<Chips> chips)
    {
        Id = id;
        Name = name;
        Hand = hand;
        Chips = chips;
    }

    public int Id { get; set; }
	public string Name { get; set; }
	public List<Card> Hand { get; set; }
	public List<Chips> Chips { get; set; }
    public bool IsSmallBlind { get; set; }
    public bool IsBigBlind { get; set; }
    public bool IsDealer { get; set; }



}
