using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterposeButton : MonoBehaviour {

    // プレイヤーを保持
    public GameObject _player;

    // プレイヤースクリプトを保持
    public PlayerController _playerScript;

    // 治療ポイント
    public GameObject _TreatmentPoint;

    public GameObject _bringObj;

    //[SerializeField]
    //public Vector3 Qpos;

    private bool hit = false;

    void Start()
    {
        //Qpos = _player.transform.localPosition;

        hit = _playerScript.IsHitObj();
    }

    void Update()
    {
    }

    public void OnClick()
    {
        hit = _playerScript.IsHitObj();

        if (hit == true && _playerScript._bringFlg == false)
        {
            Debug.Log("bring!");

            // 持ったオブジェクトを取得
            _bringObj = _playerScript._childObj;

            _playerScript._bringFlg = true;

            hit = false;

            return;
        }

        if (_playerScript._bringFlg == true)
        {
            Debug.Log("cut!");

            Destroy(_playerScript._childObj);

            _playerScript._bringFlg = false;

            return;
        }
    }

    // プレイヤーがオブジェクトを挟んでいる時に移動した場合プレイヤーと共に座標を移動させる
    private void ObjectMoveToBring()
    {
    }

}
