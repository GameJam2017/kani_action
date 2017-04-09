using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Vector2 speed = new Vector2(0.5f, 0.5f);

    // オブジェクトに当たっているか
    public bool objHit = false;

    // オブジェクトを持っているか
    public bool _bringFlg = false;

    public GameObject _interposeBtn;

    // 子オブジェクトの保持
    public GameObject _childObj = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    // 移動関数
    void Move()
    {
        Vector2 Position = transform.position;

        // 左キー
        if(Input.GetKey("left"))
        {
            Position.x -= speed.x;
        }
        // 右キー
        else if (Input.GetKey("right"))
        {
            Position.x += speed.x;
        }
        // 上キー
        else if(Input.GetKey("up"))
        {
            Position.y += speed.y;
        }
        // 下キー
        else if(Input.GetKey("down"))
        {
            Position.y -= speed.y;
        }
        // positionに代入
        transform.position = Position;
    }

    // 治療ポイント
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Point")
        {
            Debug.Log("true");
            objHit = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("false");

        objHit = false;
    }

    // 現在オブジェクトに当たっているかを返す
    public bool GetHitObj()
    {
        return objHit;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_bringFlg == true)
        {
            // 親子一緒に移動
            if (collision.gameObject.name == "Point")
            {
                _childObj = collision.gameObject;

                _childObj.transform.parent = this.transform;
            }
        }
    }
}