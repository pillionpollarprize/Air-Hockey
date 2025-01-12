using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform ball;
    public float speed = 10;
    private Rigidbody2D rb;
    private float halfScreenX;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        halfScreenX = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0, 0)).x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var targetPosition = Vector3.MoveTowards(transform.position, ball.position, speed * Time.deltaTime);
        targetPosition.x = Mathf.Clamp(targetPosition.x, -Mathf.Infinity, halfScreenX);
        rb.MovePosition(targetPosition);
    }
}
