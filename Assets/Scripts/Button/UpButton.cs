using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour {

    public GameObject player;

    public float speed = 1.5f;

    bool now = false;

    void Update()
    {
        if (now == true)
        {
            Vector3 Qpos = player.transform.localPosition;
            Qpos.y += (speed * Time.deltaTime);
            if (Qpos.y > 4.1f)
            {
                Qpos.y = 4.1f;
            }
            player.transform.localPosition = Qpos;
        }
    }

    public void OnUpButtonDown()
    {
        now = true;
    }

    public void OnUpButtonUp()
    {
        now = false;
    }

    public void OnClick()
    {
        Debug.Log("right");
    }
}
