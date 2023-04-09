using UnityEngine;

public class AttachCamera : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(0, 4, -4);
    }
}
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class AttachCamera : MonoBehaviour {
//     public CharacterController controller;
//     public Transform camera;
//     public float speed = 6f;
//     public float turnSmoothTime = 0.1f;
//     float turnSmoothVelocity;
    
//     // Update is called once per frame
//     public void Update () {
//         float horizontal = Input.GetAxisRaw("Horizontal");
//         float vertical = Input.GetAxisRaw("Vertical");
//         Vector direction = new Vector3(horizontal, Of, vertical).normalized;

//         if (direction.magnitude >= 0.1f) {
//             float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg * cam.eulerAngles.y;
//             float angle = Mathf.SmooothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
//             transform.rotation = Quaternion.Euler(Of, angle, 0f);
//             Vector3 movDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
//             controller.Move(movDir.normalized * speed * Time.deltaTime);
//         }
//     }
// }