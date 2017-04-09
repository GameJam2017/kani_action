using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterposeCanvas : MonoBehaviour {

    static Canvas _canvas;

    private void Start()
    {
        // Canvasコンポーネントを保持
        _canvas = GetComponent<Canvas>();
    }

    // 表示・非表示設定
    public static void SetActive(string name,bool b)
    {
        foreach(Transform child in _canvas.transform)
        {
            if (child.name == name)
            {
                child.gameObject.SetActive(b);

                return;
            }
        }
        // 見つからなかった場合
        Debug.LogWarning("Not found objname:" + name);
    }
}
