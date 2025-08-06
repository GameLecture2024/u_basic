using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int CoinAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var Coin = collision.GetComponent<PlayerEntity>();
            // CoinUpdate 함수를 실행하세요.
            Coin.OnCoinUpdated(CoinAmount);
            Destroy(gameObject);
        }
    }

}
