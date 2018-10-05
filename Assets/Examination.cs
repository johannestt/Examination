using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examination : MonoBehaviour
{

    public float rotationspeed;
    public float shipforward;
    public float shipbackward;
    public SpriteRenderer shiprend;
    public Color rightcolor;
    public Color leftcolor;
    public float timer;
    public float timerstart;

    // Use this for initialization
    void Start()
    {
        timerstart = 0;
        timer = timerstart;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            shiprend.color = leftcolor;
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            shiprend.color = rightcolor;
            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);       // Detta gör så att man åker åt höger med knappen "D" och Vänster med "A"
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-5f / 2 * Time.deltaTime, 0, 0, Space.Self);
        }

        transform.Translate(2f * Time.deltaTime, 0, 0, Space.Self);


        {
            transform.Translate(shipforward * Time.deltaTime, 0, 0);  // Detta gör så att skeppet åker frammåt konstant
        }
        {
            timer = timer + 1 * Time.deltaTime;
            print("Timer:" + timer);
        }

    }
}

