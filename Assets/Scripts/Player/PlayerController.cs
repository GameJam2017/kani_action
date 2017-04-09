using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Vector2 speed = new Vector2(0.5f, 0.5f);

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

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "MoveArea")
        {
            Debug.Log("移動制限");
            Destroy(gameObject);
        }
    }
}
