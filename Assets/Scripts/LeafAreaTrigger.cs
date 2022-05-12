using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafAreaTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Leaf"))
        {
            other.gameObject.tag = "Untagged";
        }
    }
}
    
