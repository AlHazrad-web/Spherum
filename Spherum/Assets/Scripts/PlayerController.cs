using UnityEngine;
public class PlayerController : MonoBehaviour {

    public float speed = 5.0f;
    public float minDistance = -10.0f;
    public float maxDistance = 10.0f;

    public KeyCode moveForwardKey = KeyCode.W;
    public KeyCode moveBackwardKey = KeyCode.S;
    public KeyCode moveLeftKey = KeyCode.A;
    public KeyCode moveRightKey = KeyCode.D;

    void Update() {

        Vector3 movement = Vector3.zero;

        if (Input.GetKey(moveForwardKey)) {
            movement += Vector3.forward;
        }

        if (Input.GetKey(moveBackwardKey)) {
            movement += -Vector3.forward;
        }

        if (Input.GetKey(moveRightKey)) {
            movement += Vector3.right;
        }

        if (Input.GetKey(moveLeftKey)) {
            movement += -Vector3.right;
        }

        movement = movement.normalized;

        Vector3 newPosition = transform.position + movement * speed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, minDistance, maxDistance);
        newPosition.z = Mathf.Clamp(newPosition.z, minDistance, maxDistance);

        transform.position = newPosition;
    }

}
