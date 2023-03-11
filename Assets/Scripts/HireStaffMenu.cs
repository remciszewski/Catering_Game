using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HireStaffMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject HireStaffUI;
    public GameObject BuyTableSetsUI;

    // Update is called once per frame
  
    public void Resume()
    {
        HireStaffUI.SetActive(false);
        BuyTableSetsUI.SetActive(false);
        GameIsPaused = false;
    }

    public void HireStaff()
    {
        HireStaffUI.SetActive(true);
        BuyTableSetsUI.SetActive(false);
        GameIsPaused = true;
    }

    public void BuyTableSets()
    {
        HireStaffUI.SetActive(false);
        BuyTableSetsUI.SetActive(true);
        GameIsPaused = true;
    }
}
