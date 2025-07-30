using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HologramManager : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            HologramEventManager.onSpacebarPressed?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            HologramEventManager.onEPressed?.Invoke();
        }
    }
}
