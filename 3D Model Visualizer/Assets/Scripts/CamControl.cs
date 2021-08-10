using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamControl : MonoBehaviour
{
    [Header("FreeRoam Camera Settings")]
    [SerializeField] private float lookSpeedH = 2f;
    [SerializeField] private float lookSpeedV = 4f;
    [SerializeField] private float zoomSpeed = 10f;
    [SerializeField] private float panSpeed = 10f;
    [SerializeField] private float cameraPanSpeed = 5f;
    private float yaw = 0f;
    private float pitch = 0f;


    // Start is called before the first frame update
    void Start()
    { }


    // Update is called once per frame
    void LateUpdate()
    {
        //Look around with Right Mouse
        if (Input.GetMouseButton(1))
        {    
            yaw = lookSpeedH * Input.GetAxis("Mouse X");
            pitch = lookSpeedV * Input.GetAxis("Mouse Y");

            //transform.eulerAngles = new Vector3(pitch, yaw, 0f);
            transform.Rotate(0, yaw, 0, Space.World);
            transform.Rotate(-pitch, 0, 0);
        }
        if (Input.GetMouseButton(2))
        {
            Vector3 projectVector = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up);
            transform.Translate(projectVector * Input.GetAxisRaw("Mouse Y") * cameraPanSpeed, Space.World);
            transform.Translate(Camera.main.transform.right * Input.GetAxisRaw("Mouse X") * cameraPanSpeed, Space.World);
        }



        //Movement with W,A,S,D
        if (Input.GetKey("w") && Input.GetMouseButton(1))
        {
            transform.position += transform.forward * (Time.deltaTime * panSpeed);
        }
        if (Input.GetKey("d") && Input.GetMouseButton(1))
        {
            transform.position += transform.right * (Time.deltaTime * panSpeed);
        }
        if (Input.GetKey("a") && Input.GetMouseButton(1))
        {
            transform.position -= transform.right * (Time.deltaTime * panSpeed);
        }
        if (Input.GetKey("s") && Input.GetMouseButton(1))
        {
            transform.position -= transform.forward * (Time.deltaTime * panSpeed);
        }

        //Zoom in and out with Mouse Wheel
        transform.Translate(0, 0, Input.GetAxis("Mouse ScrollWheel") * zoomSpeed, Space.Self);
    }
}
