using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    Rigidbody rb;
    public int score;
    public int speed;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            rb.AddForce(Vector3.forward * Input.GetAxis("Vertical")*speed);
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            rb.AddForce(Vector3.right * Input.GetAxis("Horizontal")*speed);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            Destroy(other.gameObject);
            score++;
        }
    }
}
