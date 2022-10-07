// See https://aka.ms/new-console-template for more information 


class Program{
    static void Main(string[] args){
        string x = "yes";
        Score running_score = new Score();
        Deck deckOfCards = new Deck();
        int old_card = deckOfCards.pull_random_card();
        while ((running_score.score > 0) && (x == "yes")){
            Console.Write($"The card is {old_card}");

            Console.Write("Higher or Lower (h/l): ");
            string? user_guess = Console.ReadLine();

            int new_card = deckOfCards.pull_random_card();
            Console.Write($"Next card was: {new_card}");    

            Console.Write($"You score is: {running_score.score}");
            old_card = new_card;

            Console.Write("[y/n]");
            string? keep_going_user = Console.ReadLine();
        }
}}     
    