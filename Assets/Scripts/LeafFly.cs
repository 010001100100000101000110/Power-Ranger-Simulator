using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafFly : MonoBehaviour
{

    private Rigidbody rb;
    private Transform player;
    [SerializeField]
    private float speed = 3;
    private bool forceOn;
    private LeafBlowerShoot lbs;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        lbs = player.GetComponentInChildren<LeafBlowerShoot>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("LeafBlower"))
        {
            forceOn = true;

        }
    }
    private void FixedUpdate()
    {
        if (forceOn == true && lbs.isBlowing)
        {
            Vector3 direction = transform.position - player.position;
            rb.AddForce(direction * speed, ForceMode.Impulse);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LeafBlower"))
        {
            forceOn = false;
        }
    }
}
