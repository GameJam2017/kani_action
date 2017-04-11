using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{

    GameObject floor;
    Vector3 floorSize;

    GameObject gauge;

    public GaugeCtrl _gauge2;

    // Use this for initialization
    void Start ()
    {
        //床の情報を入手
        floor = GameObject.FindGameObjectWithTag("floor");
        floorSize = floor.gameObject.transform.localScale;

        //床を縦方向に大きくする
        floorSize.y = floorSize.y * 5;

        _gauge2 = GetComponent<GaugeCtrl>();

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
            GameObject.Destroy(gameObject);
            //gameObject.Equals(null);

            //Debug.Log("Hititem");
            //Debug.Log("SetActive: true -> false");
            //Debug.Log("GaugeUp");
            _gauge2.onItem();

        }

        //当たったのがウイルスだったら
        if (collision.gameObject.tag == "Enemy")
        {
            //床を大きくする
            floor.gameObject.transform.localScale = floorSize;
            floorSize.y = floorSize.y / 3;

            //Debug.Log("HitEnemy");
            //Debug.Log("GuageDown");
            Destroy(collision.gameObject);

            _gauge2.onEnemy();

        }
    }
}
