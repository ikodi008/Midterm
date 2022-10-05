using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//code used from labs 2 

public class MileagePoints : MonoBehaviour
{

    private void OnCollisionEnter(Collision Mile)
    {
        if (Mile.collider.tag == "Player")
        {
            MilelageCount.instance.Mileschange(1);  
            Destroy(gameObject);
        }
    }
}
