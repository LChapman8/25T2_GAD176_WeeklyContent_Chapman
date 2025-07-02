using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// rolls the sphere around using physics based on player input or target direction 
/// </summary>

public class PhysicsMover : MonoBehaviour
{
    [SerializeField] private Rigidbody sphere;

    [SerializeField] private bool isCurrentlyChasing = false;

    private void FixedUpdate()
    {
        if (isCurrentlyChasing == false)
        {
            if (sphere.velocity.magnitude < 20)
            {
                sphere.AddForce(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            }
        }

        else
        {

        }
    }
}
