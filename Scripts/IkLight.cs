using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkLight : MonoBehaviour
{
    Animator anim;
    public Transform ikHand;
    public float ikWeight = 1;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void OnAnimatorIK()
    {
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, ikWeight);
        anim.SetIKPosition(AvatarIKGoal.LeftHand, ikHand.position);
    }
}
