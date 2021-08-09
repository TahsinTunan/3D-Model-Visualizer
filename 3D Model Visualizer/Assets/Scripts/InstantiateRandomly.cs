using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomly : MonoBehaviour
{
    public GameObject[] objectToInstantiate;

    void Start()
    {
        int index = Random.Range(0, objectToInstantiate.Length);
        instantiateObject(index);
    }


    void Update()
    {
        
    }

    void instantiateObject(int index)
    {
        Instantiate(objectToInstantiate[index], Vector3.zero , Quaternion.identity);
    }
}
