using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCtrl : MonoBehaviour
{

    public int TotalScore = 0;
    public int PlusScore = 10;
    public int MinusScore = 10;

    void Start()
    {
        //int型をstring型に変換して表示
        GetComponent<Text>().text = (TotalScore).ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            TotalScore += PlusScore;
        }
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            TotalScore -= MinusScore;
        }
        //int型をstring型に変換して表示
        GetComponent<Text>().text = (TotalScore).ToString();
    }

    //エネミーとキズが当たったときに呼び出される
    void onEnemy()
    {
        //minより大きければ
        if (TotalScore > 0)
        {
            TotalScore -= MinusScore;
        }
        else
        {
            TotalScore = 0;
        }

        //int型をstring型に変換して表示
        GetComponent<Text>().text = (TotalScore).ToString();
    }

    //エネミーとキズが当たったときに呼び出される
    void onItem()
    {
        TotalScore += PlusScore;
        //int型をstring型に変換して表示
        GetComponent<Text>().text = (TotalScore).ToString();

    }
}
