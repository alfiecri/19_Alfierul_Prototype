using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float walkSpeed = 3;
    float runSpeed = 12;

    public Rigidbody playerRb;
    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

            // Walking

            if (!Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isWalk", true);
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isRun", true);
                playerAnim.SetBool("isWalk", false);
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            // Walking

            if (!Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isWalk", true);
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isRun", true);
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);

            // Walking

            if (!Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isWalk", true);
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isRun", true);
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);

            // Walking

            if (!Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isWalk", true);
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnim.SetBool("isRun", true);
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        // Stop Walking/Running
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("isWalk", false);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerAnim.SetBool("isRun", false);
        } 
    }
}
