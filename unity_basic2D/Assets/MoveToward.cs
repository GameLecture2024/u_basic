using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float moveSpeed;      // float 타입의 변수를 선언해서 이동 속도에 곱해준다.
    [SerializeField] private Vector3 startVector;

    // 변수 선언

    // 변수에 데이터를 넣어줘야한다.
    // 데이터의 초기화가 필요하다.
    // Start is called before the first frame update
    void Start()
    {
        transform.position
            = transform.position + startVector;

        // 이동하는 방향만 표현해주는 방법. (벡터의 정규화)
        startVector = startVector.normalized;

        startVector = (target.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        startVector = (target.position - transform.position).normalized;
        transform.position += startVector * moveSpeed * Time.deltaTime;
    }
}
