using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Interactable
{
    PlayerManager playerManager;

    void Start()
    {
        playerManager = PlayerManager.instance;
    }

    // Update is called once per frame
    public override void Interact()
    {
        base.Interact();

    }
}
