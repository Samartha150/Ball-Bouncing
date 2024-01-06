using UnityEngine;

public class FreeCameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sensitivity = 2f;

    private float rotationX = 0f;

    private void Update()
    {
        MoveCamera();
        RotateCamera();
    }

    private void MoveCamera()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.Self);
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = -Input.GetAxis("Mouse Y") * sensitivity; // Negative to invert vertical rotation

        rotationX += mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.Rotate(Vector3.up, mouseX, Space.World);
        transform.localRotation = Quaternion.Euler(rotationX, transform.localRotation.eulerAngles.y, 0f);
    }
}
