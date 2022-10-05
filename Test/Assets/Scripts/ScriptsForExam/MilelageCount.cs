using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code used from labs 2 
//models are from website provided by TA

public class MilelageCount : MonoBehaviour
{
    public static MilelageCount instance;

    int mcount;

  
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mileschange(int MilesCount)
    {
        mcount += MilesCount;
        if(mcount==4)
        {
            Camera.main.backgroundColor = new Color(0f, 0.2f, 0.4f);
        }
    }

    void OnGUI()
    {
        {
            GUI.Label(new Rect(30, 10, 100, 100), "MILES: " + mcount);
        }
    }
}
