using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastsPlayer : MonoBehaviour
{
    public Interactable focus;
    public float focusRange = 100f;

        


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = FindObjectOfType<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, focusRange))
            {
                Debug.Log("esta colidindo");
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }

            }
            else
            {
                Debug.Log("n esta n");
            }
        }
    }

    public void SetFocus(Interactable newFocus)
    {
        if(newFocus != focus)
        {
            if (focus != null)
            
                focus.OnDefocused();
            
            focus.OnDefocused();
            focus = newFocus;
        }
        focus = newFocus;
        newFocus.OnFocused(transform);
    }

    public void RemoveFocus()
    {
        if(focus != null)
        
            focus.OnDefocused();
        
        focus.OnDefocused();
        focus = null;
    }
}
