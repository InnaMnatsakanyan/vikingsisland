using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Animator animator;
    public float lookRadius = 10f;
    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start() {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        // animator = GetComponent<Animator>();
    }

    void Update() {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius) {
            agent.SetDestination(target.position);
            // animator.SetBool("isChasing", true);
            // if (distance >= lookRadius*2)
            //     animator.SetBool("isAttacking", true);

            if (distance <= agent.stoppingDistance) {
                // FaceTarget();
            }
        }
        // animator.SetBool("isChasing", false);
    }

    // void FaceTarget() {
    //     Vector3 direction = (target.position - transform.position).normalized;
    //     Quaternion lookRotation = Quaternion.LookRotation(new Vector3(180, 180, 180));
    //     transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    // }

    // Update is called once per frame
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
