using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bank : MonoBehaviour
{

    [SerializeField] int startingBalance = 150;
    public int currentBalance;
    public int CurrentBalance {get { return currentBalance; } }
    public TMP_Text scoreText;

    void Awake()
    {
        currentBalance = startingBalance;
    }
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = currentBalance.ToString();
    }
    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        scoreText.text = currentBalance.ToString();
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        scoreText.text = currentBalance.ToString();
    }
}
