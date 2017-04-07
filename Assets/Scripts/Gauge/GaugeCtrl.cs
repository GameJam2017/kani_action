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

    float _gauge = 0;

    void Update()
    {
       // gauge上昇
       if (Input.GetKey(KeyCode.Z))
       {
            //maxよりちいさければ
           if (_gauge < _slider.maxValue)
           {
               _gauge += 1;
           }
       }

       // gauge減少
       if (Input.GetKey(KeyCode.X))
       {
            //minより大きければ
           if (_gauge > _slider.minValue)
           {
               _gauge += -1;
           }
       }
   

        // HPゲージに値を設定
        _slider.value = _gauge;
    }
}
