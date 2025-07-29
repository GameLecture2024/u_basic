using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    // Animator 컴포넌트를 가져와서 실행하는 함수를 만들어 보세요.
    // PlayerHandler에 PlayerAnimatorController 클래스를 참조할 수 있도록 연결해보세요. PlayBoolAnimator  
    // PlayerHandler에서 PlayerAnimatorController의 public으로 만들어진 애니메이터 실행 함수를 호출하세요.

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayerMoveAnimation()
    {
        PlayBoolAnimation("IsMove", true);
        PlayBoolAnimation("IsTurn", false);
    }

    public void PlayerTurnAnimation()
    {
        PlayBoolAnimation("IsMove", false);
        PlayBoolAnimation("IsTurn", true);
    }

    private void PlayBoolAnimation(string paramName, bool enable)
    {
        animator.SetBool(paramName, enable);
    }

}
