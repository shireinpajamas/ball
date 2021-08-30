using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject ball;
    Vector3 offset;
    void Start()
    {
        ball = GameObject.Find("ball");
        offset = transform.position - ball.transform.position;
    }

    
    void Update()
    {
        gameObject.transform.position = ball.transform.position + offset;
    }
}
