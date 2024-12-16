using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAppOnClick : MonoBehaviour
{
    //Exit 
    public void OnObjectClicked()
    {
        if (Application.isPlaying)
        {
            Debug.Log(gameObject.name + " clicked!");
            Application.Quit();
        }

    }
}
