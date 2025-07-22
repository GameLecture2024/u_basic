using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // 충돌한 녀석의 게임 오브젝트에서 색상을 변경할 수 있는 컴포넌트(Sprite Renderer)가 있으면 그 색깔을 붉은색으로 변경하세요.

            SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>();

            if(_sr != null)
            {
                _sr.color = Color.red;
                Invoke(nameof(ResetColor), 0.5f);
            }

           

            //
            //if(collision.TryGetComponent(out SpriteRenderer sr))
            //{
            //    sr.color = Color.red;
            //}
        }
    }

    private void ResetColor(SpriteRenderer sr)
    {
        sr.color = Color.white;
    }

}
