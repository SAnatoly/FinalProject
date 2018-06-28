using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonGun : MonoBehaviour//, IVirtualButtonEventHandler
{
    public GameObject buttonAr;
    public GameObject gun;
	
	void Start ()
    {
        buttonAr = GameObject.Find("Laciebtn");
       // buttonAr.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        gun.GetComponent<GUN>();

	}

    public void OnButtonPresed(VirtualButtonBehaviour vb)
    {
        Debug.Log("jjhfgu");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("iuugi");
    }
}
