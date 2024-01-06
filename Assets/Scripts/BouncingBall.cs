using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
  private Rigidbody rb;
  public float bounceFactor = 0.8f; // Adjust this value for bounce strength

  void Start()
  {
      rb = GetComponent<Rigidbody>();
      rb.velocity = new Vector3(0, 5, 0); // Initial velocity, adjust as needed
  }

  void Update()
  {
      // Add code here if needed
  }

  void OnCollisionEnter(Collision collision)
  {
      // Check if colliding with the ground or a surface
      if (collision.gameObject.CompareTag("Ground"))
      {
          // Reverse the vertical velocity and apply bounce factor
          rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y * bounceFactor, rb.velocity.z);

          // Optional: Add logic to stop bouncing after a certain condition
      }
  }
}
