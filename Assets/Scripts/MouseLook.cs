using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Vector2 tempMouse;
    [SerializeField]
    private float mouseSpeed = 100;
    private float xRotation;
    [SerializeField]
    private Transform playerTransform;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseHorizontal = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseVertical = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
        tempMouse = new Vector2(mouseHorizontal, mouseVertical);

        xRotation -= mouseVertical;
        xRotation = Mathf.Clamp(xRotation, -40, 50);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        playerTransform.Rotate(Vector3.up * mouseHorizontal);
    }
}
