using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram : MonoBehaviour
{
    [SerializeField] private int health = 2;
    [SerializeField] private static float speed = 10.1f;
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

    private void Start()
    {
        //normal variable
        print($"Health of {gameObject.name} is {health} Nice!");
        // static variable 
        speed = Random.Range(2.5f, 100f);
        print($"Speed static variable is set to {speed} ! nice !");
   
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print($"Speed of {gameObject.name} is {speed} Nice!");
        }
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
