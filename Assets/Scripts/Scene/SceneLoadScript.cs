using UnityEngine;

using System.Collections;



public class SceneLoadScript : MonoBehaviour
{
    public void SceneLoad()
    {
        FadeManager.Instance.LoadLevel("Time", 1.0f);
    }

}