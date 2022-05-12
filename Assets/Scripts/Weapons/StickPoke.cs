using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPoke : MonoBehaviour
{    
    
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetTrigger("NoPoke");

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("PokeWithStick");
        }
    }



}