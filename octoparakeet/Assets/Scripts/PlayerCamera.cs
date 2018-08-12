using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public Transform target;
    public float cameraSpeed = 4f;
    public float cameraSmooth = 0.125f;
    public Vector3 cameraOffset;

    //future control to stop camera when interacting with objects.
    bool cameraMove = true;

    private void Start()
    {
        Cursor.visible = false;
    }


    private void LateUpdate()
    {
        if (cameraMove == true)
        {
            Vector3 desiredPosition = target.position + cameraOffset;
            Vector3 smoothedPosition = Vector3.Lerp
                                              (transform.position, desiredPosition, cameraSmooth);

            cameraOffset = Quaternion.Euler(Input.GetAxis("Mouse Y") * cameraSpeed,
                                            Input.GetAxis("Mouse X") * cameraSpeed, 0) * cameraOffset;

            transform.position = smoothedPosition;
            transform.LookAt(target.position);
        }
    }

}

