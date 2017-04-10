using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour {

    public GameObject player;

    public float speed = 1.5f;

    bool now = false;

    void Update()
    {
        if (now == true)
        {
            Vector3 Qpos = player.transform.localPosition;
            Qpos.x += (speed* -1 * Time.deltaTime);
            if (Qpos.x < -5.3f)
            {
                Qpos.x = -5.3f;
            }
            player.transform.localPosition = Qpos;
        }
    }

    public void OnLeftDown()
    {
        now = true;
    }

    public void OnLeftUp()
    {
        now = false;
    }

    public void OnClick()
    {
        Debug.Log("left");
    }
}
