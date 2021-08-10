using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;

    void Start()
    {
        
    }

    
    void Update()
    {
        // ArrowKey Input
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rotationSpeed);
        }

        // Reset Rotation
        if (Input.GetKeyDown("r"))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
