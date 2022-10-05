using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    int score;

    int gemscore;

    public int Chealth=5;

    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore (int coinvalue)
    {
        score += coinvalue;
    }

    public void ChangeScore2(int Gemvalue)
    {
        gemscore += Gemvalue;     
    }

    public void LHealth(int LHvalue)
    {
        Chealth -= LHvalue;
        
        if(Chealth==0)
        {
            Application.LoadLevel(0);
        }
    }
    public void GHealth(int GHvalue)
    {
       
        if(Chealth<5)
        {
            Chealth += GHvalue;
        }
    }

    void OnGUI()
    {
        {
            GUI.Label(new Rect(30, 10, 100, 100), "Health: " + Chealth);

            GUI.Label(new Rect(30, 50, 100, 100), "Coins: " + score);

            GUI.Label(new Rect(30, 70, 100, 100), "Gems: " + gemscore);

           
        }
    }
}
