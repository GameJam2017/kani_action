using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 敵
public class Enemy : Token
{
    /// 開始
    void Start()
    {
        // ランダムな方向に移動する
        // 方向をランダムに決める
        float dir = Random.Range(0, 359);
        // 速さは2
        float spd = 2;
        SetVelocity(dir, spd);
    }
}
