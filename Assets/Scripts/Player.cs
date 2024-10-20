using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 worldPosition;
    private Rigidbody2D rb;
    private float halfScreenX;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();

        halfScreenX = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0, 0)).x;
    }

    // Update is called once per frame
    void Update()
    {
        worldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0; 
        worldPosition.x = Mathf.Clamp(worldPosition.x, halfScreenX, Mathf.Infinity);
        //transform.position = worldPosition;
    }
    // physics update
    void FixedUpdate()
    {
        rb.MovePosition(worldPosition);
    }
}
