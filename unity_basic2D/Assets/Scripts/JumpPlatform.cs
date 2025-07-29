using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    // 1. Animator Component를 Awake 함수에서 값을 초기화 해주세요. Setup

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        PlayTriggerAnimation("Trigger");
    }

    public void PlayTriggerAnimation(string paramName)
    {
        animator.SetTrigger(paramName);
    }
}
