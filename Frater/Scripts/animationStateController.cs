using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.W)) ||(Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D)))
        {
            animator.SetBool("isWalking", true);
        }
        if (!((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("isAttacking", true);
        }
        if (!Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("isAttacking", false);
        }
    }
}