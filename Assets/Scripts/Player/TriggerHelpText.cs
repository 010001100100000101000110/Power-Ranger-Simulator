using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHelpText : MonoBehaviour
{
    [SerializeField]
    private GameObject binHelpCanvas;
    [SerializeField]
    private GameObject gateHelpCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate"))
        {
            gateHelpCanvas.SetActive(true);
        }
        if (other.CompareTag("TrashBin"))
        {
            binHelpCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Gate"))
        {
            gateHelpCanvas.SetActive(false);
        }
        if (other.CompareTag("TrashBin"))
        {
            binHelpCanvas.SetActive(false);
        }
    }
}
