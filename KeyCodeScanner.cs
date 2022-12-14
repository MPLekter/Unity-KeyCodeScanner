using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCodeScanner : MonoBehaviour
{
    private readonly Array keyCodes = Enum.GetValues(typeof(KeyCode));
    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in keyCodes)
            {
                if (Input.GetKey(keyCode))
                {
                    Debug.Log("KeyCode down: " + keyCode);
                    break;
                }
            }
        }
    }
}
