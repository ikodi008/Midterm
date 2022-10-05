using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    private void OnCollisionEnter(Collision GT)
    {
        if (GT.collider.tag == "Player")
        {
            Application.LoadLevel(0);

        }
    }
}
