using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 1;
    float moveZ;
    float moveY;
 
	// Use this for initialization
	void Start ()
    {
		
	}
	

    public void goStraight()
    {
        moveZ = speed * Time.deltaTime; 


    }

    public void Left()
    {
        moveY = speed * Time.deltaTime;
    }

    public void Right()
    {
        moveY = -speed * Time.deltaTime;
    }

    public void Back()
    {
        moveZ = -speed * Time.deltaTime;
    }

    public void Stop()
    {
        moveZ = 0;
        moveY = 0;
    }

	// Update is called once per frame
	void Update ()
    {
        transform.Translate(moveY, 0, moveZ);
        
    }
}
