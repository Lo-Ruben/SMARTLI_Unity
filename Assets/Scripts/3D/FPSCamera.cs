using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    [SerializeField]
    Transform mCameraPosition;
    [SerializeField]
    Transform mPlayerPosition;
    [SerializeField]
    float mouseSensitivity = 3.5f;

    float cameraAngle = 0f;

    void Start()
    {
        // When game starts, centers mouse position on the screen then hides it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        MoveCamera();
    }

    //Control camera movement along with player game object as mouse moves
    //Script is found in the camera attached to the player game object
    public void MoveCamera()
    {
        //To move the camera vertically, pivot the camera game object attached to the player in the scene along the x-axis. 
        //For horizontal movement, the player, which also contains the camera gameobject, has to rotate along the y-axis

        Vector2 mouseVector = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        //To prevent invertation of camera's controlls, we need to provide a negative output for the mouse inputs
        //This helps the camera's rotation along the x-axis
        cameraAngle -= mouseVector.y * mouseSensitivity;

        cameraAngle = Mathf.Clamp(cameraAngle, -90f, 90f);

        mCameraPosition.localEulerAngles = Vector3.right * cameraAngle;

        //Horizontal camera movement
        mPlayerPosition.Rotate(Vector3.up * mouseVector.x * mouseSensitivity);
    }


}