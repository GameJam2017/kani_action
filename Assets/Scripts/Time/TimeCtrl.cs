using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCtrl : MonoBehaviour
{
    public float time = 60;
    public GameObject gameOverText;

    void Start()
    {

    }

    void Update()
    {
        //一秒ずつ減らしていく
        time -= Time.deltaTime;

        //マイナスは表示しない
        if(time <= 0)
        {
            SceneManager.LoadScene("TimeUp");

            time = 0;
        }

        GetComponent<Text>().text = ((int)time).ToString();

    }
}
