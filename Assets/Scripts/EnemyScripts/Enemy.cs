using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 敵
public class Enemy : Token
{
    int movetime = 0;

    /// 開始
    void Start()
    {
        // ランダムな方向に移動する
        int dir = 0;

        // 速さは2
        float spd = 5;
        switch(Random.Range(0, 3))
        {
            case 0:
                // 方向をランダムに決める
                dir = Random.Range(20, 70);
                break;
            case 1:
                // 方向をランダムに決める
                dir = Random.Range(110, 160);
                break;
            case 2:
                // 方向をランダムに決める
                dir = Random.Range(200, 250);
                break;
            case 3:
                // 方向をランダムに決める
                dir = Random.Range(290, 340);
                break;

        }
        SetVelocity(dir, spd);
    }
    void Update()
    {
        // カメラの左下座標を取得
        Vector2 min = GetWorldMin();
        // カメラの右上座標を取得する
        Vector2 max = GetWorldMax();

        movetime++;
        
        if (X - SpriteWidth / 2 < min.x || max.x < X + SpriteWidth / 2)
        {
            // 画面外に出たので、X移動量を反転する
            VX *= -1;
            // 画面内に移動する
            ClampScreen();
        }
        if (movetime >= 120)
        {
            if (Y - SpriteHeight / 2 < min.y + 1 || max.y < Y + SpriteHeight / 2)
            {
                // 画面外に出たので、Y移動量を反転する
                VY *= -1;
                // 画面内に移動する
                ClampScreen();
            }

        }

    }
}
