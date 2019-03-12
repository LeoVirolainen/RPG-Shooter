using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    public Rigidbody2D rb2D;
    public float walkSpeed = 2.0f;


    void FixedUpdate() {
        if (Input.GetKey(KeyCode.W)) {
            rb2D.MovePosition(rb2D.position + Vector2.up * Time.deltaTime * walkSpeed);
        }
        if (Input.GetKey(KeyCode.S)) {
            rb2D.MovePosition(rb2D.position + Vector2.down * Time.deltaTime * walkSpeed);
        }
        if (Input.GetKey(KeyCode.A)) {
            rb2D.MovePosition(rb2D.position + Vector2.right * Time.deltaTime * walkSpeed);
        }
        if (Input.GetKey(KeyCode.D)) {
            rb2D.MovePosition(rb2D.position + Vector2.left * Time.deltaTime * walkSpeed);
        }
    }
}
