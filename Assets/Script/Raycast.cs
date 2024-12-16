using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Raycase : MonoBehaviour
{
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    ExitAppOnClick clickableObject = hit.transform.GetComponent<ExitAppOnClick>();
                    if (clickableObject != null)
                    {
                        Debug.Log("clicked");
                        clickableObject.OnObjectClicked();
                    }
                }
            }
        }
    }
}
