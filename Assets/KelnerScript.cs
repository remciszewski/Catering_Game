using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KelnerScript : MonoBehaviour
{

    public ChairScript[] tablicakrzesel;


    public ChairScript metodawybierzkrzeslo()
    {
        for(int i = 0; i < tablicakrzesel.Length; i++)
        {
            if(tablicakrzesel[i] != null && tablicakrzesel[i].stolikwolny && tablicakrzesel[i].isActiveAndEnabled)
            {
                tablicakrzesel[i].stolikwolny = false;
                return tablicakrzesel[i];
            }
        }
        return null;
    }
}
