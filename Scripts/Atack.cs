using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public Camera cam;
    public GameObject Hand;
    public Weapon myWeapon;
    //public Animator handAnim;

     void Start()
    {
       // handAnim = Hand.GetComponent<Animator>();
        myWeapon = Hand.GetComponentInChildren<Weapon>();        
            
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            DoAttack();
        }
    }

    private void DoAttack()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, myWeapon.attackRange))
        {
            if(hit.collider.tag == "Enemy")
            {
                Damage eHealth = hit.collider.GetComponent<Damage>();
                   // eHealth.takeDamage(myWeapon.attackDamage);
            }
        }
    }
}
