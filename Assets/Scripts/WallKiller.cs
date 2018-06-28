using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class WallKiller : MonoBehaviour
{
    public Text lose;

	// Use this for initialization
	void Start ()
    {
		
	}
	
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {


            lose.text = "Проиграл";
            lose.color = Color.red;
            StartCoroutine(Restart());
        }
    }


    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
