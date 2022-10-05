using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    private void OnCollisionEnter(Collision HC)
    {
        if (HC.collider.tag == "Player")
        {
            if (ScoreManager.instance.Chealth < 5)
            {
                ScoreManager.instance.GHealth(1);
                Destroy(gameObject);
            }

        }
    }
}
