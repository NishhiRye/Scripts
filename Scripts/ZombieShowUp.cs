using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieShowUp : MonoBehaviour
{
    public GameObject Zombie;
    public AudioSource emboscada;
    public AudioSource battle;
    public float Delay = 12f;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){
            Zombie.SetActive(true);
            emboscada.PlayDelayed(Delay);
            battle.PlayDelayed(Delay + 2f);
        }
    }
}
