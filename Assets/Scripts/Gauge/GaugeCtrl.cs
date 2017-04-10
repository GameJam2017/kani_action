using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeCtrl : MonoBehaviour
{
    public int up = 10;
    public int down = 10;
    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    public float _gauge = 50;

    void Update()
    {
        // HPゲージに値を設定
        _slider.value = _gauge;
    }

    //エネミーとキズが当たったときに呼び出される
    void onEnemy()
    {
        //minより大きければ
        if (_gauge - down > _slider.minValue)
        {
            _gauge -= down;
        }
        else
        {
            _gauge = 0;
        }
        // HPゲージに値を設定
        _slider.value = _gauge;
    }

    //エネミーとキズが当たったときに呼び出される
    void onItem()
    {
        //minより大きければ
        if (_gauge + up > _slider.minValue)
        {
            _gauge += up;
        }
        else
        {
            _gauge = 100;
        }
        // HPゲージに値を設定
        _slider.value = _gauge;
    }
}
