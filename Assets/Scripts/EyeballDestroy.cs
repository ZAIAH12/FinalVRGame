using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeballDestroy : MonoBehaviour
{
    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject Jumpcam;


    private void OnTriggerEnter()
    {
        Scream.Play();
        Jumpcam.SetActive(true);
        ThePlayer.SetActive(false);

        StartCoroutine(EndJump());
        GetComponent<Collider>().enabled = false;
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.03f);
        ThePlayer.SetActive(true);
        Jumpcam.SetActive(false);

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Hand")
        {
            CollectEyeball.theScore += 1;
            Destroy(gameObject);
        }
    }
    
    
}
