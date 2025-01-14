using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //moves car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates car
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
    
}
