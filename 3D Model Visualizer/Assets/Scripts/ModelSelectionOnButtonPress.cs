using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelectionOnButtonPress : MonoBehaviour
{
    private int selectedModelIndex = 0;
    public List<GameObject> models = new List<GameObject>();
    public List<String> modelsName;
    public ObjectRotate objectRotate;


    void Start()
    {
        foreach (GameObject gameObject in models)
        {
            modelsName.Add(gameObject.name);
            gameObject.SetActive(false);
        }
    }


    void Update()
    { }



    public void showModel (int newIndex)
    {
        // Disable previous model
        models[selectedModelIndex].SetActive(false);

        // Assign new index to the old one
        selectedModelIndex = newIndex;

        // Reset rotation
        objectRotate.ResetRotation(objectRotate.transform);

        // Enable new model
        models[selectedModelIndex].SetActive(true);
    }

}
