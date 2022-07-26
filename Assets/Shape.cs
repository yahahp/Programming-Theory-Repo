using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// INHERITANCE
public abstract class Shape : MonoBehaviour
{
    // POLYMORPHISM
    protected abstract void ShowDisplayInfo();
    protected abstract void HideDisplayInfo();

}