using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float walkSpeed = 3;
    float runSpeed = 7.5f;
    float jumpSpeed = 8;

    public bool isOnGround = true;

    public Rigidbody playerRb;

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
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            // Walking

            if (!Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);

            // Walking

            if (!Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);

            // Walking

            if (!Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
            }

            // Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
            }
        }

        // Jump

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerRb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
