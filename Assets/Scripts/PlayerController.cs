using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 20.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;

    public GameObject firstPersonCam;
    public GameObject thirdPersonCam;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCam.SetActive(false);
        thirdPersonCam.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // Get controller input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the Vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetButtonDown("Jump") && thirdPersonCam.activeInHierarchy)
        {
            thirdPersonCam.SetActive(false);
            firstPersonCam.SetActive(true);
        }
        else if (Input.GetButtonDown("Jump") && firstPersonCam.activeInHierarchy)
        {
            thirdPersonCam.SetActive(true);
            firstPersonCam.SetActive(false);
        }
    }
}
