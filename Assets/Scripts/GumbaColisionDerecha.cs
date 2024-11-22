using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumbaColisionDerecha : MonoBehaviour
{

    public Gumba gumba;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gumba.CollisionLateralDerechaGumba();
    }
}
