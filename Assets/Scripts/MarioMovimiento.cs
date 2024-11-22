using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovimiento : MonoBehaviour
{
    public int speed = 10;
    public float jumpForce = 10f; // Cambié a float para mayor precisión
    public bool estaSuelo = true;
    private Rigidbody2D rb;

    void Start()
    {
        // Referencia al Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        estaSuelo = true;
    }

    void Update()
    {
        // Movimiento horizontal
        float x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);

        // Actualizar animación
        GetComponent<Animator>().SetInteger("Horizontal", (int)x);

        // Salto
        if (estaSuelo && Input.GetButtonDown("Jump"))
        {
            Debug.Log("Mario salta");
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            estaSuelo = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si aterrizó en el suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaSuelo = true;
        }
    }
}