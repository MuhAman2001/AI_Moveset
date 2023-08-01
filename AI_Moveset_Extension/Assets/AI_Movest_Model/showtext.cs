using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class showtext : MonoBehaviour
{

    public Text textElement;
    public Gamepad gamepad;
    // Start is called before the first frame update
    void Start()
    {
        gamepad = Gamepad.current;
        textElement.text = "Started Server";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gamepad.xButton.wasPressedThisFrame)
        {
            textElement.text = "Started Server";
        }

        if (gamepad.yButton.wasPressedThisFrame)
        {
            textElement.text = "Stopped Server";
        }
    }
}
