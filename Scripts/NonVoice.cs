using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonVoice : MonoBehaviour
{
        void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (other.CompareTag("Player"))
            {
                GetComponent<AudioSource>().Play();
                GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject, 10);
            }
        }
    }
}
