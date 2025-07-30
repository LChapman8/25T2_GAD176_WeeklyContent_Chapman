using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram : MonoBehaviour
{
    private void OnEnable()
    {
        //HologramEventManager.OnSpacebarPressed.AddListener(HideTheCube);
        HologramEventManager.onSpacebarPressed += HideTheCube;
        HologramEventManager.onEPressed += ShowTheCube;
    }

    private void OnDisable()
    {
        //HologramEventManager.OnSpacebarPressed.RemoveListener(HideTheCube);
        HologramEventManager.onSpacebarPressed -= HideTheCube;
        HologramEventManager.onEPressed -= ShowTheCube;
    }

    private void HideTheCube()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    private void ShowTheCube()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
