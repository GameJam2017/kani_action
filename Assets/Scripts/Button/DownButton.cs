using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton : MonoBehaviour {

    public GameObject player;

    public float speed = 1.5f;

    bool now = false;

    void Update()
    {
        if (now == true)
        {
            Vector3 Qpos = player.transform.localPosition;
            Qpos.y += (-speed * Time.deltaTime);
            if (Qpos.y < -4.0f)
            {
                Qpos.y = -4.0f;
            }
            player.transform.localPosition = Qpos;
        }
    }

    public void OnDownButtonDown()
    {
        now = true;
    }

    public void OnDownButtonUp()
    {
        now = false;
    }

    public void OnClick()
    {
        Debug.Log("right");
    }
}