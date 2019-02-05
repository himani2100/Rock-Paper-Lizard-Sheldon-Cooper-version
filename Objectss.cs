using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum Choice { Rock, Paper, Scissors, Lizard, Spock }

public class Objectss : MonoBehaviour
{
    public Choice draw = 0;
    public Choice win = 0;
    public Choice win2 = 0;
    public Computer choice;
    public Text score;
    public static high_score temp;

    public static int comp_wins = 0;
    public static int user_wins = 0;
    public static int rounds = 0;
    // Start is called before the first frame update
    void Start()
    {
        temp = score.GetComponent<high_score>();
        /*
         * 1 : Rock
         * 2 : Scissor
         * 3 : Paper
         * 4 : Spock
         * 5 : Lizard       
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        choice.onCall();

        if (choice.comp_choice == draw)
        {
            score.text = "It's a tie, choose again";
            temp.toString();
        }

        else if (choice.comp_choice == win || choice.comp_choice == win2)
        {
            score.text = "You win!";
            temp.setPlayer();
            user_wins++;
            rounds++;
        }

        else
        {
            score.text = "Computer choice : " + choice.str + "\n Computer Wins";
            temp.setComp();
            comp_wins++;
            rounds++;
        }

        rounds_count();
    }

    void rounds_count()
    {
        if (rounds == 10)
        {
            if (comp_wins > user_wins)
            {
                score.text = "Computer won the game\n" + temp.finalstring();
            }

            else if (comp_wins < user_wins)
            {
                score.text = "You won the game\n" + temp.finalstring();
            }

            else if(comp_wins == user_wins)
            {
                rounds--;
            }
        }
    }

}
