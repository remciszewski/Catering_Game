using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class CustomerController : MonoBehaviour
{
    [SerializeField] GameObject target;
    NavMeshAgent agent;
    public KelnerScript skryptkelnera;

    public MagazynScript skryptwybierajacyjedzenie;
    private Vector3 pozycja_startowa;
    private Quaternion rotacja_startowa;

    
    
    void Start()
    {
        pozycja_startowa = transform.position;
        rotacja_startowa = transform.rotation;
    }


    void OnEnable()
    {
        if(skryptkelnera != null)
        {
            ChairScript krzeslowybierz = skryptkelnera.metodawybierzkrzeslo();
            if(krzeslowybierz != null)
            {
                if(agent == null)
                {
                agent = GetComponent<NavMeshAgent>();
                }
                agent.SetDestination(krzeslowybierz.transform.position);
                string result = PickRandomFood();
                skryptwybierajacyjedzenie.sellFood();
                Debug.Log(result);
                StartCoroutine(Despawn());
            }
            else
            {
                if(agent == null)
                {
                agent = GetComponent<NavMeshAgent>();
                }
                agent.SetDestination(GameObject.Find("WaitingPoint").transform.position);
            }
        }
        
        
        //metoda1();
        //agent = GetComponent<NavMeshAgent>();
        //target = GameObject.FindGameObjectWithTag("Seat");
        //agent.SetDestination(target.transform.position);
    }



    public string PickRandomFood()
    {
        string[] foodlist = new string[3]{"Spaghetti", "Pizza", "Gnocchi"};
        string randomfood = foodlist[Random.Range(0, foodlist.Length)];
        return randomfood;
    }

    public void OnTriggerEnter(Collider other) {
        
        if(other.tag == "WaitingPoint")
        {
            WyjscieKlienta();
        }

    }

    private void WyjscieKlienta()
    {
        gameObject.SetActive(false);
        transform.position = pozycja_startowa;
        transform.rotation = rotacja_startowa;
    }

    IEnumerator Despawn()
    {
        while(true)
        {
            
            yield return new WaitForSeconds(10);
            WyjscieKlienta();
        }
    }


  


}
