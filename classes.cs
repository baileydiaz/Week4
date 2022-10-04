class Score
{
    public Score()
    {
        int intital_score = 300;
        return intital_score;
    }
}

class Deck 
{
    private static Random rng = new Random();  

public static void Shuffle<T>(this IList<T> list)  
{  
    int n = list.Count;  
    while (n > 1) {  
        n--;  
        int k = rng.Next(n + 1);  
        T value = list[k];  
        list[k] = list[n];  
        list[n] = value;  
    }  
}
}