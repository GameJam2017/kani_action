using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCtrl : MonoBehaviour
{
    public float time = 60;
    public GameObject gameOverText;

    void Start()
    {
        //ゲームオーバーのテクスチャを非表示に
        gameOverText.SetActive(false);

        //int型に変換したものをstring型に変換して表示
        GetComponent<Text>().text = ((int)time).ToString();
    }

    void Update()
    {
        //一秒ずつ減らしていく
        time -= Time.deltaTime;

        //マイナスは表示しない
        if(time < 0)
        {
            gameOverText.SetActive(true);

            time = 0;
        }

        GetComponent<Text>().text = ((int)time).ToString();
    }
}
