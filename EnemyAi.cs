using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 2.5f;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;
    AudioSource audio;
    
    void Start()
    {
        audio = GetComponent<AudioSource>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position,transform.position);
        if (isProvoked)
        {
            EngageTARGET();
        }
        else if(distanceToTarget <= chaseRange)
        {
            isProvoked = true;
            
            
        }

        void EngageTARGET()
        {
            if (distanceToTarget >= navMeshAgent.stoppingDistance)
            {
                ChaseTarget();
            }

            if (distanceToTarget <= navMeshAgent.stoppingDistance)
            {
                AttackTarget();
            }

        }

        void ChaseTarget()
        {
            if (!audio.isPlaying)
            {
                audio.Play();
            }
            GetComponent<Animator>().SetBool("attack", false);
            GetComponent<Animator>().SetTrigger("move");
            navMeshAgent.SetDestination(target.position);
        }

        void AttackTarget()
        {
            GetComponent<Animator>().SetBool("attack", true);
            Debug.Log(name + "has seeked and destroyed" + target.name);
        }

        void OnDrawGizmosSelected()
        {
            //display radius when selected
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, chaseRange);
        }
        
    }
}