using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Item : Interactable
{
    [SerializeField]
    private GameObject image;
    [SerializeField]
    private TextMeshProUGUI description;
    public bool IsDescriptionOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(false); 
        IsDescriptionOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //design our interaction using code
    protected override void Interact()
    {
        ShowDescription();
    }

    protected override void InteractEsc()
    {
        HideDescription();
    }

    private void ShowDescription()
    {
        image.SetActive(true);
    }

    private void HideDescription()
    {
        image.SetActive(false);
    }
}
