using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    [SerializeField] RuntimeUI runtimeUI;
    [Header("Life")]
    [SerializeField] int currentLife;
    [SerializeField] int maxLife = 10;
    [Header("Coin")]
    [SerializeField] int currentCoin;
    [SerializeField] int maxCoinForLife = 100;
    // ������ ������ �� ���� ����� �ִ� ������� �����Ѵ�. 
    // �������� �����Ѵ�.
    private void Start()
    {
        currentLife = maxLife / 2;
        currentCoin = 0;
        OnLifeUpdated(0);
        OnCoinUpdated(currentCoin);
    }

    public void OnLifeUpdated(int amount)
    {
        currentLife += amount;

        if(currentLife > maxLife)
        {
            currentLife = maxLife;
        }

        // RuntimeUI.LifeUpdate ����.
        runtimeUI.OnLifeUpdated(currentLife);
    }

    public void OnCoinUpdated(int amount)
    {
        currentCoin += amount;

        if(currentCoin >= maxCoinForLife)
        {
            currentCoin -= maxCoinForLife;
            OnLifeUpdated(1);
        }

        runtimeUI.OnCoinUpdated(currentCoin);
    }
    public bool IsPlayerDead()
    {
        return currentLife <= 0;
    }

}
