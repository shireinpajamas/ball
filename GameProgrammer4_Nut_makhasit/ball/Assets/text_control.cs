using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_control : MonoBehaviour
{
    [SerializeField]Text score;
    [SerializeField] Text win;
    GameObject ball;
    int sc;
    void Start()
    {
      ball = GameObject.Find("ball");
        win.gameObject.SetActive(false);
        win.text = "You Win!";
    }

    // Update is called once per frame
    void Update()
    {

        score.text = "Score: " + ball.GetComponent<move>().score; ;
        if(ball.GetComponent<move>().score >= 10)
        {
            win.gameObject.SetActive(true);
        }
    }
}
