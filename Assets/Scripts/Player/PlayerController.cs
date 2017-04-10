using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Vector2 speed = new Vector2(0.5f, 0.5f);

    // オブジェクトに当たっているか
    public bool objHit = false;

    public GameObject _nowHitObj = null;

    // オブジェクトを持っているか
    public bool _bringFlg = false;

    public GameObject _interposeBtn;

    // 子オブジェクトの保持
    public GameObject _childObj = null;

    public bool _isFit = false;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    // 移動関数(キーボードデバッグ用)
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
        // 治療ポイント以外に当たっていたら
        if(collision.gameObject.tag != "Treatment")
        {
            // 当たっている状態に
            Debug.Log("true");

            objHit = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // 治療ポイント以外から外れたら
        if (collision.gameObject.tag != "Treatment")
        {
            // 当たっていない状態に
            Debug.Log("false");

            objHit = false;
        }
    }

    // 現在治療ポイント以外のオブジェクトに当たっているかを返す
    public bool IsHitObj()
    {
        return objHit;
    }

    // コライダーに当たっている間
    private void OnTriggerStay2D(Collider2D collision)
    {
        // プレイヤーが所持状態であるなら
        if (_bringFlg == true)
        {
            // 親子一緒に移動
            // 道具orウィルス
            if (collision.gameObject.tag == "Item" || collision.gameObject.tag == "virus")
            {
                // 親と一緒に座標を移動
                _childObj = collision.gameObject;

                _childObj.transform.parent = transform;
            }
        }

        if (collision.gameObject.tag == "Treatment")
        {
            Debug.Log("ok");

            // 治療することができる状態に
            _isFit = true;
        }
    }

    //public GameObject GetChild()
    //{
    //    return _childObj;
    //}
}