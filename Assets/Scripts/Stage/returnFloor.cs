using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnFloor : MonoBehaviour
{
    Vector3 scale;
    Vector3 scaleDown;

	// Use this for initialization
	void Start () {
        scale = gameObject.transform.localScale;
        scaleDown.y = 0.01f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //床の大きさyが保存したy以上だったら
		if(gameObject.transform.localScale.y > scale.y)
        {
            gameObject.transform.localScale -= scaleDown;
        }
	}
}
