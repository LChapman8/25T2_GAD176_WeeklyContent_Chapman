using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCube : MonoBehaviour
{
    [SerializeField] private float movementSpeedInUnitsPerSecond = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * movementSpeedInUnitsPerSecond;
    }
}
