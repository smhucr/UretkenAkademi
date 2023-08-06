using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        gameObject.transform.Translate(0, speed, 0);
    }
}
