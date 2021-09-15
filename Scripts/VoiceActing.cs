using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceActing : MonoBehaviour
{ 
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider>().enabled = false;
            Destroy(gameObject, 10);
        }   
    }
}
