using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerChase : MonoBehaviour
{

    Transform target;
    NavMeshAgent agent;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance > 2)
        {
            agent.updatePosition = true;
            agent.SetDestination(target.transform.position);
            anim.SetBool("isRuning", true);
            anim.SetBool("isAttacking", false);
        }
        else
        {
            agent.updatePosition = false;
            anim.SetBool("isRuning", false);
            anim.SetBool("isAttacking", true);
        }

    }
}
