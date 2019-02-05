using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class high_score : MonoBehaviour
{
    static public int player = 0;
    static public int comp = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Called()
    {

    }

    public void setPlayer()
    {
        player += 100;
        toString();
    }

    public void setComp()
    {
        comp += 100;
        toString();
    }

    public void toString()
    {
        Text gt = this.GetComponent<Text>();
        gt.text += "\nPlayer Score " + player
        + "\nComputer Score " + comp;
    }

    public string finalstring()
    {
        return "\nPlayer Score " + player + "\nComputer Score " + comp;
    }
}
