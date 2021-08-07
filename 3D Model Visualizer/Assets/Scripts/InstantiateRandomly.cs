using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomly : MonoBehaviour
{
    public GameObject[] objectToInstantiate;
    private Vector3 pos = new Vector3 (0, 0, 0);
    private Quaternion rotation = Quaternion.Euler(0, 0, 0);

    void Start()
    {
        int index = Random.Range(0, objectToInstantiate.Length);
        instantiateObject(index, pos, rotation);
    }

    
    void Update()
    {
        
    }

    void instantiateObject(int index, Vector3 pos, Quaternion rotation)
    {
        Instantiate(objectToInstantiate[index], pos , rotation);
    }
}
