using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject Jumpcam;
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {

            Scream.Play();
            Jumpcam.SetActive(true);
            ThePlayer.SetActive(false);
            
            StartCoroutine(EndJump());
            GetComponent<Collider>().enabled = false;
        }
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.03f);
        ThePlayer.SetActive(true);
        Jumpcam.SetActive(false);
        

    }

    
}
