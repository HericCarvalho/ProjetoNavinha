using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemSaida : MonoBehaviour
{
    public BoxCollider2D Colisão;

    void OnTriggerExit2D(Collider2D other)
    {
        var exitingObj = other.transform;
        var position = exitingObj.position;

        var saidaPosition = transform.position;
        var saidaSize = Colisão.bounds.extents;

        if (position.x > (saidaPosition.x + saidaSize.x) || position.x < (saidaPosition.x + saidaSize.x))
            position.x = -position.x;

        if (position.y > (saidaPosition.y + saidaSize.y) || position.y < (saidaPosition.y + saidaSize.y))
            position.y = -position.y;
        exitingObj.position = position;
    }
}
