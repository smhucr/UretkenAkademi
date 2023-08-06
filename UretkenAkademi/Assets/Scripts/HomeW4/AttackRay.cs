using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRay : MonoBehaviour
{
    RaycastHit hit;
    public Transform tran;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(tran.position, transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.transform.CompareTag("Enemy"))
                {
                    Destroy(hit.transform.gameObject);
                }
                print(hit);
            }
        }

    }

}
