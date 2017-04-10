using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hit : MonoBehaviour
{
    public GameObject gauge;
    public GameObject text;

    //collision同士で当たったら
    void OnCollisionEnter2D(Collision2D col)
    {
        //エネミーと当たったら
        if (col.gameObject.tag == "Enemy")
        {
            text.gameObject.SendMessage("onEnemy");
            gauge.gameObject.SendMessage("onEnemy");
        }

        //アイテムと当たったら
        if (col.gameObject.tag == "Item")
        {
            text.gameObject.SendMessage("onItem");
            gauge.gameObject.SendMessage("onItem");
        }
    }
}
