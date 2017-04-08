using UnityEngine;
using System.Collections;

public class TrackingPlayer : MonoBehaviour
{

    GameObject Player;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Enemy");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - 1);

    }
}