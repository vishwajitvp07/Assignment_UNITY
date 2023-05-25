using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public Transform[] Point;
    int Current;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {

        Current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != Point[Current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, Point[Current].position, Speed * Time.deltaTime);

        }
        else
            Current = (Current + 1) % Point.Length;
    }
}
