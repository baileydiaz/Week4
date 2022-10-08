// See https://aka.ms/new-console-template for more information 


class Program{
    static void Main(string[] args){
        string keep_playing = "y";
        Score running_score = new Score();
        Deck deckOfCards = new Deck();
        int old_card = deckOfCards.pull_random_card();
        while ((running_score.score > 0) && (keep_playing == "y")){
            Console.WriteLine($"The card is {old_card}");

            Console.WriteLine("Higher or Lower (h/l): ");
            string? user_guess = Console.ReadLine();

            int new_card = deckOfCards.pull_random_card();
            Console.WriteLine($"The card was: {new_card}");    

            running_score.score = running_score.calculate_score(user_guess, old_card, new_card);
            Console.WriteLine($"You score is: {running_score.score}");
            old_card = new_card;

            Console.WriteLine("Would you like to keep playing? [y/n]");
            keep_playing = Console.ReadLine();
        }
}}     
    