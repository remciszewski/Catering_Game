using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MagazynScript : MonoBehaviour
{
    public int makaron;
    public int pomidor;
    public int ciasto;
    public int ser;
    public int kluski;
    public int szpinak;
    public Bank bank;
    public CustomerController pickrandomfood;
    string wybranejedzenie;

    

    public void sellFood()
    {

        wybranejedzenie = pickrandomfood.PickRandomFood();

        if (wybranejedzenie == "Spaghetti")
        {
            makaron = makaron - 1;
            pomidor = pomidor - 1;
            
            bank.Deposit(15);
        }
        else if (wybranejedzenie == "Pizza")
        {
            ciasto = ciasto - 1;
            ser = ser - 1;

            bank.Deposit(10);
        }
        else if (wybranejedzenie == "Gnocchi")
        {
            kluski = kluski - 1;
            szpinak = szpinak - 1;

            bank.Deposit(10);
        }
        
    }
    
    // makaron, pomidor 
    // ciasto, ser
    // kluski, szpinak
    



}

    // 3 tablice skladniki, ich ceny i ilosc,
    // kucharz ma miec tablice menu, wylosowac co ma jesc, po tym jak on wybierze stolik, klient siedzial przez, albo stal przy wejsciu, i blokowal kolejnych klientow
    // klient wysyla zadanie do kelnera, false = ucieka, true = idzie do stolika i kucharz losuje jedzenie, jak sie konczy to po prostu znika, placi od razu zanim usiadzie przy stoliku 
    // niech kucharz od razu mu daje jedzenie bez przycisku
    // kupuje stoliki, skladniki rano
    // okreslic minimalna kwote, jak za malo to przegra gre
    // oplaty codziennie za utrzymanie restauracji
    // kelner musi widziec kucharza, kucharz musi widziec magazyn
    // 
