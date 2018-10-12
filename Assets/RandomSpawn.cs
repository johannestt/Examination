using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {
    public float xSpawn; // variabel för vart X de spawnar asså uppåt och neråt
    public float ySpawn; // variabel för vart y de spawnar asså vänster och höger
    public Vector2 position; // variabel för kordinations system
	// Use this for initialization
	void Start () {
        //Dessa ser till att skeppet spawnar på olika positioner inom de numrena som är inskrivna i random range
        xSpawn = Random.Range(-8.5f, 8.5f); // det här gör så de spawnar mellan -8.5 och 8.5 på x nivå uupåt och neråt
        ySpawn = Random.Range(-4.5f, 4.5f); // det här gör så att de spawnar mellan -4.5 4.5 på y nivå vänster och höger
        position = new Vector2(xSpawn, ySpawn); // visar att de ska skrivas i kordinations system
        transform.position = position; // den flyttar spawnen
       

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
