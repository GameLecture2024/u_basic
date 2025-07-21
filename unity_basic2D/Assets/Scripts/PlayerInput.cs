using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider2D;
    [SerializeField] private Rigidbody2D rigidbody2D;

    [SerializeField] private float moveSpeed = 5f;

   private Vector2 moveVector;

    private void Start()
    {
        rigidbody2D.velocity = moveVector.normalized;
    }

    private void Update()
    {
        // w키를 입력했으면 x=0,y=1 movevector가 되어라
        // a키를 입력했으면 x=-1,y=0 movevector가 되어라

        if(Input.GetKeyDown(KeyCode.W))
        {
            moveVector = new Vector2(0, 1);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            moveVector = new Vector2(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveVector = new Vector2(0, -1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveVector = new Vector2(1, 0);
        }

        rigidbody2D.velocity = moveVector * moveSpeed;
    }
}
