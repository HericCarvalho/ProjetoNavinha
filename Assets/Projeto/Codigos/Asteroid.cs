using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Rigidbody2D RDB;
    public float Vel = 1;
    public float Rot = 1;
    float Dire��o;
    float Rota��o;
    Vector2 Reta;

    private void Start()
    {
        Dire��o = Random.value > 0.5f ? -1f : 1f;
        Reta = (Vector3.zero - transform.position).normalized;
    }
    private void FixedUpdate()
    {
        RDB.velocity = Reta * Vel;
    }
    private void Update()
    {
        Rota��o += Dire��o * Time.smoothDeltaTime * Rot;
    }
}
