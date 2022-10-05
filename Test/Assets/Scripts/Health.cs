using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
  

    // Start is called before the first frame updates

    void OnCollisionEnter(Collision Sp)
        {
        if (Sp.gameObject.tag == "Spheretest")
        {
            ScoreManager.instance.LHealth(1);

        }  

    }


}
