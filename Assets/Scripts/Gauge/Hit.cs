using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hit : MonoBehaviour
{
    public GameObject gauge;
    public int damage = 10;
    public int cure = 10;

    //collision同士で当たったら
    void OnCollisionEnter2D(Collision2D col)
    {
        //エネミーと当たったら
        if (col.gameObject.tag == "Enemy")
        {
            gauge.gameObject.SendMessage("onEnemy", damage);
        }

        //アイテムと当たったら
        if (col.gameObject.tag == "Item")
        {
            gauge.gameObject.SendMessage("onItem", cure);
        }
    }
}
