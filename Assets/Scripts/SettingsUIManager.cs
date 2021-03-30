using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsUIManager : MonoBehaviour
{
    [Header("Virtual 3D Panels")]

    public GameObject UI_Panel, UI_Settings, UI_InfoPanel;
    public float MaxSide = 0;

    public void UISetup()
    {
        if (gameObject.transform.lossyScale.x > gameObject.transform.lossyScale.z)
            MaxSide = gameObject.transform.lossyScale.x; 
        else MaxSide = gameObject.transform.lossyScale.z;
        UI_Panel.transform.position = new Vector3(MaxSide, 0, 0);
    }

    public void UpdateUIPanelStatus()
    {
        UI_Panel.SetActive(!UI_Panel.activeInHierarchy);
        if (UI_Panel.activeInHierarchy == false)
        {
            UI_Settings.SetActive(false);
            UI_InfoPanel.SetActive(false);
        }
    }

    public void UpdateUISettingsStatus()
    {
        UI_Settings.SetActive(!UI_Settings.activeInHierarchy);
        if (UI_Settings.activeInHierarchy == false)
        {
           
            UI_InfoPanel.SetActive(false);
        }

    }

    public void UpdateUIInfoPanelStatus()
    {
        UI_InfoPanel.SetActive(!UI_InfoPanel.activeInHierarchy);
    }
}
