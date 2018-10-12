using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {    // Detta skapar en variabel som får skeppets postion.
        Vector3 newPosition = transform.position;
        // Detta ser till att skeppet inte kan åka ut på höger eller vänster sida men warpar till motsatta sidan.
        if (newPosition.x > 9 || newPosition.x < -9)
        {
            newPosition.x = -newPosition.x; // Den säger till skeppet att vara på andra sidan skärmen på x graden
        }
        // Detta ser till att skeppet inte kan åka ut uppåt eller neråt och den gör så den warpar till motsatta sida.
        if (newPosition.y > 5 || newPosition.y < -5)
        {
            newPosition.y = -newPosition.y; // Den säger till skeppet att vara på andra sidan skärmen på y graden
        }
        transform.position = newPosition; // den flyttar skeppet

    }
}
