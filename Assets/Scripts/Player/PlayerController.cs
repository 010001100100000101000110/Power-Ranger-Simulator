using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Vector2 movementDirection;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private float gravity = -9.8f;
    [SerializeField]
    private GameObject helpCanvas;
    [SerializeField]
    private GameObject timerCanvas;
    private bool movementLocked;
    private Footsteps steps;
   
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        helpCanvas.SetActive(false);
        steps = GetComponent<Footsteps>();
    }

    void Update()
    {
        if (movementLocked == false)
        {
            CharacterMove();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            steps.enabled = false;
            helpCanvas.SetActive(true);
            movementLocked = true;
            timerCanvas.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            steps.enabled = true;
            helpCanvas.SetActive(false);
            movementLocked = false;
            timerCanvas.SetActive(true);
        }
    }

    private void CharacterMove()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Vector3 move = transform.right * movementDirection.x + transform.forward * movementDirection.y;

        velocity.y += gravity * Time.deltaTime;


        if (characterController.isGrounded == true && velocity.y < 0)
        {
            velocity.y = -2;
        }

        if (Input.GetKeyDown(KeyCode.Space) && characterController.isGrounded)
        {
            velocity.y = 7;
        }

        characterController.Move((move * speed * Time.deltaTime) + (velocity * Time.deltaTime));
    }
}
