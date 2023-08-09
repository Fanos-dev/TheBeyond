using System;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;
    
    public GameObject followTarget;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        
        //Calculate camera rotation for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //Apply this to our camera transform
        followTarget.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //Rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime * xSensitivity));
    }
    
}
