using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    private InputManager inputManager;
    private Item item;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
        item = GetComponent<Item>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptmessage);
                if (inputManager.onFoot.Interact.triggered)
                {
                    interactable.BaseInteract();
                    inputManager.onFoot.Movement.Disable();
                }
                else if (inputManager.onFoot.EscFrame.triggered)
                {
                    interactable.BaseInteract1();
                    inputManager.onFoot.Movement.Enable();
                }
                else if (inputManager.onFoot.EscMenu.triggered)
                {
                    Application.Quit();
                }    
            }
        }
    }
}
