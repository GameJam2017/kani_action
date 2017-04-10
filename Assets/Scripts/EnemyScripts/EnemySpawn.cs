using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;    //敵オブジェクト
    public Transform ground;    //地面オブジェクト
    public float count = 0;     //一度に何体のオブジェクトをスポーンさせるか
    public float interval = 0;  //何秒おきに敵を発生させるか
    private float timer;        //経過時間
    // Use this for initialization
    void Start()
    {
        Spawn();    //初期スポーン
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    //経過時間加算
        if (timer >= interval)
        {
            Spawn();    //スポーン実行
            timer = 0;  //初期化
        }
    }

    void Spawn()
    {
        for (int i = 0; i < count; i++)
        {
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-5f, 5f);
            Vector3 pos = new Vector3(x, y, -1) + ground.position;
            GameObject.Instantiate(enemy, pos, Quaternion.identity);
        }
    }
}