using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.rotation = Quaternion.Euler(new Vector3(0, 43.101f + 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.rotation = Quaternion.Euler(new Vector3(0, 43.101f + 270, 0));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.rotation = Quaternion.Euler(new Vector3(0, 43.101f + 180, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.rotation = Quaternion.Euler(new Vector3(0, 43.101f + 90, 0));
            
        }


    }
}
