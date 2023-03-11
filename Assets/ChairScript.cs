using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript : MonoBehaviour
{

    GameObject customer;
    public bool stolikwolny = true;

    void Update()
    {
        ChangeSeatTag();
    }

    void ChangeSeatTag()
    {
        customer = GameObject.FindGameObjectWithTag("Customer");

        if(Vector3.Distance(transform.position, customer.transform.position) < 1f)
        {
            gameObject.tag = "SeatTaken";
        }
        
    }

}
