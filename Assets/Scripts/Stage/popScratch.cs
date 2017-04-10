using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popScratchh : MonoBehaviour
{
    GameObject scratch;

	// Use this for initialization
	void Start ()
    {
        scratch = GameObject.FindGameObjectWithTag("scratch");	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(gameObject.active == false)
        {

        }	
	}
}
