using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popScartch : MonoBehaviour
{
    //傷を登録
    //GameObject scratch = GameObject.FindWithTag("scratch");

    //public GameObject kizu = GameObject.FindGameObjectWithTag("scratch");

    Vector3[] pos = new Vector3[]
{
          new Vector3 (-6.26f, -3.97f, 0.0f),
          new Vector3 ( 0.34f, -3.72f, 0.0f),
          new Vector3 ( 7.27f, -3.47f, 0.0f)
};
     public GameObject scratch;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Treatment")== null)
        {
            //scratch = GameObject.FindGameObjectWithTag("Treatment");

            Instantiate(scratch);

            //if (scratch != null)
            //{
            //    Debug.Log("ないよ");
            //}

            //Instantiate(Resources.Load("Prefab") as GameObject);

            //乱数の生成
            int rand = Random.Range(1, 4);

            switch (rand)
            {
                case 1:
                    //scratch.transform.position = new Vector3(1, 1, 1);
                    scratch.transform.position = pos[0];

                    break;

                case 2:
                    //scratch.transform.position = new Vector3(3, 3, 3);
                    scratch.transform.position = pos[1];

                    break;

                case 3:
                    //scratch.transform.position = new Vector3(5, 5, 5);
                    scratch.transform.position = pos[2];

                    break;
            }

        }

    }
}
