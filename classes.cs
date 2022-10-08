class Score
{
    public int score = 300;
    public Score(){
    }

    public int calculate_score(string user_guess, int old_card, int new_card){
    
        if (new_card == old_card){
           return score;
        }   

        else if (user_guess == "h"){
            if(new_card > old_card){
                return (score += 100);
                }
                else{
                    return (score -= 75);
            }}
        

        else{
            if(new_card < old_card){
                return (score += 100);}
                else{
                    return (score -= 75);
                }
            }
        }
}

// 