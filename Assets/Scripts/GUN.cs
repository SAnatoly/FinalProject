using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUN : MonoBehaviour
{

    public GameObject spawnBullet;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Instantiate(spawnBullet, transform.position, transform.rotation);
	}
}
