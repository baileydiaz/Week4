class Deck {
    List<int>Cards = new List<int>();
    public Deck(){
        for (int i = 1; i < 14; i++)
            Cards.Add(i);
    }

    Random generator = new Random();
    public int pull_random_card(){ 
        int randIndex = generator.Next(Cards.Count);
        int card_used = Cards[randIndex];
        Cards.RemoveAt(randIndex);
        return card_used;
    }  
}
