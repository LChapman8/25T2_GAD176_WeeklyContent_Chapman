using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            // rotate left 
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            // rotate right
            transform.Rotate(0, 1, 0);
        }
    }
}
