using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour
{
    private void OnCollisionEnter(Collision G)
    {
        if (G.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore2(1);
            Destroy(gameObject);

        }
    }

}
