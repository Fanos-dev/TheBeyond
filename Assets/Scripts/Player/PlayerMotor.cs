
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float speed;
    public float walkSpeed = 7f;
    public float sprintSpeed = 10f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    private bool crouching;
    private float crouchTimer = 50f;
    public float crouchSpeed = 10;
    private bool lerpCrouch;
    private bool sprinting;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        isGrounded = controller.isGrounded;
        if (lerpCrouch)
        {
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / 1;
            p *= p * crouchSpeed;
            if (crouching)
                controller.height = Mathf.Lerp(controller.height, 1, p);
            else 
                controller.height = Mathf.Lerp(controller.height, 2.5f, p);

            if (p > 1)
            {
                lerpCrouch = false;
                crouchTimer = 0f;
            }
        }
    }
    
    //Receive the inputs for the InputManger and apply them to our character controller
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * (speed * Time.deltaTime));
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }
        controller.Move(playerVelocity * Time.deltaTime); 
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }  
    }

    public void Crouch()
    {
        crouching = !crouching;
        crouchTimer = 0;
        lerpCrouch = true;
    }

    public void Sprint()
    {
        sprinting = !sprinting;
        if (sprinting)
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
    }
}
