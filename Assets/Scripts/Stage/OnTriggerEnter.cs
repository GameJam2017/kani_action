using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{

    GameObject floor;
    Vector3 floorSize;

	// Use this for initialization
	void Start ()
    {
        //床の情報を入手
        floor = GameObject.FindGameObjectWithTag("floor");
        floorSize = floor.gameObject.transform.localScale;

        //床を縦方向に大きくする
        floorSize.y = floorSize.y * 5;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

   public  void OnTriggerEnter2D(Collider2D collision)
    {
        //当たったのがアイテムだったら
        if (collision.gameObject.tag == "Item")
        {
            Destroy(gameObject);
            Debug.Log("Hititem");
            Debug.Log("GaugeUp");
        }

        //当たったのがウイルスだったら
        if(collision.gameObject.tag == "virus")
        {
            //床を大きくする
            floor.gameObject.transform.localScale = floorSize;
            floorSize.y = floorSize.y / 3;

            Debug.Log("HitVirus");
            Debug.Log("GuageDown");
            Destroy(collision.gameObject);
        }
    }
}
