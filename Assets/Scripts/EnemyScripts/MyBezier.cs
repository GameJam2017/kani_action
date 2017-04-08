using UnityEngine;
using System.Collections;

public class MyBezier : MonoBehaviour
{
    public Bezier myBezier;
    private float t = 0f;

    void Start()
    {
        myBezier = new Bezier(new Vector3(-1f, 1f, -1f), Random.insideUnitSphere * 2f, Random.insideUnitSphere * 2f, new Vector3(3f, 1f, 3f));
    }

    void Update()
    {
        Vector3 vec = myBezier.GetPointAtTime(t);
        transform.position = vec;
        transform.position = new Vector3(transform.position.x,transform.position.y,0);

        t += 0.01f;
        if (t > 1f)
            t = 0f;
    }
}