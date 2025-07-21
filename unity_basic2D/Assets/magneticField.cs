using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magneticField : MonoBehaviour
{
    public bool isSafe;
    public GameObject player;
    public float currentSize = 35;
    public float speed = 1f;
    private void Update()
    {
        currentSize -= Time.deltaTime * speed;
        if(currentSize <= 1)
        {
            currentSize = 1;
        }

        transform.localScale = Vector3.one * currentSize;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isSafe = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isSafe = false;
            Destroy(player);
        }
    }
}
