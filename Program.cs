﻿// See https://aka.ms/new-console-template for more information 


class Program{
    static void Main(string[] args){
        string x = "yes";
        int score = 1;
        Score running_score = new Score();
        while ((score > 0) && (x == "yes")){

            Deck deckOfCards = new Deck();
            newCard = deckOfCards.pull_random_card();
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
    

    public int calculate_score(int current_score, string user_guess, int old_card){
        new_card = deck.DrawRandomCard();
        if (new_card == old_card){
           return current_score
        }   

        else if (user_guess == "h"){
            if(new_card > old_card){
                return Score += 100;
                }
                else{
                    return curren_score -= 75;
            }}
        }

        else{
            if(new_card < old_card){
                return current_score += 100;
                else{
                return current_score -= 75;
                }
            }
        }


    }
}