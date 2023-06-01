using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class NewBehaviourScript : MonoBehaviour
{
    
    bool isOn = false;
    [SerializeField] GameObject info;

    public void togglepanel()
    {
        if (isOn)
        {
            info.SetActive(false);
            isOn = false;
        }
        else
        {
            info.SetActive(true);
            isOn = true;
        }
    }
}
