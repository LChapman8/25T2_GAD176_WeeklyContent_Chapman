using System.Collections;
using System.Collections.Generic;
using SeaWizards.Staffs;
using UnityEngine;

/// <summary>
/// rolls the sphere around using physics based on player input or target direction 
/// </summary>

public class PhysicsMover : MonoBehaviour
{
    [SerializeField] private Rigidbody sphere;

    [SerializeField] private GameObject chaseTarget;
    [SerializeField] private bool isCurrentlyChasing = false;
   

    private void FixedUpdate()
    {
        if (isCurrentlyChasing == false)
        {
            if (sphere.velocity.magnitude < 20)
            {
                sphere.AddForce(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            }
        }

        else
        {
            if (sphere.velocity.magnitude < 20)
            {
                sphere.AddForce(chaseTarget.transform.position - gameObject.transform.position);
            }
        }
    }
}
