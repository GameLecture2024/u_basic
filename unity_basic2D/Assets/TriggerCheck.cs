using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {


        if (collision.CompareTag("Enemy"))   // Tag 이름이 Enemy일 때만 아래 코드를 실행하세요.
        {        
            // 1. 충돌한 대상을 파괴시켜보세요.
            Destroy(collision.gameObject);
            // 2. 충돌한 자기 자신을 파괴시켜보세요.
            //Destroy(gameObject); 
        }

        // 조건문을 하나 생성해보세요.
        // Tag가 Player일 때 실행하는 코드입니다.
        // Debug.Log("충돌한 오브젝트의 이름 : " + collision.gameObject.name);
        if (collision.CompareTag("Player"))
        {
            Debug.Log("충돌한 오브젝트의 이름 : " + collision.gameObject.name);
        }
    }
}
