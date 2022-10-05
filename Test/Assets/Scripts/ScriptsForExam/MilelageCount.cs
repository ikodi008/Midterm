using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code used from labs 2 

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
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mileschange(int MilesCount)
    {
        mcount += MilesCount;
        if(mcount==4)
        {
            
        }
    }
}
