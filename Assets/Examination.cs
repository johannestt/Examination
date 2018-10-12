using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examination : MonoBehaviour
{

    public float rotationspeed; // variabel för skeppets sväng fart
    public float shipforward; // variabel för skeppets fart frammåt
    public float shipbackward; // variabel för skeppets fart baklänges
    public SpriteRenderer shiprend; // sprite rend som gör så att skeppet ändrar för de är en sprite
    public Color rightcolor; // variabel för färgen när skeppet svänger höger
    public Color leftcolor; // variabel när för förgen när den svänger vänster
    public Color spacecolor; // variable för färgen när man har truckit space
    public float red; // variabel float för färgen red
    public float blue; // variabel float för färgen blå
    public float green; // variabel float för färgen grön
    public float timer; // Variable timer float

    // Use this for initialization
    void Start()
    {
        // Detta bestämmer en random hastighet för skeppet frammåt
        shipforward = Random.Range(5, 16);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Om man trycker knappen A händer det under
        {
            shiprend.color = leftcolor; // skeppet ändras till vald färg som man ändrar i unity för den e public variabel
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime); // den åker vänster time deltatime gör så det är oberoende av frames per second

        }
        if (Input.GetKey(KeyCode.D)) // Om man håller ned knappen D Händer det under
        {
            shiprend.color = rightcolor; // skeppets ändras till vald färg för variablen i unity
            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);  //  Den åker åt höger obereonde av frames per second
            transform.Translate(-5f / 2 * Time.deltaTime, 0, 0, Space.Self); // den åker av halva den vanliga farten oberoende av frames per second
        }
        if (Input.GetKeyDown(KeyCode.S)) // Om man håller ned knappen S händer det under
        {
            shipforward = shipforward / 2;// den åker halva hastigheten oberoende frames per second
        }
        if (Input.GetKeyUp(KeyCode.S)) // när man släpper S blir det de orginella farten

        {
            shipforward = shipforward * 2; // denna gör så om man släpper s så blir de normal far igen oberoende fps
        }
            transform.Translate(shipforward * Time.deltaTime, 0, 0);  // Detta gör så att skeppet åker frammåt konstant
        if (Time.fixedTime == timer) // detta är en timer
        {
            timer = timer + 1; // en per sekund
            print("Seconds:" + timer); // printar ut timern så att det ser ut som Seconds:X och
       

        }
        // Denna del gör så att den byter till en random färg när man trycker space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            red = Random.Range(0f, 1f); // Random färgvalue i röda
            green = Random.Range(0f, 1f);    // Random Färgvalue i grönt               
            blue = Random.Range(0f, 1f); // random färvalue i blue
            spacecolor = new Color(red, green, blue); // den väljer en kombo av alla efter de randomizerats
            shiprend.color = spacecolor; // space color variabeln för färgen när man trycket space
            
        }


    }
}

