using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float Vel = 1f;

    private void Start()
    {
        Destroy(gameObject, 1.4f);
    }
    void Update()
    {
        transform.position += transform.up * Vel * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
