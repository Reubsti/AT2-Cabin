using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    public float Speed = 2.0f;
    public float sprintSpeed = 5.0f;
    public float gravity = 3.5f;

    private float currentSpeed = 0f;
    private float velocity = 0;
    private CharacterController controller;
    private Vector3 motion;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        motion = Vector3.zero;
        if (controller.isGrounded == true)
        {
            velocity = -gravity * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.LeftShift) == true)
            {
                //Check to see speed is not equal to sprint speed
                if (currentSpeed != sprintSpeed)
                {
                    currentSpeed = sprintSpeed;
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift) == true)
                {
                    //Change to walkspeed
                    if (currentSpeed != Speed)
                    {
                        currentSpeed = Speed;
                    }
                }
            }

        }
        else
        {
            velocity -= gravity * Time.deltaTime;
        }

        ApplyMovement();
    }

    ///<summary>
    ///</Apply the calculated movement changes to the game objective's transform
    ///</summary>
    void ApplyMovement()
    {

        motion += transform.forward * Input.GetAxisRaw("Vertical") * currentSpeed * Time.deltaTime;
        motion += transform.right * Input.GetAxisRaw("Horizontal") * currentSpeed * Time.deltaTime;
        motion.y += velocity;

        if (controller.enabled)

        {
            controller.Move(motion);
        }
    }


    
           



}
    
    
        
 
         



    
        





      
    



