class Deck {

    List<int> GetNumbers(int start, int end)
    {
        List<int> list = new List<int>();
        for (int i = start; i < end; i++)
            list.Add(i);
        return list;
    }
}