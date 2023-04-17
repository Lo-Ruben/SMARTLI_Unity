using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public HealthBar healthBarUI;
    

    [HideInInspector]
    private CharacterController mCharacterController;
    [SerializeField]
    float walkSpeed = 50f;
    [SerializeField]
    float gravityValue = -100f;

    float playerVelocityY = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        mCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Control player movement (WASD) using Unity's character controller
    //Script is attached to Player game object
    public void MovePlayer()
    {
        Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inputDir.Normalize();

        //Check if player is touching the ground and simulate Gravity
        if (mCharacterController.isGrounded)
        {
            playerVelocityY = 0f;
        }
        else
        {
            playerVelocityY += gravityValue * Time.deltaTime;
        }


        Vector3 playerVelocity = (transform.forward * inputDir.y + transform.right * inputDir.x) * walkSpeed + Vector3.up * playerVelocityY;

        mCharacterController.Move(playerVelocity * Time.deltaTime);
    }

    
}
