using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamControl : MonoBehaviour
{
    [Header("FreeRoam Camera Settings")]
    public float lookSpeedH = 2f;
    public float lookSpeedV = 4f;
    public float zoomSpeed = 10f;
    public float dragSpeed = 6f;
    public float panSpeed = 10f;
    public float cameraPanSpeed = 5f;

    private float yaw = 0f;
    private float pitch = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
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


        /*if (Input.GetKeyDown(KeyCode.F))
        {

            target = ObjectInspection.next;
            FocusCameraOnGameObject(Camera.main, target);
        }*/


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




    /*Bounds CalculateBounds(GameObject go)
    {
        Bounds b = new Bounds(go.transform.position, Vector3.zero);
        Object[] rList = go.GetComponentsInChildren(typeof(Renderer));
        foreach (Renderer r in rList)
        {
            b.Encapsulate(r.bounds);
        }
        return b;
    }*/

    /*void FocusCameraOnGameObject(Camera c, GameObject go)
    {
        Bounds b = CalculateBounds(go);
        Vector3 max = b.size;
        float radius = Mathf.Max(max.x, Mathf.Max(max.y, max.z));
        float dist = radius / (Mathf.Sin(c.fieldOfView * Mathf.Deg2Rad / 2f));
        c.transform.position = go.transform.position + transform.rotation * Vector3.forward * -dist;
    }*/
}
