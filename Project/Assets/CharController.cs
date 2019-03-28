using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {
    public float moveSpeed = 5f;

    public Vector3 forward;
    public Vector3 right;

    public Animator animr;

    void Start() {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

    }

    void Update() {
        if (Input.anyKey) {
            Move();
        }
    }

    private void Move() {
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);
        //Vector3.ClampMagnitude(rightMovement + upMovement, 1.0f) * moveSpeed;

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;

        animr.Play("Walk");
    }

}
