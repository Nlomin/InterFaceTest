using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject settings;
    private void Start()
    {
        menu.SetActive(false);
        settings.SetActive(false);
    }

    public void ShowMenu()
    {
        menu.SetActive(true);
    }

    public void ClickCross(GameObject menu)
    {
        menu.SetActive(false);
    }

    public void DelElement(GameObject element)
    {
        Destroy(element);
    }
    public void ShowSettings(GameObject settings)
    {
        settings.SetActive(true);
    }
}
