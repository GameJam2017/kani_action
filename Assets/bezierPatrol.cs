using UnityEngine;
using System.Collections;

public class bezierPatrol : MonoBehaviour
{
    const float margin = 1.0f;

    public Vector3[] checkpoints;
    public Vector3[] ctrlPoints;

    private float time;
    private int whereToGo;

    private Vector3 BezierCurve(Vector3 pt1, Vector3 pt2, Vector3 ctrlPt, float t)
    {
        if (t > 1.0f)
            t = 1.0f;

        Vector3 result = new Vector3();
        float cmp = 1.0f - t;
        result.x = cmp * cmp * pt1.x + 2 * cmp * t * ctrlPt.x + t * t * pt2.x;
        result.y = cmp * cmp * pt1.y + 2 * cmp * t * ctrlPt.y + t * t * pt2.y;
        result.z = cmp * cmp * pt1.z + 2 * cmp * t * ctrlPt.z + t * t * pt2.z;
        return result;
    }

    // Use this for initialization
    void Start()
    {
        time = 0.0f;
        whereToGo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (checkpoints.Length == 0)
            return;

        if (time > 1.0f)
            time = 0.0f;

        if (checkpoints.Length <= this.whereToGo)
            whereToGo = 0;

        this.transform.position = BezierCurve(checkpoints[whereToGo], checkpoints[(whereToGo + 1) % checkpoints.Length], ctrlPoints[whereToGo], time);

        if (Vector3.Distance(transform.position, checkpoints[(whereToGo + 1) % checkpoints.Length]) < margin)
        {
            Debug.Log(whereToGo);
            whereToGo++;
            time = 0.0f;
        }

        time += Time.deltaTime / 2.0f;
    }
}