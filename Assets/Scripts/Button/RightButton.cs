using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour {

    public GameObject player;

    public float speed = 1.5f;

    bool now = false;

    void Update()
    {
        if (now == true)
        {
            Vector3 Qpos = player.transform.localPosition;
            Qpos.x += (speed * Time.deltaTime);
            if (Qpos.x > 5.5f)
            {
                Qpos.x = 5.5f;
            }
            player.transform.localPosition = Qpos;
        }
    }

    public void OnRightDown()
    {
        now = true;
    }

    public void OnRightUp()
    {
        now = false;
    }

    public void OnClick()
    {
        Debug.Log("right");
    }
}
