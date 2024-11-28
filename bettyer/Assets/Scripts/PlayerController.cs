using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    // Private veriables
    [SerializeField] private float rpm;
    [SerializeField]private float horsePower = 0;
   // private float speed = 25f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] private TextMeshProUGUI speedomeeterText;
    [SerializeField] private TextMeshProUGUI rpmPro;
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;
    // Update is called once per frame

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.localPosition;
    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        if (IsOnGround())
        {
            playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f);
            speedomeeterText.SetText("speed: " + speed + "mph");

            rpm = (speed % 30) * 40;
            rpmPro.SetText("rpm: " + rpm);
        }
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

}
