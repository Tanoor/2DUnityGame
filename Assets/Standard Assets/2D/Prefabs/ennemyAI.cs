using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemyAI : MonoBehaviour
{
    private Vector3 pointA;
    public Transform pointB;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        pointA = transform.position;

        // while(true) 
        // {
        //     float i = Mathf.PingPong(Time.time * speed, 1);
        //     transform.position = Vector3.Lerp(pointA, pointB.position, i);
        //     yield;
        // }
    }
}
