using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutButton : MonoBehaviour {

    public PlayerController _playerScript;

    public GameObject _nowChild;

    public GameObject _player;


    public void OnClick()
    {
        // 治療ポイントではないなら
        if (_playerScript._isFit == false)
        {
            // プレイヤーは何か持ってるならその場で離す
            if (_playerScript._bringFlg == true)
            {
                _nowChild = _playerScript._childObj;

                _nowChild.transform.parent = null;

                _playerScript._bringFlg = false;

                Debug.Log("put");
            }
        }
        if (_playerScript._isFit == true)
        {
            if (_playerScript._bringFlg == true)
            {

                _nowChild = _playerScript._childObj;

                _nowChild.transform.parent = null;

                _playerScript._isFit = false;

                _playerScript._bringFlg = false;

                Debug.Log("fit");
            }
        }
    }
}
