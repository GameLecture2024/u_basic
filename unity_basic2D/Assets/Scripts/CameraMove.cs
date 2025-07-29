using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target; // 카메라가 추적할 대상입니다.

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

        offset = transform.position - target.position;
        Debug.Log($"대상의 현재 위치 : {offset}");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
