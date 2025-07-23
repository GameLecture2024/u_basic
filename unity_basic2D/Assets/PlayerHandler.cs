using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    // 멤버 변수
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 5.0f;

    [SerializeField] private KeyCode Jumpkey = KeyCode.Space;
    [SerializeField] private float jumpPower = 5f;

    [SerializeField] private float groundDistance = 1.2f;
    [SerializeField] private LayerMask groundLayer;

    // Awake함수
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();   
    }

    // Start함수

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }

    // Update함수
    private void Update()
    {
        Move();
        Jump();

    }

    private void Jump()
    {
        // 점프 조건 
        // 점프 구현

        if (CanJump())
        {
            // 숫자 5를 멤버 변수의 점프 크기(jumpPower)로 표현해보세요.
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpPower);
        }

        Debug.DrawRay(transform.position, Vector3.down * groundDistance, Color.red);
    }

    private bool CanJump()
    {
        return Input.GetKeyDown(Jumpkey) && GroundCheck();
    }

    private bool GroundCheck()
    {
        RaycastHit2D hit =  Physics2D.Raycast(transform.position, Vector2.down, groundDistance, groundLayer);
        return hit.collider != null;
    }

    private void Move()
    {
        // 1. 플레이어의 입력을 받아야 합니다. A,D // 화살표 <- , ->  x의 좌표를 변경해야합니다.
        // 2. rigidbody.velocity 변경해서 이동을 구현한다.

        float horizontal = Input.GetAxisRaw("Horizontal");
        // 위에 있는 horizontal을 이용해서 vector2의 x값을 변경하는 코드를 만들어보세요
        // 멤버 변수로 이동 속도 변수를 하나 추가해서 vector의 현재 크기에 속도를 곱한 값으로 이동하도록 코드를 작성해보세요.
        rigidbody2D.velocity = new Vector2(horizontal * moveSpeed, rigidbody2D.velocity.y);
    }
}
