using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Transform playerCam;

	public Transform orientation;

	private Rigidbody rb;

	private float xRotation;

	private float sensitivity = 50f;

	private float sensMultiplier = 1f;

	public float moveSpeed = 4500f;

	public float maxSpeed = 20f;

	public bool grounded;

	public LayerMask whatIsGround;

	public float counterMovement = 0.175f;

	private float threshold = 0.01f;

	public float maxSlopeAngle = 35f;

	private Vector3 crouchScale = new Vector3(1f, 0.5f, 1f);

	private Vector3 playerScale;

	public float slideForce = 400f;

	public float slideCounterMovement = 0.2f;

	private bool readyToJump = true;

	private float jumpCooldown = 0.25f;

	public float jumpForce = 550f;

	private float x;

	private float y;

	private bool jumping;

	private bool sprinting;

	private bool crouching;

	private Vector3 normalVector = Vector3.up;

	private Vector3 wallNormalVector;

	private float desiredX;

	private bool cancellingGrounded;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Start()
	{
		playerScale = base.transform.localScale;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void FixedUpdate()
	{
		Movement();
	}

	private void Update()
	{
		MyInput();
		Look();
	}

	private void MyInput()
	{
		x = Input.GetAxisRaw("Horizontal");
		y = Input.GetAxisRaw("Vertical");
		jumping = Input.GetButton("Jump");
		crouching = Input.GetKey(KeyCode.LeftControl);
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			StartCrouch();
		}
		if (Input.GetKeyUp(KeyCode.LeftControl))
		{
			StopCrouch();
		}
	}

	private void StartCrouch()
	{
		base.transform.localScale = crouchScale;
		base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y - 0.5f, base.transform.position.z);
		if (rb.velocity.magnitude > 0.5f && grounded)
		{
			rb.AddForce(orientation.transform.forward * slideForce);
		}
	}

	private void StopCrouch()
	{
		base.transform.localScale = playerScale;
		base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z);
	}

	private void Movement()
	{
		rb.AddForce(Vector3.down * Time.deltaTime * 10f);
		Vector2 mag = FindVelRelativeToLook();
		float num = mag.x;
		float num2 = mag.y;
		CounterMovement(x, y, mag);
		if (readyToJump && jumping)
		{
			Jump();
		}
		float num3 = maxSpeed;
		if (crouching && grounded && readyToJump)
		{
			rb.AddForce(Vector3.down * Time.deltaTime * 3000f);
			return;
		}
		if (x > 0f && num > num3)
		{
			x = 0f;
		}
		if (x < 0f && num < 0f - num3)
		{
			x = 0f;
		}
		if (y > 0f && num2 > num3)
		{
			y = 0f;
		}
		if (y < 0f && num2 < 0f - num3)
		{
			y = 0f;
		}
		float num4 = 1f;
		float num5 = 1f;
		if (!grounded)
		{
			num4 = 0.5f;
			num5 = 0.5f;
		}
		if (grounded && crouching)
		{
			num5 = 0f;
		}
		rb.AddForce(orientation.transform.forward * y * moveSpeed * Time.deltaTime * num4 * num5);
		rb.AddForce(orientation.transform.right * x * moveSpeed * Time.deltaTime * num4);
	}

	private void Jump()
	{
		if (grounded && readyToJump)
		{
			readyToJump = false;
			rb.AddForce(Vector2.up * jumpForce * 1.5f);
			rb.AddForce(normalVector * jumpForce * 0.5f);
			Vector3 velocity = rb.velocity;
			if (rb.velocity.y < 0.5f)
			{
				rb.velocity = new Vector3(velocity.x, 0f, velocity.z);
			}
			else if (rb.velocity.y > 0f)
			{
				rb.velocity = new Vector3(velocity.x, velocity.y / 2f, velocity.z);
			}
			Invoke("ResetJump", jumpCooldown);
		}
	}

	private void ResetJump()
	{
		readyToJump = true;
	}

	private void Look()
	{
		float num = Input.GetAxis("Mouse X") * sensitivity * Time.fixedDeltaTime * sensMultiplier;
		float num2 = Input.GetAxis("Mouse Y") * sensitivity * Time.fixedDeltaTime * sensMultiplier;
		desiredX = playerCam.transform.localRotation.eulerAngles.y + num;
		xRotation -= num2;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);
		playerCam.transform.localRotation = Quaternion.Euler(xRotation, desiredX, 0f);
		orientation.transform.localRotation = Quaternion.Euler(0f, desiredX, 0f);
	}

	private void CounterMovement(float x, float y, Vector2 mag)
	{
		if (!grounded || jumping)
		{
			return;
		}
		if (crouching)
		{
			rb.AddForce(moveSpeed * Time.deltaTime * -rb.velocity.normalized * slideCounterMovement);
			return;
		}
		if ((Math.Abs(mag.x) > threshold && Math.Abs(x) < 0.05f) || (mag.x < 0f - threshold && x > 0f) || (mag.x > threshold && x < 0f))
		{
			rb.AddForce(moveSpeed * orientation.transform.right * Time.deltaTime * (0f - mag.x) * counterMovement);
		}
		if ((Math.Abs(mag.y) > threshold && Math.Abs(y) < 0.05f) || (mag.y < 0f - threshold && y > 0f) || (mag.y > threshold && y < 0f))
		{
			rb.AddForce(moveSpeed * orientation.transform.forward * Time.deltaTime * (0f - mag.y) * counterMovement);
		}
		if (Mathf.Sqrt(Mathf.Pow(rb.velocity.x, 2f) + Mathf.Pow(rb.velocity.z, 2f)) > maxSpeed)
		{
			float num = rb.velocity.y;
			Vector3 vector = rb.velocity.normalized * maxSpeed;
			rb.velocity = new Vector3(vector.x, num, vector.z);
		}
	}

	public Vector2 FindVelRelativeToLook()
	{
		float current = orientation.transform.eulerAngles.y;
		float target = Mathf.Atan2(rb.velocity.x, rb.velocity.z) * 57.29578f;
		float num = Mathf.DeltaAngle(current, target);
		float num2 = 90f - num;
		float magnitude = rb.velocity.magnitude;
		return new Vector2(y: magnitude * Mathf.Cos(num * ((float)Math.PI / 180f)), x: magnitude * Mathf.Cos(num2 * ((float)Math.PI / 180f)));
	}

	private bool IsFloor(Vector3 v)
	{
		return Vector3.Angle(Vector3.up, v) < maxSlopeAngle;
	}

	private void OnCollisionStay(Collision other)
	{
		int layer = other.gameObject.layer;
		if ((int)whatIsGround != ((int)whatIsGround | (1 << layer)))
		{
			return;
		}
		for (int i = 0; i < other.contactCount; i++)
		{
			Vector3 normal = other.contacts[i].normal;
			if (IsFloor(normal))
			{
				grounded = true;
				cancellingGrounded = false;
				normalVector = normal;
				CancelInvoke("StopGrounded");
			}
		}
		float num = 3f;
		if (!cancellingGrounded)
		{
			cancellingGrounded = true;
			Invoke("StopGrounded", Time.deltaTime * num);
		}
	}

	private void StopGrounded()
	{
		grounded = false;
	}
}
