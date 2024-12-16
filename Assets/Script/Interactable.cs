using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Message when look at item
    public string promptmessage;

    // called from player
    public void BaseInteract()
    {
        Interact();
    }

    public void BaseInteract1()
    {
        InteractEsc();
    }

    protected virtual void Interact()
    {
        // wont write code in this
        // this a template function
    }

    protected virtual void InteractEsc()
    {
        // wont write code in this
        // this a template function
    }
}
