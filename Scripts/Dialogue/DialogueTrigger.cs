using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject FToInteract;
    public GameObject Portal;
    public float Delay = 50;
    public GameObject GlobalLight;    

    //public Dialogue dialogue;

    private void OnTriggerStay(Collider other)
    {
        FToInteract.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {
            //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            GetComponent<AudioSource>().Play();
            Invoke("PortalOpen", Delay);          
        }
            
        
    }
    void PortalOpen()
    {
        GlobalLight.SetActive(true);
        Portal.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        FToInteract.SetActive(false);
    }
}
