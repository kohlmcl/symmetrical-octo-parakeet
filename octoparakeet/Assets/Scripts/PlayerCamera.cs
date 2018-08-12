using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public Transform target;
    public float cameraSpeed = 4f;
    public Vector3 cameraOffset;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void LateUpdate()
    {
        cameraOffset = Quaternion.Euler(Input.GetAxis("Mouse Y") * cameraSpeed,
                                        Input.GetAxis("Mouse X") * cameraSpeed, 0) * cameraOffset;

        transform.position = target.position + cameraOffset;
        transform.LookAt(target.position);
        }

}

