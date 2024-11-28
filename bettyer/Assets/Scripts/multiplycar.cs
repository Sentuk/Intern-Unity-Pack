using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class multiplycar : MonoBehaviour
{
    // Private veriables
    private float speede = 25f;
    private float turnSpeede = 25.0f;
    private float horizontalInpute;
    private float forwardInpute;
    // Update is called once per frame
    void FixedUpdate()
    {
        // This is where we get player input
        horizontalInpute = Input.GetAxis("Horizontal2");
        forwardInpute = Input.GetAxis("Vertical2");
        // We move the car forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speede * forwardInpute);
        // We turned the car 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeede * horizontalInpute);
    }
}