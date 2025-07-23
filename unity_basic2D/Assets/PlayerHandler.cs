using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    // ��� ����
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 5.0f;

    [SerializeField] private KeyCode Jumpkey = KeyCode.Space;
    [SerializeField] private float jumpPower = 5f;

    [SerializeField] private float groundDistance = 1.2f;
    [SerializeField] private LayerMask groundLayer;

    // Awake�Լ�
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();   
    }

    // Start�Լ�

    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }

    // Update�Լ�
    private void Update()
    {
        Move();
        Jump();

    }

    private void Jump()
    {
        // ���� ���� 
        // ���� ����

        if (CanJump())
        {
            // ���� 5�� ��� ������ ���� ũ��(jumpPower)�� ǥ���غ�����.
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
        // 1. �÷��̾��� �Է��� �޾ƾ� �մϴ�. A,D // ȭ��ǥ <- , ->  x�� ��ǥ�� �����ؾ��մϴ�.
        // 2. rigidbody.velocity �����ؼ� �̵��� �����Ѵ�.

        float horizontal = Input.GetAxisRaw("Horizontal");
        // ���� �ִ� horizontal�� �̿��ؼ� vector2�� x���� �����ϴ� �ڵ带 ��������
        // ��� ������ �̵� �ӵ� ������ �ϳ� �߰��ؼ� vector�� ���� ũ�⿡ �ӵ��� ���� ������ �̵��ϵ��� �ڵ带 �ۼ��غ�����.
        rigidbody2D.velocity = new Vector2(horizontal * moveSpeed, rigidbody2D.velocity.y);
    }
}
