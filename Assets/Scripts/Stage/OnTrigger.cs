using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //当たった時に呼ばれる
    void OnTriggerEnter2D(Collider2D other) 
    {
		if (other.gameObject.tag == "tool")
		{
			Destroy (gameObject);

			Debug.Log("ToolHit");
            Debug.Log("GaugeUp");
		}
    }

}
