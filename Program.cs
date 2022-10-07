// See https://aka.ms/new-console-template for more information 


class Program{
    static void Main(string[] args){
        string x = "yes";
        int score = 1;
        Score running_score = new Score();
        while ((score > 0) && (x == "yes")){

            Deck deckOfCards = new Deck();

            // pull_random_card = card new pull_random_card();
            Console.Write($"The card is {}");

            Console.Write("Higher or Lower (h/l): ");
            string? user_guess = Console.ReadLine();

            pull_random_card()
            Console.Write($"Next card was: {}");

            calculate_score()
            Console.Write($"You score is: {}");

            Console.Write("[y/n]");
            string? keep_going_user = Console.ReadLine();
        }
    }     
    public int pull_random_card(List<Int>){
        Random rnd = new Random();  
        int randIndex = Random.Next(*deck_list*.Count);
        int random = numbers[randIndex];
        return random_number;
    }   

    public int calculate_score(int current_score, string user_guess, int old_card){
        user the current score
        pull_random_card(decklist);
        if (new_card == old_card){
           return Score
        }   

        else if (user_guess == "h"){
            if(new_card > old_card){
                return Score += 100;
                }
                else{
                    return Score -= 75;
            }}
        }

        else{
            if(new_card < old_card){
                return current_score += 100;
                else{
                    return Score -= 75;
                }
            }
        }


    }
}