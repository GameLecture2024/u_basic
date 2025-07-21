using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 도전과제 : Tag를 이용해서 선택한 게임오브젝트만 다음 코드를 실행할 수 있도록 변경해보세요.

public class CollisionCheck : MonoBehaviour
{
    // 용암에 들어온 상태
    public bool isLava;

    public GameObject nextPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 충돌함");
            Debug.Log("현재 상태가 용암에 빠진 상태입니다.");
            isLava = true;
            Destroy(collision.gameObject);
            Instantiate(nextPrefab, collision.transform.position, Quaternion.identity);
        }       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 충돌 상태에서 벗어남");
            Debug.Log("현재 상태가 용암 상태가 아닙니다");
            isLava = false;
        }     
    }
}
