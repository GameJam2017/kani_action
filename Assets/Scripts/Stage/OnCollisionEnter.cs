using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "virus")
        {
            Debug.Log("HitPotison >>>>");
            Debug.Log(coll.transform.position);
        }
    }
    
}
