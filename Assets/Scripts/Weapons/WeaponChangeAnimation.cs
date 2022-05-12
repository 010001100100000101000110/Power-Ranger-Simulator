using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChangeAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetTrigger("NoPoke");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetTrigger("Idle");
        }
    }
}
