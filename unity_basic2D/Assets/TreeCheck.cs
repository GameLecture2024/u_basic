using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 나무와 플레이어가 부딪히면 플레이어가 파괴된다.
public class TreeCheck : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
