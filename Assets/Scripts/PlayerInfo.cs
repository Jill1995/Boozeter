using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static int health = 4;

    private void OnDestroy()
    {
        Debug.Log("Object Destroyed");
    }
}

