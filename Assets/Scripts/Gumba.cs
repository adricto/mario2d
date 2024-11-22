using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gumba : MonoBehaviour
{
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity=Vector2.right*speed;
    }

    public void CollisionLateralDerechaGumba()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        GetComponent<Animator>().SetInteger("Horizontal", -1);
    }

    public void CollisionLateralIzqGumba()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        GetComponent<Animator>().SetInteger("Horizontal", 1);
    }

    public void CollisionCabeza()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("ScenaFinal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
