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
            // GameOver������Ʈ�� Ȱ��ȭ�ϼ���.
            GameOverPanel.SetActive(true);
        }
    }
}
