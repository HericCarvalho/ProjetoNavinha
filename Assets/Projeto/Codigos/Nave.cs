using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public Rigidbody2D RDB;
    public float Vel = 0.4f;
    public float Gir = 0.2f;
    public SpriteRenderer fireball;
    public GameObject Tiro;
    public Recomeçar recomeçar;
    void Update()
    {
        Movimento();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var tiro = Instantiate(Tiro, transform.position, transform.rotation);
        }
    }
    void Movimento()
    {
        if (Input.GetKey(KeyCode.W))
        {
            RDB.AddRelativeForce(Vector2.up * Vel);
            fireball.enabled = true;
        }
        else
        {
            fireball.enabled = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            RDB.AddTorque(Gir);
        }
        if (Input.GetKey(KeyCode.D))
        {
            RDB.AddTorque(-Gir);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.tag == "Asteroid")
        {
            recomeçar.restart();
            gameObject.SetActive(false);
        }
    }
}
