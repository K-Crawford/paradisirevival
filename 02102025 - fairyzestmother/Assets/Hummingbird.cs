using UnityEngine;

public class HummingbirdController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float verticalSpeed = 3f;
    public float mouseSensitivity = 2f;
    public Transform cameraTransform;

    private float verticalRotation = 0f;

    private void Start()
    {
        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        HandleMovement();
        HandleMouseLook();
    }

    private void HandleMovement()
    {
        Vector3 movement = Vector3.zero;

        // Horizontal movement
        if (Input.GetKey(KeyCode.W)) movement += transform.forward;
        if (Input.GetKey(KeyCode.S)) movement -= transform.forward;
        if (Input.GetKey(KeyCode.A)) movement -= transform.right;
        if (Input.GetKey(KeyCode.D)) movement += transform.right;

        // Normalize horizontal movement
        if (movement != Vector3.zero)
        {
            movement.Normalize();
        }

        // Vertical movement
        if (Input.GetKey(KeyCode.Space))
        {
            movement.y += 1f;
        }
        else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            movement.y -= 1f;
        }

        // Apply movement
        transform.position += movement * moveSpeed * Time.deltaTime;
    }

    private void HandleMouseLook()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotate the hummingbird horizontally
        transform.Rotate(Vector3.up * mouseX);

        // Rotate the camera vertically
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
