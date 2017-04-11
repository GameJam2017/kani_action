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

    private bool _hit = false;

    void Start()
    {
        //Qpos = _player.transform.localPosition;

        //hit = _playerScript.IsHitObj();
    }

    // クリックされたら
    public void OnClick()
    {
        // プレイヤーがウイルスまたはアイテムにあたっているかを取得
        _hit = _playerScript.IsHitObj();

        // 何かを持っていてかつ、持つことが可能なオブジェクトに当たっている場合
        if (_hit == true && _playerScript._bringFlg == false)
        {
            Debug.Log("bring!");

            // 持ったオブジェクトを取得
            _bringObj = _playerScript._childObj;

            // プレイヤーの変数に持っているという情報を渡す
            _playerScript._bringFlg = true;

            // 当たっているという判定を打ち消す
            _hit = false;

            return;
        }

        // プレイヤーが何かを持っている時にボタンが押された場合
        if (_playerScript._bringFlg == true)
        {
            Debug.Log("cut!");

            // 持っているオブジェを消滅
            Destroy(_playerScript._childObj);

            // プレイヤーをアイテム未所持に
            _playerScript._bringFlg = false;

            return;
        }
    }

    // プレイヤーがオブジェクトを挟んでいる時に移動した場合プレイヤーと共に座標を移動させる
    private void ObjectMoveToBring()
    {
    }

}
