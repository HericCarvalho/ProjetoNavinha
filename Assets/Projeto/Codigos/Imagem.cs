using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagem : MonoBehaviour
{
    public float Vel = -1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoAutomatico();
    }
    void MovimentoAutomatico()
    {
        if (transform.position.y > -5)
        {
            transform.position += new Vector3(0, Vel, 0) * Time.deltaTime;
        }
        if (transform.position.y <= -5)
        {
            transform.position = new Vector3(0, 5, 0);
        }
    }
}
