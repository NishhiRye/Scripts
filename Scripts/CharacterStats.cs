using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;

    public float dieDelay = 2f;
    public int currentHealth { get; private set; }

    public Stat damage;
    public Stat armor;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void Update()
    {
      


            if (Input.GetKeyDown(KeyCode.V))
            {
                TakeDamage(50);
            }
        
    }

    public void TakeDamage (int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        Debug.Log(transform.name + "takes" + damage + "damage");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {        
        Debug.Log(transform.name + "Died");
        Destroy(this.gameObject, 10);
        Invoke("DieDelay", dieDelay);
    }

    void DieDelay()
    {
        this.GetComponent<EnemyController>().enabled = false;
        this.GetComponent<Animator>().enabled = false;
        this.GetComponent<NavMeshAgent>().enabled = false;
    }
}   
