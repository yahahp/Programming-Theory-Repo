using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cube : Shape
{
    private string _name = "Cube";
    private TextMeshProUGUI shapeName;
    public GameObject textName;

    void Start()
    {
        shapeName = textName.GetComponent<TextMeshProUGUI>();
    }

    private void OnMouseEnter()
    {
        // ABSTRACTION
        ShowDisplayInfo();
    }
    private void OnMouseExit()
    {
        // ABSTRACTION
        HideDisplayInfo();
    }
    // POLYMORPHISM
    protected override void ShowDisplayInfo()
    {
        textName.gameObject.SetActive(true);
        shapeName.text = SetName;
    }
    // POLYMORPHISM
    protected override void HideDisplayInfo()
    {
        textName.gameObject.SetActive(false);
    }
    // ENCAPSULATION
    private string SetName
    {
        get { return _name; }
    }
}

