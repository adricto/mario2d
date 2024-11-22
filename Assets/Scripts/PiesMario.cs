using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiesMario : MonoBehaviour
{
    public MarioMovimiento mario;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Mario en sue");
        if (collision.gameObject.tag == "suelo")
        {
            Debug.Log("Mario en suelo");
            mario.estaSuelo = true;
        }

        if (collision.gameObject.tag == "gumba")
        {
            Destroy(collision.gameObject);
        }
    }
}
