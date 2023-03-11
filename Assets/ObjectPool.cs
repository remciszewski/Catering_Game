using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] int poolSize = 16;
    [SerializeField] GameObject npcPrefab;
    [SerializeField] float spawnTimer = 1f;
    public KelnerScript kelnerskrypt;
    public MagazynScript magazynskrypt;

    public KelnerScript zajetystolik;
    GameObject[] pool;

    


    void Awake()
    {
        PopulatePool();
    }
    void Start()
    {
        StartCoroutine(SpawnCustomer());
    }

    void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for(int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(npcPrefab, transform);
            CustomerController zmienna = pool[i].GetComponent<CustomerController>();
            if(zmienna != null)
            {
                zmienna.skryptkelnera = kelnerskrypt;
            }
            CustomerController zmienna1 = pool[i].GetComponent<CustomerController>();
            if(zmienna1 != null)
            {
                zmienna1.skryptwybierajacyjedzenie = magazynskrypt;
            }

            pool[i].SetActive(false);
            
        }
    }

    void EnableObjectInPool()
    {
        for(int i = 0; i < pool.Length; i++)
        {
            if(pool[i].activeInHierarchy == false)
            {
                pool[i].SetActive(true);
                return;
            }
            
        }
    }
    IEnumerator SpawnCustomer()
    {
        while(true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(spawnTimer);
        }
    }

    
    
}
