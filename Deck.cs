class Deck {

    List<int> GetNumbers(int start, int end)
    {
        List<int> Cards = new List<int>();
        for (int i = start; i < end; i++)
            Cards.Add(i);
        return Cards;
    }
    Random generator = new Random();
public int pull_random_card(List<int> Cards){ 
        int randIndex = generator.Next(Cards.Count);
        int card_used = Cards[randIndex];
        Cards.RemoveAt(randIndex);
        return card_used;
    }  
}
