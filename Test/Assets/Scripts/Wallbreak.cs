using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallbreak : MonoBehaviour
{
    public int MaxWalllife = 5;
    public int CurrentWallLife;
    // Start is called before the first frame update
    void Start()
    {
        CurrentWallLife = MaxWalllife;
    }

    void OnCollisionEnter(Collision Test)
    {
        if (Test.gameObject.tag == "bullet")
        {
            CurrentWallLife = CurrentWallLife - 1;

            if (CurrentWallLife <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
