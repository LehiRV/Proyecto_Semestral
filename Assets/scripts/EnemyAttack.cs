using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    Animator animator;
    GameObject player;
    Health playerHealth;

    bool playerInRange;
    float timer;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();
        animator = GetComponent<Animator>();

    }



   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }

    }

     void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            playerInRange = false;
        }

    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= timeBetweenAttacks && playerInRange)
        {
            Attack();
        }
       
	}

void Attack()
    {
        timer = 0f;
        if(playerHealth.currentHealth >0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
