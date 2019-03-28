using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    public Rigidbody rb;
    public float walkSpeed = 2.0f;


    void FixedUpdate() {
        if (Input.GetKey(KeyCode.W)) {
            rb.MovePosition(rb.position + Vector3.forward * Time.deltaTime * walkSpeed);
        }
        if (Input.GetKey(KeyCode.S)) {
            rb.MovePosition(rb.position + Vector3.back * Time.deltaTime * walkSpeed);
        }
        if (Input.GetKey(KeyCode.D)) {
            rb.MovePosition(rb.position + Vector3.right * Time.deltaTime * walkSpeed);
        }
        if (Input.GetKey(KeyCode.A)) {
            rb.MovePosition(rb.position + Vector3.left * Time.deltaTime * walkSpeed);
        }
    }
}
