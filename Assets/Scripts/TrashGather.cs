using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGather : MonoBehaviour
{

    [SerializeField]
    private Transform originalPoint;
    [SerializeField]
    private float radius;

    [SerializeField]
    private Transform mainCamera;

    private AudioSource trashDrop;
    //[SerializeField]
    //private AudioSource poke;

    [SerializeField]
    private AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        trashDrop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(originalPoint.position, radius);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.transform.CompareTag("Trash"))
            {

                hitCollider.transform.SetParent(originalPoint);
                hitCollider.transform.tag = "CollectedTrash";
                trashDrop.PlayOneShot(sound);
            }
            
        }

        RaycastHit hitInfo;
        if (Physics.Raycast(mainCamera.position, mainCamera.forward, out hitInfo, 3f))
        {
            if (hitInfo.transform.CompareTag("TrashBin") && Input.GetKeyDown(KeyCode.E))
            {
                if (originalPoint.childCount > 0)
                {
                    Debug.Log("dropped trash");
                    trashDrop.Play();
                    Destroy(originalPoint.GetChild(0).gameObject);
                }
            }
            
        }
    }
}
