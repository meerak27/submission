using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using NeoFPS;
public class enemyAi : MonoBehaviour
{
    public Transform[] patrolPoints;
    private int currentPatrolPointIndex = 0;
    private NavMeshAgent navMeshAgent;

    public GameObject player;
    private float attackingRange = 10;

    public bool isPatrolling, isAttacking;
    public BasicHealthManager health;
    public Animator anim;
    public ArmouredDamageHandler armour;
    public float damagTimer = 5;
    private float currentTimer = 5;
    public GameObject muzzleFlash;
    public Transform firePoint;
    public AudioSource audio;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        SetNextPatrolPoint();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (health.health <= 0)
        {
            transform.GetComponent<enemyAi>().enabled = false;
        }
        // Check if we've reached the current patrol point
        if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.5f && isPatrolling == true)
        {
            // Move to the next patrol point
            SetNextPatrolPoint();
        }

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");

        }


        if (player != null&&health.health>0)
        {
            armour = FindAnyObjectByType<ArmouredDamageHandler>();
            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance < attackingRange)
            {
                isAttacking = true;
                if (isAttacking == true)
                {
                    currentTimer += Time.deltaTime;
                    if (currentTimer > damagTimer)
                    {
                        attackPlayer();
                        currentTimer = 0;
                    }
                   
                isPatrolling = false;
            }

            else if (isAttacking == true && distance > attackingRange)
            {
                navMeshAgent.speed = 1;
                isAttacking = false;
                anim.SetBool("shoot", false);
                isPatrolling = true;
            }

        }
            if(isAttacking==true)
            {
                
                transform.LookAt(player.transform.position);
            }

        }
    }
    public void attackPlayer()
    {   
        anim.SetBool("shoot", true);
        navMeshAgent.speed = 0;
        armour.AddDamage(30);
        transform.LookAt(player.transform.position);
        if(audio.isPlaying==false)
        {
            audio.Play();
        }

    }
    void SetNextPatrolPoint()
    {
        // Set the destination to the next patrol point
        navMeshAgent.destination = patrolPoints[currentPatrolPointIndex].position;

        // Increment the index for the next patrol point
        currentPatrolPointIndex = (currentPatrolPointIndex + 1) % patrolPoints.Length;
    }
}
