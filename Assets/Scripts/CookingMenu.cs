using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingMenu : MonoBehaviour
{

    public GameObject CookingMenuUI;


    public void Resume()
    {
        CookingMenuUI.SetActive(false);
    }

    public void Cooking()
    {
        CookingMenuUI.SetActive(true);
    }
}
