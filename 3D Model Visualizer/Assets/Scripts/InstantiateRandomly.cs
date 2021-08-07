using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomly : MonoBehaviour
{
    // public Transform pos;
    public GameObject[] objectToInstantiate;



    void Start()
    {
        int index = Random.Range(0, objectToInstantiate.Length);
        Instantiate(objectToInstantiate[index], new Vector3 (0, 0, 0) , objectToInstantiate[index].transform.rotation);
    }

    
    void Update()
    {
        
    }
}
