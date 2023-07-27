using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    private void FixedUpdate()
    {
        gameObject.transform.Rotate(0,rotateSpeed,0);
    }
}
