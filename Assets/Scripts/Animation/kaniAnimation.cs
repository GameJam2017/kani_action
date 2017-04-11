using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaniAnimation : MonoBehaviour {

    public Animator animator;
     
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.transform.position = transform.position;

            //アニメーターで動かす
            animator.SetTrigger("OnceAnim");
            
        }
    }
}
