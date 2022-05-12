using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafBlowerShoot : MonoBehaviour
{
    [SerializeField]
    private Transform mainCamera;    

    [SerializeField]
    private AudioSource aS;
    [SerializeField]
    private AudioSource aS2;
    [SerializeField]
    private Transform triggerArea;
    public bool isBlowing;
    void Update()
    {        
        if (Input.GetMouseButtonDown(0))
        {
            isBlowing = true;
            aS2.Stop();
            if (!aS.isPlaying)
            {
                aS.Play();
                
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isBlowing = false;
            aS.Stop();
            if (!aS2.isPlaying)
            {                
                aS2.Play();
            }
        }
    }    
}
