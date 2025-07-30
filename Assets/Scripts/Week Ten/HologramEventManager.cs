using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HologramEventManager : MonoBehaviour
{
    //public static UnityEvent OnSpacebarPressed;

    public delegate void MyDelegate();
    public static MyDelegate onSpacebarPressed;
    public static MyDelegate onEPressed;
}
