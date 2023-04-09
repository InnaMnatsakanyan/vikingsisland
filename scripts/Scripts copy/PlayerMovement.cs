using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Vector3 PlayerMovementInput;
    Vector2 PlayerMouseInput;
    float xRot;

    [SerializeField] private LayerMask FloorMask;
    [SerializeField] private Transform FeetTransform;
    [SerializeField] public Transform PlayerCamera;
    [SerializeField] public Rigidbody PlayerBody;
    [SerializeField] public float Speed;
    [SerializeField] public float Sensitivity;
    [SerializeField] public float Jumpforce;
    
    public void Update() {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        PlayerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input. GetAxis ("Mouse Y")) ;
        MovePlayer();
        MovePlayerCamera();
    }

    public void MovePlayer() {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (Physics.CheckSphere(FeetTransform.position, 0.1f, FloorMask)){
                PlayerBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            }
        }
    }

    public void MovePlayerCamera() {
        xRot -= PlayerMouseInput.y * Sensitivity;
        transform.Rotate(0f, PlayerMouseInput.x * Sensitivity, 0f);
        PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }
}