using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelectionOnButtonPress : MonoBehaviour
{
    private int selection = 0;
    public List<GameObject> models = new List<GameObject>();


    void Start()
    {
        foreach (GameObject gameObject in models)
        {
            gameObject.SetActive(false);
        }
    }


    void Update()
    {

        // Input
        if (Input.GetKey("h"))
        {
            models[selection].SetActive(false);
            selection = 0;
            models[selection].SetActive(true);
        }

        if (Input.GetKey("j"))
        {
            models[selection].SetActive(false);
            selection = 1;
            models[selection].SetActive(true);
        }
        if (Input.GetKey("k"))
        {
            models[selection].SetActive(false);
            selection = 2;
            models[selection].SetActive(true);
        }
        if (Input.GetKey("l"))
        {
            models[selection].SetActive(false);
            selection = 3;
            models[selection].SetActive(true);
        }

        // Function

        // Ager ta disable
        // Notun tar pos, rot reset
        // notun ta enable 

    }

    // private void showModel()
    // {
    //     models[selection].SetActive(false);

    // }

}
