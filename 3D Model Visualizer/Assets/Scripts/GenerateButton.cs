using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateButton : MonoBehaviour
{
    public GameObject modelContainer;
    private ModelSelectionOnButtonPress script;
    private List<GameObject> models;


    void Start()
    {
        script = modelContainer.GetComponent<ModelSelectionOnButtonPress>();
        models = script.models;


        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject button;
        foreach (GameObject model in models)
        {
            button = Instantiate(buttonTemplate, transform);
            button.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = model.transform.name;
        }
        Destroy(buttonTemplate);
    }



    void Update()
    {

    }
}
