using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Computer : Objectss
{

    public Choice comp_choice = 0;
    public string str = "";
    // Start is called before the first frame update
    void Start()
    {
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

    public void onCall()
    {
        Random rnd = new Random();
        comp_choice = (Choice)rnd.Next(0, 5);
        toString();
    }

    void toString()
    {
        if (comp_choice == Choice.Rock)
        {
            str = "Rock";
        }

        else if (comp_choice == Choice.Scissors)
        {
            str = "Scissor";
        }

        else if (comp_choice == Choice.Paper)
        {
            str = "Paper";
        }

        else if (comp_choice == Choice.Spock)
        {
            str = "Spock";
        }

        else if (comp_choice == Choice.Lizard)
        {
            str = "Lizard";
        }
    }


}
