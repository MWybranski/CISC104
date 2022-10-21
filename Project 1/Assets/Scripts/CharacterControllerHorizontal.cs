using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControllerHorizontal : MonoBehaviour
{
    public float MovementSpeed = 1;

    public Rigidbody2D rb;

    Vector2 movement;

    private Vector3 respawnPoint;
    public GameObject Enemies;
    public GameObject Trophy;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;

    }

    private void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MovementSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemies")
        {
            transform.position = respawnPoint;
        }

        if (collision.tag == "Trophy")
        {
            transform.position = respawnPoint;
        }
    }
}