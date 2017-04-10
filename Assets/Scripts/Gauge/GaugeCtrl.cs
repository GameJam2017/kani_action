using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeCtrl : MonoBehaviour
{

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
    void onEnemy(int damage)
    {
        //minより大きければ
        if (_gauge - damage > _slider.minValue)
        {
            _gauge -= damage;
        }
        else
        {
            _gauge = 0;
        }
        // HPゲージに値を設定
        _slider.value = _gauge;
    }

    //エネミーとキズが当たったときに呼び出される
    void onItem(int cure)
    {
        //minより大きければ
        if (_gauge + cure > _slider.minValue)
        {
            _gauge += cure;
        }
        else
        {
            _gauge = 100;
        }
        // HPゲージに値を設定
        _slider.value = _gauge;
    }
}
