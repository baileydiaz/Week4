class Score
{
    int initial_score = 300;
    public Score(){
    }

    public int calculate_score(int current_score, string user_guess, int old_card, int new_card){
    
        if (new_card == old_card){
           return current_score;
        }   

        else if (user_guess == "h"){
            if(new_card > old_card){
                return current_score += 100;
                }
                else{
                    return current_score -= 75;
            }}
        

        else{
            if(new_card < old_card){
                return current_score += 100;}
                else{
                    return current_score -= 75;
                }
            }
        }
}

// 