using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addAnimation : MonoBehaviour
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
        //walking
        if (Input.GetKey("up")) {
            animator.SetBool("isWalking", true);
        }
        if (!Input.GetKey("up")) {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey("down")) {
            animator.SetBool("isWalkingBackwards", true);
        }
        if (!Input.GetKey("down")) {
            animator.SetBool("isWalkingBackwards", false);
        }
        //jumping
        if (Input.GetKey("space")) {
            animator.SetBool("isJumping", true);
        }
        if (!Input.GetKey("space")) {
            animator.SetBool("isJumping", false);
        }
        //running
        if (Input.GetKey("up") && Input.GetKey("left shift")) {
            animator.SetBool("isRunning", true);
        }
        if (!Input.GetKey("up") || !Input.GetKey("left shift")) {
            animator.SetBool("isRunning", false);
        }
        //jumping while walking
        if (Input.GetKey("up") && Input.GetKey("space")) {
            animator.SetBool("isJumping", true);
        }
        if (Input.GetKey("up") && !Input.GetKey("space")) {
            animator.SetBool("isJumping", false);
        }
        //jumping while running
        if (Input.GetKey("up") && Input.GetKey("left shift") && Input.GetKey("space")) {
            animator.SetBool("isJumping", true);
        }
        if (Input.GetKey("up") && Input.GetKey("left shift") && !Input.GetKey("space")) {
            animator.SetBool("isJumping", false);
        }
        //jumping backwards
        if (Input.GetKey("down") && Input.GetKey("space")) {
            animator.SetBool("isJumping", true);
        }
        if (Input.GetKey("down") && !Input.GetKey("space")) {
            animator.SetBool("isJumping", false);
        }
        //left and right movement while walking
        if (Input.GetKey("up") && Input.GetKey("left")) {
            animator.SetBool("isWalkingLeft", true);
        }
        if (!Input.GetKey("up") || !Input.GetKey("left")) {
            animator.SetBool("isWalkingLeft", false);
        }
        if (Input.GetKey("up") && Input.GetKey("right")) {
            animator.SetBool("isWalkingRight", true);
        }
        if (!Input.GetKey("up") || !Input.GetKey("right")) {
            animator.SetBool("isWalkingRight", false);
        }
        //left and right movement while idle
        if (Input.GetKey("left")) {
            animator.SetBool("IsIdleWalkingLeft", true);
        }
        if (!Input.GetKey("left")) {
            animator.SetBool("IsIdleWalkingLeft", false);
        }
        if (Input.GetKey("right")) {
            animator.SetBool("IsIdleWalkingRight", true);
        }
        if (!Input.GetKey("right")) {
            animator.SetBool("IsIdleWalkingRight", false);
        }
        //left and right running movement
        if (Input.GetKey("left") && Input.GetKey("left shift")) {
            animator.SetBool("isIdleRunningLeft", true);
        }
        if (!Input.GetKey("left") || !Input.GetKey("left shift")) {
            animator.SetBool("isIdleRunningLeft", false);
        }
        if (Input.GetKey("right") && Input.GetKey("left shift")) {
            animator.SetBool("isIdleRunningRight", true);
        }
        if (!Input.GetKey("right") || !Input.GetKey("left shift")) {
            animator.SetBool("isIdleRunningRight", false);
        }
    }
}
