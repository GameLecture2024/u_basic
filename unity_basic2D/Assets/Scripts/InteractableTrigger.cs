using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTrigger : MonoBehaviour
{
    [SerializeField] JumpPlatform jumpPlatform;


    // 이벤트 충돌 함수를 실행해보세요. OnTriggerEnter2D . Tag 이름 Player.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // 플레이어와 충돌했을 때 작동한다.
        {
            // JumpPlatform에 있는 PlayTriggerAnimation 함수를 실행한다.

            jumpPlatform.PlayTriggerAnimation("Trigger");
        }    
    }

    
}
