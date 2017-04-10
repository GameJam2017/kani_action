using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == "item")
            {
                Destroy(gameObject);
                Debug.Log("Hititem");
            }

            if(collision.gameObject.tag == "virus")
        {
           
        }
    }
}
