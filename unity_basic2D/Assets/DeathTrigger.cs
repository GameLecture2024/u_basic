using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            var Life = collision.GetComponent<PlayerEntity>();
            Life.OnLifeUpdated(-1);
            GameOverPanel.SetActive(true);
            //if (Life.IsPlayerDead())
            //{
            //   
            //}
            // SavePoint로 돌아가야합니다.
            // GameOver오브젝트를 활성화하세요.
            //GameOverPanel.SetActive(true);
        }
    }
}
