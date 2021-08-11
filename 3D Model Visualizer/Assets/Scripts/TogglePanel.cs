using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    public GameObject panel;
    private bool panelState;


    void Start()
    {
        panelState = false;
        panel.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelState = !panelState;
            togglePanel();
        }
    }

    public void togglePanel()
    {
        panel.SetActive(panelState);
    }
}
