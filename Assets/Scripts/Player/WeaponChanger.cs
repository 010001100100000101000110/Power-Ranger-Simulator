using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChanger : MonoBehaviour
{
    [SerializeField]
    private GameObject weapon1;
    [SerializeField]
    private GameObject weapon2;
    [SerializeField]
    private GameObject pokeDot;
    private Animator animator;

   
    void Start()
    {
        animator = GetComponent<Animator>();
        weapon1.SetActive(false);
        weapon2.SetActive(false);
        pokeDot.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
            pokeDot.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
            pokeDot.SetActive(true);
        }
    }
}