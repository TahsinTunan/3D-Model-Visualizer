using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private int buttonIndex;
    public GameObject modelContainer;
    private ModelSelectionOnButtonPress script;
    private List<String> modelsName;


    void Start()
    {
        script = modelContainer.GetComponent<ModelSelectionOnButtonPress>();
        modelsName = script.modelsName;

        String buttonName = transform.Find("ModelNameText").GetComponent<TMPro.TextMeshProUGUI>().text;
        buttonIndex = modelsName.IndexOf(buttonName);
    }


    void Update()
    {  }


    public void showModelOnClick()
    {
        script.showModel(buttonIndex);
    }
}
