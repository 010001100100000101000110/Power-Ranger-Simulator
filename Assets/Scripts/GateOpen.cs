using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateOpen : MonoBehaviour
{
    [SerializeField]
    private bool areTrash;
    [SerializeField]
    private bool areLeaves;
    [SerializeField]
    private Transform mainCamera;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject[] trashes;
            trashes = GameObject.FindGameObjectsWithTag("Trash");
            if (trashes.Length == 0)
            {                
                areTrash = false;
            }           

            GameObject[] leaves;
            leaves = GameObject.FindGameObjectsWithTag("Leaf");

            if (leaves.Length == 0)
            {
                
                areLeaves = false;
            }
            
            if (leaves.Length > 0)
            {
                areLeaves = true;
            }
          
            RaycastHit hitInfo;
            if (Physics.Raycast(mainCamera.position, mainCamera.forward, out hitInfo, 10f, LayerMask.GetMask("Gate")))
            {               
                if (hitInfo.collider.CompareTag("Gate") && areTrash == false && areLeaves == false)
                {
                    SceneManager.LoadScene("EndScene");
                }

            }
        }        
    }    
}
