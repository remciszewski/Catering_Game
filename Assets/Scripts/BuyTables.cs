using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTables : MonoBehaviour
{

    [SerializeField] int smallSetCost = 100;
    [SerializeField] int bigSetCost = 150;
    public GameObject[] tablica1;

    public Bank bank;

    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }
    public void BuySmallTableSet()
    {
        for(int i = 0; i < tablica1.Length; i++)
        {
            if(tablica1[i] != null)
            {

                if(bank != null && bank.currentBalance >= smallSetCost)
                {
                    tablica1[i].SetActive(true);
                    tablica1[i] = null;
                    
                    bank.Withdraw(smallSetCost);
                        
                    
                    return;
                } 
            }
        }
        
    }


    public void BuyBigTableSet()
    {
        for(int i = 0; i < tablica1.Length; i++)
        {
            if(tablica1[i] != null)
            {

                if(bank != null && bank.currentBalance >= bigSetCost)
                {
                    tablica1[i].SetActive(true);
                    tablica1[i] = null;
                    
                    bank.Withdraw(bigSetCost);
                        
                    
                    return;
                } 
            }
        }
    }
}
