using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public bool IsOnCollision = false;

    [SerializeField]
    private Color color;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("IsOnCollision == true");
        IsOnCollision = true;
    }
}
