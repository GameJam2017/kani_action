using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorOnTrigger : MonoBehaviour {

    Vector3 scale;
    Vector3 scale2;

    // Use this for initialization
    void Start ()
    {
        scale = gameObject.transform.localScale;
        scale2 = gameObject.transform.localScale;
    }

    void Update()
    {
        //gameObject.transform.localScale = scale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //当たったのがウイルスだったら
        if (other.gameObject.tag == "virus")
        {
            //床を大きくして痛がっているように見せる
            scale.y = gameObject.transform.localScale.y * 3;
            gameObject.transform.localScale = scale;
          
            //デバッグログの表示
            //Debug.Log("virusHit");
            //Debug.Log("GaugeDown");
        }

        //gameObject.transform.localScale = scale2;

    }


}
